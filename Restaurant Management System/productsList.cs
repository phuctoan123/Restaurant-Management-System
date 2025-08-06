using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    class productsList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Acer\source\repos\Restaurant Management System\restaurantsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string stock { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }


        public List<productsList> productListData()
        {
            List<productsList> listData = new List<productsList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        productsList pList = new productsList();

                        pList.ID = (int)reader["id"];
                        pList.ProductId = reader["productid"].ToString();
                        pList.ProductName = reader["productname"].ToString();
                        pList.Category = reader["category"].ToString();
                        pList.stock = reader["stock"].ToString();
                        pList.price = reader["price"].ToString();
                        pList.status = reader["status"].ToString();
                        pList.image = reader["image"].ToString();
                        pList.price = reader["price"].ToString();
                        pList.DateInsert = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");
                        pList.DateUpdate = reader["date_update"] == DBNull.Value ? null : ((DateTime)reader["date_update"]).ToString("MM-dd-yyyy");

                        listData.Add(pList);

                    }

                }

            } 

            return listData;

        }

    }
}
