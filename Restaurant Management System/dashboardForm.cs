using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Restaurant_Management_System
{
    public partial class dashboardForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Acer\source\repos\Restaurant Management System\restaurantsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public dashboardForm()
        {
            InitializeComponent();

            displayTotalUsers();
            displayTotalProducts();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayTodaysSales()

        }

        public void displayTodaysSales()
        {
            customersList cData = new customersList();
            List<customersList> listData = cData.todaysSalescustomerListData();

            dataGridView1.DataSource = listData;

        }

        public void displayTotalUsers()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalUsers.Text = count.ToString();


                    }

                }

            }

        }

        public void displayTotalProducts()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalProducts.Text = count.ToString();


                    }

                }

            }

        }

        public void displayTodaysRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT SUM(CAST(total as DECIMAL(10, 2))) FROM orders WHERE date_order = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    string getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getToday);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            decimal revenue = Convert.ToDecimal(reader[0]);
                            dashboard_todaysRevenue.Text = "$" + revenue.ToString("0.00");
                                
                        }
                        else
                        {
                            dashboard_todaysRevenue.Text = "$0.00";
                        }

                    }

                }

            }

        }

        public void displayTotalRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT SUM(CAST(total as DECIMAL(10, 2))) FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                        {
                            decimal revenue = Convert.ToDecimal(reader[0]);
                            dashboard_totalRevenue.Text = "$" + revenue.ToString("0.00");
                        }
                        else
                        {
                            dashboard_totalRevenue.Text = "$0.00";
                        }
                    }
                }
            }
        }
        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
