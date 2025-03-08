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
    public partial class ChashierMainForm : Form
    {
       
        public ChashierMainForm()
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

        private void aminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void cashierCustomerForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashbord_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = true;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = false;
            chashierOder1.Visible = false;

            AminDashboard adForm = aminDashboard1 as AminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = false;
            addminAddProduct1.Visible = true;
            cashierCustomerForm1.Visible = false;
            chashierOder1.Visible = false;

            AddminAddProduct apForm = addminAddProduct1 as AddminAddProduct;
            if (apForm != null)
            {
                apForm.refreshData();
            }

        }

        private void coustomers_btn_Click(object sender, EventArgs e)
        {
            aminDashboard1.Visible = false;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = true;
            chashierOder1.Visible = false;


            CashierCustomerForm aCcForm = cashierCustomerForm1 as CashierCustomerForm;
            if (aCcForm != null)
            {
                aCcForm.refreshData();
            }
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {

            aminDashboard1.Visible = false;
            addminAddProduct1.Visible = false;
            cashierCustomerForm1.Visible = false;
            chashierOder1.Visible = true;

            ChashierOder aocForm = chashierOder1 as ChashierOder;
            if (aocForm != null)
            {
                aocForm.refreshData();
            }
        }
    }
}
