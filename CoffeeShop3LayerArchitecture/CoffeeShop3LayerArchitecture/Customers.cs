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
    public partial class Customers : Form
    {
        Items items=new Items();
        Orders orders=new Orders();
        CustomerManager _customerManager=new CustomerManager();
        Customer _customer=new Customer();
        
        public Customers()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Name = nameTextBox.Text;
                _customer.Address = addressTextBox.Text;
                _customer.Contact = contactTextBox.Text;
                _customer.Item = comboBoxItem.Text;
                _customer.Quantity =Convert.ToInt32(quantityTextBox.Text) ;
                DataTable isSearch = _customerManager.SearchCustomer(_customer);
                if (isSearch.Rows.Count > 0)
                {
                    MessageBox.Show("Name Exists");
                }
                else
                {
                    bool isAdded = _customerManager.AddCustomer(_customer);
                    if (isAdded)
                    {
                        MessageBox.Show("Saved");
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = _customerManager.ShowCustomer();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Name = textBoxSearch.Text;
                DataTable isSearch = _customerManager.SearchCustomer(_customer);
                if (isSearch.Rows.Count > 0)
                {

                    dataGridViewCustomers.DataSource = _customerManager.SearchCustomer(_customer);
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

        private void ItemButton_Click(object sender, EventArgs e)
        {
            if (items.IsDisposed)
            {
                items =new Items();
            }
            items.Show();
            items.BringToFront();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            comboBoxItem.DataSource = _customerManager.ShowComboBox();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (orders.IsDisposed)
            {
                orders = new Orders();
            }
            orders.Show();
            orders.BringToFront();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
