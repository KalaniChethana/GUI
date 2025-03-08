using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyShop
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddCategories()
        {
            InitializeComponent();

            displayCategoriesData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoriesData();


        }

        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            dataGridView1.DataSource = listData;
        }



        
        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "")
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

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category:" + addUsers_username.Text.Trim() + "is alrady exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO categories(category,date)VALUES(@cat,@date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addUsers_username.Text.Trim());
                                    DateTime today = DateTime.Now;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayCategoriesData();

                                    MessageBox.Show("Added successfuly",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
        public void clearFields()
        {
            addUsers_username.Text = "";
        }



       

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }



        private void AdminAddCategories_Load(object sender, EventArgs e)
        {

        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
