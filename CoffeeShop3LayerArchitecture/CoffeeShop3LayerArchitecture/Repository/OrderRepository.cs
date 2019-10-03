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
    class OrderRepository
    {
        
        public DataTable ShowComboBoxCustomer()
        {
            string conn = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select Name from Customers";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConn.Close();
            return dataTable;
        }
        public DataTable ShowComboBoxItem()
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
        public DataTable ShowOrder()
        {

            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Orders";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConn.Close();
            return dataTable;


        }
        public DataTable SearchOrder(Order _order)
        {
            string conn = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Orders where Name='" + _order.SearchName + "'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConn.Close();
            return dataTable;
        }
        public bool AddOrder(Order _order)
        {
            if (_order.Item=="Hot")
            {
                _order.TotalPrice = _order.Quantity * 120;
                string connectionString = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Orders values('" + _order.Name + "' ,'"+_order.Item+"'," + _order.Quantity + "," + _order.TotalPrice + " )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                sqlConnection.Close();
            }
            else if (_order.Item == "Regular")
            {
                _order.TotalPrice = _order.Quantity * 80;
                string connectionString = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Orders values('" + _order.Name + "','" + _order.Item + "' ," + _order.Quantity + "," + _order.TotalPrice + " )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                sqlConnection.Close();
            }
            else if (_order.Item == "Cold")
            {
                _order.TotalPrice = _order.Quantity * 100;
                string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Orders values('" + _order.Name + "','" + _order.Item + "' ," + _order.Quantity + "," + _order.TotalPrice + " )";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                sqlConnection.Close();
            }
            else if (_order.Item == "Black")
            {
                _order.TotalPrice = _order.Quantity * 90;
                string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string commandString = @"insert into Orders values('" + _order.Name + "','"+_order.Item+"','"+_order.Item+"' ," + _order.Quantity + "," + _order.TotalPrice + " )";
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
    }
}
