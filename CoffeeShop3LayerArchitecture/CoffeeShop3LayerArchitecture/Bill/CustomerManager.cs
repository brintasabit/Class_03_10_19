using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Repository;
using CoffeeShop3LayerArchitecture.Model;
namespace CoffeeShop3LayerArchitecture.Bill
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();
        public DataTable ShowCustomer()
        {
            return _customerRepository.ShowCustomer();
        }

        public DataTable SearchCustomer(Customer _customer)
        {
            return _customerRepository.SearchCustomer(_customer);
        }
        public bool AddCustomer(Customer _customer)
        {
            return _customerRepository.AddCustomer(_customer);

        }

        public DataTable ShowComboBox()
        {
            return _customerRepository.ShowComboBox();
        }
    }
}
