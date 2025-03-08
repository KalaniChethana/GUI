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
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;


namespace ToyShop
{
    public partial class AminDashboard : UserControl
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public AminDashboard()
        {
            InitializeComponent();

            displayTodayCustomers();

            displayAllUsers();

            displayAllCustomers();

            displayTodayIncome();

            displayallIncome();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsers();

            displayAllCustomers();

            displayTodayIncome();

            displayallIncome();
        }
        public void displayTodayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allTodayCustomers();

            dataGridView1.DataSource = listData;
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
        public void displayAllUsers()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users WHERE status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Active");

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashbord_All.Text = count.ToString();
                    }
                    reader.Close();
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

        public void displayAllCustomers()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashbord_AC.Text = count.ToString();
                    }
                    reader.Close();
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

        public void displayTodayIncome()
        {

            try
            {
                connect.Open();

                string selectData = "SELECT SUM(total_price) FROM customers WHERE oder_date = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Today;
                    string getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", today);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        object value = reader[0];

                        if (value != DBNull.Value)
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashbord_todayincome.Text = count.ToString("0.00");
                        }
                        reader.Close();

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

        public void displayallIncome()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT SUM(total_price) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashbord_TI.Text = count.ToString("0.00");


                    }
                    reader.Close();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
