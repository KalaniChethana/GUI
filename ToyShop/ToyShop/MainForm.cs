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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }
        private void close_but_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }



       

        private void dashbord_btn_Click(object sender, EventArgs e)
        {

            aminDashboard1.Visible = true;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AminDashboard adForm = aminDashboard1 as AminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = false;
            adminAddUser1.Visible = true;
            adminAddCategories1.Visible = false;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddUser auForm = adminAddUser1 as AdminAddUser;

            if (auForm != null)
            {
                auForm.refreshData();
            }
        }

        private void addcatagories_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = true;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddCategories acForm = adminAddCategories1 as AdminAddCategories;

            if (acForm != null)
            {
                acForm.refreshData();
            }


        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProduct1.Visible = true;
            cashierCustomerForm1.Visible = false;

            AddminAddProduct apForm = addminAddProduct1 as AddminAddProduct;
            if (apForm != null)
            {
                apForm.refreshData();
            }

        }

        private void coustomers_btn_Click(object sender, EventArgs e)
        {

            aminDashboard1.Visible = false;
            adminAddUser1.Visible = false;
            adminAddCategories1.Visible = false;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = true;

            CashierCustomerForm aCForm = cashierCustomerForm1 as CashierCustomerForm;
            if (aCForm != null)
            {
                aCForm.refreshData();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aminDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
