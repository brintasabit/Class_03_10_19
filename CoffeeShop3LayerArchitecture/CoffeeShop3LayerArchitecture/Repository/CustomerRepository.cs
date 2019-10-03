using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop3LayerArchitecture.Model;

namespace CoffeeShop3LayerArchitecture.Repository
{
   public class CustomerRepository
    {
        public bool AddCustomer(Customer _customer)
        {
            if (_customer.Item=="Hot")
            {
                double totalPrice = _customer.Quantity * 120;
                string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Customers values('" + _customer.Name + "' ,'" + _customer.Contact + "','" + _customer.Address + "','" + _customer.Item + "'," + _customer.Quantity + ","+totalPrice+" )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();
            }
            else if (_customer.Item == "Regular")
            {
                double totalPrice = _customer.Quantity * 80;
                string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Customers values('" + _customer.Name + "' ,'" + _customer.Contact + "','" + _customer.Address + "','" + _customer.Item + "'," + _customer.Quantity + "," + totalPrice + " )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();
            }
            
            return false;
        }
        public DataTable ShowCustomer()
        {

            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Customers";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConn.Close();
            return dataTable;


        }
        public DataTable SearchCustomer(Customer _customer)
        {

            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Customers where Name='" + _customer.Name + "'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConn.Close();

            return dataTable;
        }
        public DataTable ShowComboBox()
        {

            string conn = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select Name,ID from Items";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConn.Close();
            return dataTable;


        }
    }
}
