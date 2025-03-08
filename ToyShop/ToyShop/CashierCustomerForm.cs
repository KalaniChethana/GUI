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
    public partial class CashierCustomerForm : UserControl
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierCustomerForm()
        {
            InitializeComponent();

            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCustomers();


        }
        public void displayCustomers()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomers();

            dataGridView1.DataSource = listData;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
