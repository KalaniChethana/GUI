namespace ToyShop
{
    partial class AdminAddCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCategories_clearBtn = new System.Windows.Forms.Button();
            this.addCategories_removeBtn = new System.Windows.Forms.Button();
            this.addCategories_updateBtn = new System.Windows.Forms.Button();
            this.addCategories_addBtn = new System.Windows.Forms.Button();
            this.addUsers_username = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(393, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 693);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(621, 593);
            this.dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "All Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addCategories_clearBtn);
            this.panel1.Controls.Add(this.addCategories_removeBtn);
            this.panel1.Controls.Add(this.addCategories_updateBtn);
            this.panel1.Controls.Add(this.addCategories_addBtn);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 693);
            this.panel1.TabIndex = 14;
            // 
            // addCategories_clearBtn
            // 
            this.addCategories_clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCategories_clearBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCategories_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_clearBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCategories_clearBtn.Location = new System.Drawing.Point(175, 243);
            this.addCategories_clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addCategories_clearBtn.Name = "addCategories_clearBtn";
            this.addCategories_clearBtn.Size = new System.Drawing.Size(123, 44);
            this.addCategories_clearBtn.TabIndex = 12;
            this.addCategories_clearBtn.Text = "Clear";
            this.addCategories_clearBtn.UseVisualStyleBackColor = false;
            // 
            // addCategories_removeBtn
            // 
            this.addCategories_removeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCategories_removeBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCategories_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_removeBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCategories_removeBtn.Location = new System.Drawing.Point(22, 243);
            this.addCategories_removeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addCategories_removeBtn.Name = "addCategories_removeBtn";
            this.addCategories_removeBtn.Size = new System.Drawing.Size(123, 44);
            this.addCategories_removeBtn.TabIndex = 11;
            this.addCategories_removeBtn.Text = "Remove";
            this.addCategories_removeBtn.UseVisualStyleBackColor = false;
            // 
            // addCategories_updateBtn
            // 
            this.addCategories_updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCategories_updateBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCategories_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_updateBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCategories_updateBtn.Location = new System.Drawing.Point(175, 132);
            this.addCategories_updateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addCategories_updateBtn.Name = "addCategories_updateBtn";
            this.addCategories_updateBtn.Size = new System.Drawing.Size(123, 44);
            this.addCategories_updateBtn.TabIndex = 10;
            this.addCategories_updateBtn.Text = "Update";
            this.addCategories_updateBtn.UseVisualStyleBackColor = false;
            // 
            // addCategories_addBtn
            // 
            this.addCategories_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCategories_addBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addCategories_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_addBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addCategories_addBtn.Location = new System.Drawing.Point(22, 132);
            this.addCategories_addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addCategories_addBtn.Name = "addCategories_addBtn";
            this.addCategories_addBtn.Size = new System.Drawing.Size(123, 44);
            this.addCategories_addBtn.TabIndex = 9;
            this.addCategories_addBtn.Text = "Add";
            this.addCategories_addBtn.UseVisualStyleBackColor = false;
            this.addCategories_addBtn.Click += new System.EventHandler(this.addCategories_addBtn_Click);
            // 
            // addUsers_username
            // 
            this.addUsers_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_username.Location = new System.Drawing.Point(22, 52);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(276, 30);
            this.addUsers_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1107, 747);
            this.Load += new System.EventHandler(this.AdminAddCategories_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCategories_clearBtn;
        private System.Windows.Forms.Button addCategories_removeBtn;
        private System.Windows.Forms.Button addCategories_updateBtn;
        private System.Windows.Forms.Button addCategories_addBtn;
        private System.Windows.Forms.MaskedTextBox addUsers_username;
        private System.Windows.Forms.Label label1;
    }
}
