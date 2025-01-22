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

namespace ToyShopManagmentSystem
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GUI\ToyShopManagmentSystem\ToyShopManagmentSystem\toyshop.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddCategories()
        {
            InitializeComponent();
        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkCat = "SELECT * FROM categories WHERE category = @cat";

                        using (SqlCommand cmd = new SqlCommand(checkCat,connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category:" + addCategories_category.Text.Trim()+"is alrady exist"
                                    , "Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category,date) VALUES(@cat,@date)";

                                using(SqlCommand insertD = new SqlCommand(insertData,connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    DateTime today = DateTime.Now;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Added successfuly", 
                                        "Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);


                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection faild" + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
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
    }
}
