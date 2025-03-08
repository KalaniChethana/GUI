using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;

namespace ToyShop
{
    public partial class ChashierOder : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public ChashierOder()
        {
            InitializeComponent();
            displayAllAvailableProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();
            clearDataGrid();


        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllAvailableProducts();
            displayAllCategories();
            displayOrders();
            displayTotalPrice();

        }

        public void displayAllAvailableProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.allAvailableProducts();

            dataGridView1.DataSource = listData;

        }
        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listData;
        }
        public void clearDataGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open(); // Open the connection if it's closed
            }
            return connect.State == ConnectionState.Open;
        }

        public void displayAllCategories()
        {
            try
            {
                checkConnection(); // Ensure connection is open

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        casheirOder_Category.Items.Clear(); // Clear existing items

                        while (reader.Read())
                        {
                            string item = reader["category"].ToString(); // Use the correct column name
                            casheirOder_Category.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close(); // Close connection after fetching
            }


        }


        

        private void casheirOder_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            casheirOder_ProductID.SelectedIndex = -1;
            casheirOder_ProductID.Items.Clear();
            casheirOder_ProductName.Text = " ";
            casheirOder_price.Text = " ";



            string selectedValue = casheirOder_Category.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }


                    string selectData = "SELECT * FROM products WHERE category = @category AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", selectedValue);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            casheirOder_ProductID.Items.Clear();
                            while (reader.Read())
                            {
                                string value = reader["prod_id"].ToString();
                                casheirOder_ProductID.Items.Add(value);
                            }


                            if (casheirOder_ProductID.Items.Count == 0)
                            {
                                MessageBox.Show("No available products found for this category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to fetch products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void casheirOder_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = casheirOder_ProductID.SelectedItem as string;

            if (checkConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {


                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}'AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    float prodPrice = Convert.ToSingle(reader["price"]);

                                    casheirOder_ProductName.Text = prodName;
                                    casheirOder_price.Text = prodPrice.ToString("0.00");

                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private float totalPrice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {


                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @cID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);
                            casheirOder_totalPrice.Text = totalPrice.ToString("0.00");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void casheirOder_aaddBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (casheirOder_Category.SelectedIndex == -1 || casheirOder_ProductID.SelectedIndex == -1 || casheirOder_ProductName.Text == ""
                || casheirOder_price.Text == "" || casheirOder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {


                        float getPrice = 0;
                        string selectOder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOder = new SqlCommand(selectOder, connect))
                        {
                            getOder.Parameters.AddWithValue("@prodID", casheirOder_ProductID.SelectedItem);

                            using (SqlDataReader reader = getOder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToInt32(rawValue);

                                    }
                                }
                            }
                        }

                        string insertData = "INSERT INTO orders (customer_id, prod_id,prod_name,category,qty,orig_price,total_price,order_DATE)" +
                            "VALUES(@cID, @prodID, @prodName, @cat,@qty,@origPrice,@totalPrice, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", casheirOder_ProductID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prodName", casheirOder_ProductName.Text.Trim());
                            cmd.Parameters.AddWithValue("@cat", casheirOder_Category.SelectedItem);
                            cmd.Parameters.AddWithValue("@qty", casheirOder_qty.Value);
                            cmd.Parameters.AddWithValue("@origPrice", getPrice);

                            float totalP = (getPrice * (int)casheirOder_qty.Value);

                            cmd.Parameters.AddWithValue("@totalPrice", totalP);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();


                        }


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                }
            }

            displayOrders();
            displayTotalPrice();
        }

        private int idGen;

        public void IDGenerator()
        {
            if (checkConnection())
            {
                string selectData = "SELECT MAX(customer_id) FROM customers";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);
                        idGen = temp == 0 ? 1 : temp + 1;
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
                connect.Close();
            }
        }

        private void casheirOder_removeBtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete  ID:" + prodID +
                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {


                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("id", prodID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Delete successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

            displayOrders();
            displayTotalPrice();
        }


        private int prodID = 0;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                prodID = (int)row.Cells[0].Value;

            }
        }

        public void ClearFields()
        {
            casheirOder_Category.SelectedIndex = -1;
            casheirOder_ProductID.SelectedIndex = -1;
            casheirOder_ProductName.Text = "";
            casheirOder_price.Text = "";
            casheirOder_qty.Value = 0;

        }

        private void casheirOder_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void casheirOder_payoder_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (casheirOder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Somthing went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Are you sure to pay your orders",
                    "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {


                            string insertData = "INSERT INTO customers (customer_id,total_price,amount,change,oder_date)" +
                                "VALUES(@cID,@totalPrice,@amount, @change, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cID", idGen);
                                cmd.Parameters.AddWithValue("@totalPrice", casheirOder_totalPrice.Text);
                                cmd.Parameters.AddWithValue("@amount", casheirOder_amount.Text);
                                cmd.Parameters.AddWithValue("@change", casheirOder_change.Text);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();



                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }



            displayTotalPrice();
            clearDataGrid();

            casheirOder_amount.Text = "";
            casheirOder_change.Text = "";

        }

        private void casheirOder_qty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void casheirOder_amount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void casheirOder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(casheirOder_amount.Text);
                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        casheirOder_amount.Text = "";
                        casheirOder_change.Text = "";

                    }
                    else
                    {
                        casheirOder_change.Text = getChange.ToString("0.00");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Somthing went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    casheirOder_amount.Text = "";
                    casheirOder_change.Text = "";
                }

            }
        }

        private int rowIndex = 0;

        private void casheirOder_recip_Click(object sender, EventArgs e)
        {

            if (casheirOder_amount.Text == "" || dataGridView2.Rows.Count < 0)
            {
                MessageBox.Show("Please order first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

                
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument1,
                    Width = 800,
                    Height = 600
                };

                previewDialog.ShowDialog();


            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 100;
            int headerMargin = 5;
            int tableMargin = 5;

            Font font = new Font("Tahoma", 12);
            Font bold = new Font("Tahoma", 12, FontStyle.Bold);
            Font headerFont = new Font("Tahoma", 16, FontStyle.Bold);
            Font lableFont = new Font("Tahoma", 14, FontStyle.Bold);


            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Toy Shop Management System";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (dataGridView2.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;

            y += tableMargin;

            string[] header = { "ID", "CID", "PID", "PName", "Category", "OriginalPrice", "QTY", "TotalPrice" };

            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);

            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < dataGridView2.Rows.Count)
            {
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                for (int q = 0; q < dataGridView2.Columns.Count; q++)
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

            int labelmargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------------------", lableFont).Width;

            y = e.MarginBounds.Bottom - labelmargin - lableFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \t$" + totalPrice + "\nAmount: \t$" + casheirOder_amount.Text.Trim()
                + "\n\t\t---------------\nChange: \t$" + casheirOder_change.Text.Trim(), lableFont, Brushes.Black, labelX, y);

            labelmargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();

            y = e.MarginBounds.Bottom - labelmargin - lableFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, lableFont, Brushes.Black,
                e.MarginBounds.Right - e.Graphics.MeasureString("------------------", lableFont).Width, y);


        }

        private void ChashierOder_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
