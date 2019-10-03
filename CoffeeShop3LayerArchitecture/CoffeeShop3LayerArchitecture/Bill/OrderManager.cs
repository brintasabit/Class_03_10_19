using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Model;
using CoffeeShop3LayerArchitecture.Repository;

namespace CoffeeShop3LayerArchitecture.Bill
{
    class OrderManager
    {
        OrderRepository _orderRepository=new OrderRepository();

        public DataTable ShowComboBoxCustomer()
        {
            return _orderRepository.ShowComboBoxCustomer();
        }
        public DataTable ShowComboBoxItem()
        {
            return _orderRepository.ShowComboBoxItem();
        }
        public DataTable ShowOrder()
        {
            return _orderRepository.ShowOrder();
        }
        public DataTable SearchOrder(Order _order)
        {
            return _orderRepository.SearchOrder(_order);
        }

        public bool AddOrder(Order _order)
        {
            return _orderRepository.AddOrder(_order);
        }
    }
}
