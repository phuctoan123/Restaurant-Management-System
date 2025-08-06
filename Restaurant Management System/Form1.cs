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
using System.Threading;


namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Acer\source\repos\Restaurant Management System\restaurantsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app ?", "Configuration Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signupForm signupForm = new signupForm();
            signupForm.Show();

            this.Hide();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread.Sleep(1000);
                        MainForm mainForm = new MainForm();
                        mainForm.Show();

                        this.Hide();

                    } 
                    else
                    {
                        MessageBox.Show("Incorrect username or password !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';//Checked = true ? Showpassword : '*'

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, label4.Font.Style | FontStyle.Underline);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, label4.Font.Style & ~FontStyle.Underline);
        }

        private void login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }
    }
}
