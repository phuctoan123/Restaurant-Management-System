using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Restaurant_Management_System
{
    class customersList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Acer\source\repos\Restaurant Management System\restaurantsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public int id { get; set; }
        public string customerId { get; set; }
        public string productsIds { get; set; }
        public string quantities { get; set; }
        public string prices { get; set; }
        public string totalPrice { get; set; }
        public string dateOrder { get; set; }

        public List<customersList> customerListData()
        {
            List<customersList> listData = new List<customersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customersList cData = new customersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productIds"].ToString();
                        cData.quantities = reader["prices"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);




                    }
                }
            }

            return listData;

        }

        public List<customersList> todaysSalescustomerListData()
        {
            List<customersList> listData = new List<customersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders WHERE date_order = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    String getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getToday);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customersList cData = new customersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productIds"].ToString();
                        cData.quantities = reader["prices"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);




                    }
                }
            }

            return listData;

        }


    }
}
