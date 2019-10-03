using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop3LayerArchitecture.Bill;
using CoffeeShop3LayerArchitecture.Model;

namespace CoffeeShop3LayerArchitecture
{
    public partial class Orders : Form
    {
        OrderManager _orderManager=new OrderManager();
        Order _order=new Order();
        public Orders()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
           dataGridViewOrder.DataSource = _orderManager.ShowOrder();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            comboBoxCustomerName.DataSource = _orderManager.ShowComboBoxCustomer();
            comboBoxCustomerOrder.DataSource = _orderManager.ShowComboBoxItem();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _order.SearchName = textBoxSearch.Text;
                DataTable isSearch = _orderManager.SearchOrder(_order);
                if (isSearch.Rows.Count > 0)
                {

                    dataGridViewOrder.DataSource = _orderManager.SearchOrder(_order);
                    MessageBox.Show("Data Found");
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _order.Name = comboBoxCustomerName.Text;
                _order.Item = comboBoxCustomerOrder.Text;
                _order.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                // _order.TotalPrice = Convert.ToInt32(priceTextBox.Text);
                bool isAdded = _orderManager.AddOrder(_order);
                if (isAdded)
                {
                   // _orderManager.ShowOrder();
                    MessageBox.Show("Saved");
                    
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
