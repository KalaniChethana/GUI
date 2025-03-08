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
using System.Drawing.Imaging;

namespace ToyShop
{
    public partial class AddminAddProduct : UserControl
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public AddminAddProduct()
        {
            InitializeComponent();
            displayProductsData();
            displayAllProducts();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayProductsData();
            displayAllProducts();

        }
        public void displayAllProducts()
        {
            AddProductsData apData = new AddProductsData();
            List<AddProductsData> listData = apData.AllProductsData();
            dataGridView1.DataSource = listData;

        }

        public void displayProductsData()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                addProduct_Category.Items.Add(reader["category"].ToString());



                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
      
        public void clearFields()
        {
            addProduct_productID.Text = "";
            addProduct_productName.Text = "";
            addProduct_Category.SelectedIndex = -1;
            addProduct_price.Text = "";
            addProduct_quite.Text = "";
            addProduct_status.SelectedIndex = -1;

        }
       

        

     

       

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProduct_productID.Text = row.Cells[1].Value.ToString();
                addProduct_productName.Text = row.Cells[2].Value.ToString();
                addProduct_Category.Text = row.Cells[3].Value.ToString();
                addProduct_price.Text = row.Cells[4].Value.ToString();
                addProduct_quite.Text = row.Cells[5].Value.ToString();
                addProduct_status.Text = row.Cells[6].Value.ToString();




            }
        }

        private void addProducts_addBtn_Click_1(object sender, EventArgs e)
        {
            if (addProduct_productID.Text == "" ||
               addProduct_productName.Text == "" ||
               addProduct_Category.SelectedIndex == -1 ||
               addProduct_price.Text == "" ||
               addProduct_quite.Text == "" ||
               addProduct_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", addProduct_productID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addProduct_productID.Text.Trim() + " already exists",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products " +
                                    " (prod_id,prod_name,category, price,stock,status,date_insert)" +
                                    " VALUES(@prodID , @prodName , @cat, @price , @stock, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProduct_productID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProduct_productName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addProduct_Category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", addProduct_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", addProduct_quite.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", addProduct_status.SelectedItem);
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllProducts();

                                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    finally
                    {
                        connect.Close();
                    }
                }
            }
        

        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProduct_productID == null ||
               addProduct_productName == null ||
               addProduct_Category == null ||
               addProduct_price == null ||
               addProduct_quite == null ||
               addProduct_status == null)

            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update product ID:" + addProduct_productID.Text.Trim() +
                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, " +
                    "category = @cat, price = @price, stock = @stock, status = @status WHERE id = @id";


                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addProduct_productID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addProduct_productName.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addProduct_Category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", addProduct_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", addProduct_quite.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", addProduct_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);
                                DateTime today = DateTime.Today;
                                updateD.Parameters.AddWithValue("@date", today);




                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();

                                MessageBox.Show("Product update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        finally
                        {
                            connect.Close();
                        }
                    }
                }



            }
        }
        

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
            if (addProduct_productID == null ||
                addProduct_productName == null ||
                addProduct_Category == null ||
                addProduct_price == null ||
                addProduct_quite == null ||
                addProduct_status == null)

            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete product ID:" + addProduct_productID.Text.Trim() +
                    "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM products WHERE id = @id";


                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {

                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();

                                MessageBox.Show("Delete successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }

                    }
                }
            }
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
             clearFields();
        }

        private void AddminAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
