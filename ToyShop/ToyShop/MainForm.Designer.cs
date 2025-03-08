namespace ToyShop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coustomers_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addcatagories_btn = new System.Windows.Forms.Button();
            this.adduser_btn = new System.Windows.Forms.Button();
            this.addproduct_btn = new System.Windows.Forms.Button();
            this.dashbord_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aminDashboard1 = new ToyShop.AminDashboard();
            this.adminAddUser1 = new ToyShop.AdminAddUser();
            this.adminAddCategories1 = new ToyShop.AdminAddCategories();
            this.addminAddProduct1 = new ToyShop.AddminAddProduct();
            this.cashierCustomerForm1 = new ToyShop.CashierCustomerForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.close_but);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close_but
            // 
            this.close_but.BackColor = System.Drawing.Color.SteelBlue;
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_but.Location = new System.Drawing.Point(1305, 9);
            this.close_but.Margin = new System.Windows.Forms.Padding(0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(41, 39);
            this.close_but.TabIndex = 15;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = false;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Toy shop Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.coustomers_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.addcatagories_btn);
            this.panel2.Controls.Add(this.adduser_btn);
            this.panel2.Controls.Add(this.addproduct_btn);
            this.panel2.Controls.Add(this.dashbord_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 747);
            this.panel2.TabIndex = 16;
            // 
            // coustomers_btn
            // 
            this.coustomers_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.coustomers_btn.FlatAppearance.BorderSize = 0;
            this.coustomers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.coustomers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coustomers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coustomers_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.coustomers_btn.Location = new System.Drawing.Point(21, 452);
            this.coustomers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.coustomers_btn.Name = "coustomers_btn";
            this.coustomers_btn.Size = new System.Drawing.Size(207, 41);
            this.coustomers_btn.TabIndex = 23;
            this.coustomers_btn.Text = "Customers";
            this.coustomers_btn.UseVisualStyleBackColor = false;
            this.coustomers_btn.Click += new System.EventHandler(this.coustomers_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logout_btn.Location = new System.Drawing.Point(21, 646);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(207, 41);
            this.logout_btn.TabIndex = 22;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addcatagories_btn
            // 
            this.addcatagories_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addcatagories_btn.FlatAppearance.BorderSize = 0;
            this.addcatagories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addcatagories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcatagories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcatagories_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addcatagories_btn.Location = new System.Drawing.Point(17, 319);
            this.addcatagories_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addcatagories_btn.Name = "addcatagories_btn";
            this.addcatagories_btn.Size = new System.Drawing.Size(211, 41);
            this.addcatagories_btn.TabIndex = 21;
            this.addcatagories_btn.Text = "Add Categories";
            this.addcatagories_btn.UseVisualStyleBackColor = false;
            this.addcatagories_btn.Click += new System.EventHandler(this.addcatagories_btn_Click);
            // 
            // adduser_btn
            // 
            this.adduser_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adduser_btn.FlatAppearance.BorderSize = 0;
            this.adduser_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adduser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adduser_btn.Location = new System.Drawing.Point(17, 254);
            this.adduser_btn.Margin = new System.Windows.Forms.Padding(0);
            this.adduser_btn.Name = "adduser_btn";
            this.adduser_btn.Size = new System.Drawing.Size(211, 41);
            this.adduser_btn.TabIndex = 20;
            this.adduser_btn.Text = "Add Users";
            this.adduser_btn.UseVisualStyleBackColor = false;
            this.adduser_btn.Click += new System.EventHandler(this.adduser_btn_Click);
            // 
            // addproduct_btn
            // 
            this.addproduct_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addproduct_btn.FlatAppearance.BorderSize = 0;
            this.addproduct_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addproduct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproduct_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addproduct_btn.Location = new System.Drawing.Point(17, 384);
            this.addproduct_btn.Margin = new System.Windows.Forms.Padding(0);
            this.addproduct_btn.Name = "addproduct_btn";
            this.addproduct_btn.Size = new System.Drawing.Size(211, 41);
            this.addproduct_btn.TabIndex = 19;
            this.addproduct_btn.Text = "Add Products";
            this.addproduct_btn.UseVisualStyleBackColor = false;
            this.addproduct_btn.Click += new System.EventHandler(this.addproduct_btn_Click);
            // 
            // dashbord_btn
            // 
            this.dashbord_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashbord_btn.FlatAppearance.BorderSize = 0;
            this.dashbord_btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dashbord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbord_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbord_btn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dashbord_btn.Location = new System.Drawing.Point(17, 194);
            this.dashbord_btn.Margin = new System.Windows.Forms.Padding(0);
            this.dashbord_btn.Name = "dashbord_btn";
            this.dashbord_btn.Size = new System.Drawing.Size(211, 41);
            this.dashbord_btn.TabIndex = 17;
            this.dashbord_btn.Text = "Dashbord";
            this.dashbord_btn.UseVisualStyleBackColor = false;
            this.dashbord_btn.Click += new System.EventHandler(this.dashbord_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Welcome,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.aminDashboard1);
            this.panel3.Controls.Add(this.adminAddUser1);
            this.panel3.Controls.Add(this.adminAddCategories1);
            this.panel3.Controls.Add(this.addminAddProduct1);
            this.panel3.Controls.Add(this.cashierCustomerForm1);
            this.panel3.Location = new System.Drawing.Point(248, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 747);
            this.panel3.TabIndex = 17;
            // 
            // aminDashboard1
            // 
            this.aminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.aminDashboard1.Name = "aminDashboard1";
            this.aminDashboard1.Size = new System.Drawing.Size(1107, 747);
            this.aminDashboard1.TabIndex = 4;
            this.aminDashboard1.Load += new System.EventHandler(this.aminDashboard1_Load);
            // 
            // adminAddUser1
            // 
            this.adminAddUser1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUser1.Name = "adminAddUser1";
            this.adminAddUser1.Size = new System.Drawing.Size(1107, 747);
            this.adminAddUser1.TabIndex = 3;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1107, 747);
            this.adminAddCategories1.TabIndex = 2;
            // 
            // addminAddProduct1
            // 
            this.addminAddProduct1.Location = new System.Drawing.Point(0, 0);
            this.addminAddProduct1.Name = "addminAddProduct1";
            this.addminAddProduct1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addminAddProduct1.Size = new System.Drawing.Size(1107, 747);
            this.addminAddProduct1.TabIndex = 1;
            // 
            // cashierCustomerForm1
            // 
            this.cashierCustomerForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomerForm1.Name = "cashierCustomerForm1";
            this.cashierCustomerForm1.Size = new System.Drawing.Size(1107, 747);
            this.cashierCustomerForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 801);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashbord_btn;
        private System.Windows.Forms.Button adduser_btn;
        private System.Windows.Forms.Button addproduct_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button addcatagories_btn;
        private System.Windows.Forms.Button coustomers_btn;
        private System.Windows.Forms.Panel panel3;
        private AminDashboard aminDashboard1;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private AddminAddProduct addminAddProduct1;
        private CashierCustomerForm cashierCustomerForm1;
    }
}