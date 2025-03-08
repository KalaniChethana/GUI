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

namespace ToyShop
{
    public partial class RegisterForm : Form
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\Documents\ToyShop.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

       

        private void close_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() +
                                    " is alrady taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Passowrd, at lest 8 characters are needed"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, role, status, date) " +
                           "VALUES(@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Registered succsesfully!"
                                  , "Information  Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();

                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex.Message
                                   , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Reg_CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
      
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
