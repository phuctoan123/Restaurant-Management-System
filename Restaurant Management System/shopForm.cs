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
using System.IO;

namespace Restaurant_Management_System
{
    public partial class shopForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Acer\source\repos\Restaurant Management System\restaurantsystem.mdf"";Integrated Security=True;Connect Timeout=30";
        public shopForm()
        {
            InitializeComponent();
            loadProducts();
        }

        public void cardItems(int id, string productname, string stock, 
            string price, Image image, string productid, string category, string quantity)
        {
            var card = new cardProduct
            {
                id = id,
                productName = productname,
                productStock = stock,
                productPrice = price,
                productImage = image,
                productId = productid,
                category = category,
                productQuantity = quantity
            };

            flowLayoutPanel1.Controls.Add(card);

            card.selectCard += (q, w) =>
            {
                var selectedCard = (cardProduct)q;
                bool flag = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCard.id)
                    {
                        decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                        int getQuantity = Convert.ToInt32(selectedCard.productQuantity);

                        row.Cells["QTY"].Value = selectedCard.productQuantity;
                        flag = true;
                        break;
                    }

                }

                if (!flag)
                {
                    decimal getPrice = Convert.ToDecimal(selectedCard.productPrice.Replace("$", ""));
                    int getQuantity = Convert.ToInt32(selectedCard.productQuantity);
                    dataGridView1.Rows.Add(selectedCard.id, selectedCard.productName, getQuantity, getPrice *  getQuantity);
                }
                updateTotalPrice();
            };

        }

        private void updateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id"].Value != null)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    totalPrice += price;
                }
            }

            shop_total.Text = $"${totalPrice:F2}";
        }

        public void loadProducts()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            int id = row["id"] != DBNull.Value ? (int)row["id"] : 0;
                            string productname = row["productname"] != DBNull.Value ? row["productname"].ToString() : "N/A";
                            string stock = row["stock"] != DBNull.Value ? row["stock"].ToString() : "0";
                            string price = row["price"] != DBNull.Value ? $"${row["price"].ToString()}.00" : "0.00";
                            
                            string productid = row["productid"] != DBNull.Value ? row["productid"].ToString() : "N/A";
                            string category = row["category"] != DBNull.Value ? row["category"].ToString() : "N/A";
                            //string quantity = row["quantity"] != DBNull.Value ? row["quantity"].ToString() : "1";

                            Image image = null;
                            if (row["image"] != DBNull.Value)
                            {
                                string imagePath = row["image"].ToString();
                                if(!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    try
                                    {
                                        image = Image.FromFile(imagePath);
                                    } catch(Exception ex)
                                    {
                                        image = null;
                                    }

                                }
                            }

                            cardItems(id, productname, stock, price, image, productid, category ,"");


                        }
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shopForm_Load(object sender, EventArgs e)
        {

        }

        private void shop_change_Enter(object sender, EventArgs e)
        {
            try
            {
                decimal getTotal = Convert.ToDecimal(shop_total.Text.Replace("$", ""));
                decimal getChange = Convert.ToDecimal(shop_change.Text);
                if (getTotal < getChange)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    shop_amount.Text = $"${getChange - getTotal}";
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   

            }

        }

        bool check = false;
        private void shop_change_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    decimal getTotal = Convert.ToDecimal(shop_total.Text.Replace("$", ""));
                    decimal getChange = Convert.ToDecimal(shop_change.Text);
                    if (getTotal > getChange)
                    {
                        MessageBox.Show("Invalid Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        check = true;
                        shop_amount.Text = $"${(getChange - getTotal):0.00}";
                    }
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void shop_placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Invalid Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure you want to proceed ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string countData = "SELECT COUNT(*) FROM orders";

                        int count = 1;

                        using (SqlCommand cmd = new SqlCommand(countData, connect))
                        {
                            count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

                        }
                        List<String> productIds = new List<String>();
                        List<String> quantities = new List<String>();
                        List<String> prices = new List<String>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"] != null && row.Cells["QTY"] != null && row.Cells["price"] != null)
                            {
                                productIds.Add(row.Cells["id"].Value.ToString());
                                quantities.Add(row.Cells["QTY"].Value.ToString());
                                prices.Add(row.Cells["price"].Value.ToString());

                            }
                        }

                        string productIdsStr = string.Join(",", productIds);
                        string quantitiesStr = string.Join(",", quantities);
                        string pricesStr = string.Join(",", prices);

                        decimal totalAmount = Convert.ToDecimal(shop_total.Text.Replace("$", ""));

                        string insertData = "INSERT INTO orders(customerId, productIds, quantities, " +
                            "prices, total, date_order) VALUES(@cid, @pid, @qty, @price, @total, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cid",  $"CID-{count}");
                            cmd.Parameters.AddWithValue("@pid", productIdsStr);
                            cmd.Parameters.AddWithValue("@qty", quantitiesStr);
                            cmd.Parameters.AddWithValue("@price", pricesStr);
                            cmd.Parameters.AddWithValue("@total", totalAmount);

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today);

                            int rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                for (int q = 0; q < productIds.Count; q++)
                                {
                                    string getStockData = "SELECT stock FROM products WHERE id = @id";
                                    int currentStock = 0;

                                    using (SqlCommand getSD = new SqlCommand(getStockData, connect))
                                    {
                                        getSD.Parameters.AddWithValue("@id", productIds[q]);
                                        
                                        object result = getSD.ExecuteScalar();

                                        if (result != null)
                                        {
                                            currentStock = Convert.ToInt32(result);
                                        }
                                    }

                                    int newStock = currentStock - Convert.ToInt32(quantities[q]);

                                    if (newStock < 0)
                                    {
                                        MessageBox.Show($"Invalid: Insufficient Stock for product ID: {productIds[q]}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }

                                    string updateData = "UPDATE products SET stock = @qty WHERE id = @id";

                                    using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@qty", newStock);
                                        updateCmd.Parameters.AddWithValue("@id", productIds[q]);

                                        updateCmd.ExecuteNonQuery();

                                    }
                                }
                                MessageBox.Show("Order Placed Sucessfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Order placement failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                    }
                 }
                    
            }

        }

        private int rowIndex = 0;

        private void shop_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 20;
            int tableMargin = 10;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "MarcoMan's Restaurant";
            y = (margin + headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = {"PID", "ProdName", "Category", "Qty", "Price"};

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while(rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                for (int q = 0; q < dataGridView1.Columns.Count;q++)
                {
                    object cellValue = row.Cells[q].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

            }

            int labelMargin = (int)Math.Min(rSpace, 200);
            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right + e.Graphics.MeasureString("-------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \t{shop_total.Text.Trim()}\nAmount: \t${shop_change.Text.Trim()}\n\t\t-----------------------\nChange:\t{shop_amount.Text.Trim()}", labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("---------------", labelFont).Width, y);


        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }
    }
   }
