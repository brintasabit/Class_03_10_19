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
     class ItemRepository
    {
        public List<Item> ShowItem()
        {
            List<Item>items=new List<Item>();
            string conn = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Items";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            /*  SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
              DataTable dataTable = new DataTable();
              sqlDataAdapter.Fill(dataTable);*/
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Item item = new Item();
                item.Id = Convert.ToInt32(sqlDataReader["Id"]);
                item.Name = sqlDataReader["Name"].ToString();
                item.Price = Convert.ToDouble(sqlDataReader["Price"]);
                items.Add(item);
            }

            sqlConn.Close();
            return items;


        }
        public List<Item> SearchItem(Item _item)
        {
            List<Item>items=new List<Item>();
            string conn = @"Server=PC-301-28\SQLEXPRESS; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"select * from Items where Name='" + _item.SearchName + "'";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
          /*  SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);*/

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
              while (sqlDataReader.Read())
              {
                  Item item=new Item();
                 // item.Id = Convert.ToInt32(sqlDataReader["Id"]);
                  item.Name = sqlDataReader["Name"].ToString();
                  item.Price = Convert.ToDouble(sqlDataReader["Price"]);
                  items.Add(item);
              }

            sqlConn.Close();

            return items;
        }
        public bool AddItem(Item _item)
        {
            string connectionString = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"insert into Items values('" + _item.Name + "' ," + _item.Price + " )";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        public bool UpdateItem(Item _item)
        {
            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"update Items set Name='" + _item.Name + "',Price= " + _item.Price + " where ID=" + _item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            bool isExecuted = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
            if (isExecuted)
            {
                string command2 = @"select * from Items where ID=" + _item.Id + "";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand2);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
            }
            sqlConn.Close();
            return false;
        }
        public bool DeleteItem(Item _item)
        {
            string conn = @"Server=BRINTA-PC; Database=CoffeeShop; Integrated Security=true";
            SqlConnection sqlConn = new SqlConnection(conn);
            string command = @"delete from Items where ID=" + _item.Id + "";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
            sqlConn.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            if (isExecuted > 0)
            {
                return true;
            }
            sqlConn.Close();
            return false;
        }
    }
}
