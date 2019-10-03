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
    public partial class Items : Form
    {
        Item _item = new Item();
        ItemManager _itemManager = new ItemManager();
        
        public Items()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            dataGridViewItem.DataSource = _itemManager.ShowItem();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                _item.Name = textBoxItem.Text;
                _item.Price = Convert.ToInt32(textBoxPrice.Text);
                _item.SearchName = textBoxSearch.Text;
               List<Item>items = _itemManager.SearchItem(_item);
                if (items.Count > 0)
                {
                    MessageBox.Show("Item Name Exists");
                }
                else
                {
                    bool isAdded = _itemManager.AddItem(_item);
                    if (isAdded)
                    {
                        MessageBox.Show("Saved");
                    }
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _item.SearchName = textBoxSearch.Text;
                List<Item> items= _itemManager.SearchItem(_item);
                if (items.Count > 0)
                {

                    dataGridViewItem.DataSource = _itemManager.SearchItem(_item);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _item.Name = textBoxItem.Text;
                _item.Price = Convert.ToInt32(textBoxPrice.Text);
                _item.Id = Convert.ToInt32(textBoxId.Text);
                bool isUpdated = _itemManager.UpdateItem(_item);
                if (isUpdated)
                {
                    dataGridViewItem.DataSource = _itemManager.ShowItem();
                }
                
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _item.Id = Convert.ToInt32(textBoxId.Text);
                bool isDeleted = _itemManager.DeleteItem(_item);
                if (isDeleted)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
