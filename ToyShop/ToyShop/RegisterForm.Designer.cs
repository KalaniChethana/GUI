namespace ToyShop
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.close_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reg_login = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_but
            // 
            this.close_but.BackColor = System.Drawing.Color.SteelBlue;
            this.close_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_but.Location = new System.Drawing.Point(650, 9);
            this.close_but.Margin = new System.Windows.Forms.Padding(0);
            this.close_but.Name = "close_but";
            this.close_but.Size = new System.Drawing.Size(41, 39);
            this.close_but.TabIndex = 15;
            this.close_but.Text = "X";
            this.close_but.UseVisualStyleBackColor = false;
            this.close_but.Click += new System.EventHandler(this.close_but_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.register_showPass);
            this.panel1.Controls.Add(this.reg_login);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.register_cPassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.register_username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.register_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(69, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 465);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // reg_login
            // 
            this.reg_login.AutoSize = true;
            this.reg_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.reg_login.Location = new System.Drawing.Point(335, 413);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(98, 20);
            this.reg_login.TabIndex = 15;
            this.reg_login.Text = "Sing in here";
            this.reg_login.Click += new System.EventHandler(this.reg_login_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(126, 291);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // register_cPassword
            // 
            this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(197, 287);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(276, 30);
            this.register_cPassword.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(126, 237);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(197, 176);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(276, 30);
            this.register_username.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Already have account?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.login.Location = new System.Drawing.Point(126, 355);
            this.login.Margin = new System.Windows.Forms.Padding(0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(339, 58);
            this.login.TabIndex = 7;
            this.login.Text = "Signup";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(197, 233);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(276, 30);
            this.register_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Location = new System.Drawing.Point(126, 323);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(125, 20);
            this.register_showPass.TabIndex = 16;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.Reg_CheckPassword_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.close_but);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label reg_login;
        private System.Windows.Forms.CheckBox register_showPass;
    }
}