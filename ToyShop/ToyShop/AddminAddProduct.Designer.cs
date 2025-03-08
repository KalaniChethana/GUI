namespace ToyShop
{
    partial class AddminAddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProduct_Category = new System.Windows.Forms.ComboBox();
            this.addProducts_clearBtn = new System.Windows.Forms.Button();
            this.addProducts_removeBtn = new System.Windows.Forms.Button();
            this.addProducts_updateBtn = new System.Windows.Forms.Button();
            this.addProducts_addBtn = new System.Windows.Forms.Button();
            this.addProduct_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProduct_quite = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProduct_price = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProduct_productName = new System.Windows.Forms.MaskedTextBox();
            this.addProduct_productID = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 379);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 263);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "All Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addProduct_Category);
            this.panel2.Controls.Add(this.addProducts_clearBtn);
            this.panel2.Controls.Add(this.addProducts_removeBtn);
            this.panel2.Controls.Add(this.addProducts_updateBtn);
            this.panel2.Controls.Add(this.addProducts_addBtn);
            this.panel2.Controls.Add(this.addProduct_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addProduct_quite);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProduct_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProduct_productName);
            this.panel2.Controls.Add(this.addProduct_productID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 298);
            this.panel2.TabIndex = 1;
            // 
            // addProduct_Category
            // 
            this.addProduct_Category.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_Category.FormattingEnabled = true;
            this.addProduct_Category.Location = new System.Drawing.Point(201, 140);
            this.addProduct_Category.Name = "addProduct_Category";
            this.addProduct_Category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addProduct_Category.Size = new System.Drawing.Size(232, 28);
            this.addProduct_Category.TabIndex = 20;
            // 
            // addProducts_clearBtn
            // 
            this.addProducts_clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProducts_clearBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_clearBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addProducts_clearBtn.Location = new System.Drawing.Point(842, 216);
            this.addProducts_clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addProducts_clearBtn.Name = "addProducts_clearBtn";
            this.addProducts_clearBtn.Size = new System.Drawing.Size(123, 44);
            this.addProducts_clearBtn.TabIndex = 19;
            this.addProducts_clearBtn.Text = "Clear";
            this.addProducts_clearBtn.UseVisualStyleBackColor = false;
            this.addProducts_clearBtn.Click += new System.EventHandler(this.addProducts_clearBtn_Click);
            // 
            // addProducts_removeBtn
            // 
            this.addProducts_removeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProducts_removeBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addProducts_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_removeBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addProducts_removeBtn.Location = new System.Drawing.Point(612, 216);
            this.addProducts_removeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addProducts_removeBtn.Name = "addProducts_removeBtn";
            this.addProducts_removeBtn.Size = new System.Drawing.Size(123, 44);
            this.addProducts_removeBtn.TabIndex = 18;
            this.addProducts_removeBtn.Text = "Remove";
            this.addProducts_removeBtn.UseVisualStyleBackColor = false;
            this.addProducts_removeBtn.Click += new System.EventHandler(this.addProducts_removeBtn_Click);
            // 
            // addProducts_updateBtn
            // 
            this.addProducts_updateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProducts_updateBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_updateBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addProducts_updateBtn.Location = new System.Drawing.Point(371, 216);
            this.addProducts_updateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addProducts_updateBtn.Name = "addProducts_updateBtn";
            this.addProducts_updateBtn.Size = new System.Drawing.Size(123, 44);
            this.addProducts_updateBtn.TabIndex = 17;
            this.addProducts_updateBtn.Text = "Update";
            this.addProducts_updateBtn.UseVisualStyleBackColor = false;
            this.addProducts_updateBtn.Click += new System.EventHandler(this.addProducts_updateBtn_Click);
            // 
            // addProducts_addBtn
            // 
            this.addProducts_addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addProducts_addBtn.FlatAppearance.BorderSize = 0;
            this.addProducts_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_addBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addProducts_addBtn.Location = new System.Drawing.Point(114, 216);
            this.addProducts_addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addProducts_addBtn.Name = "addProducts_addBtn";
            this.addProducts_addBtn.Size = new System.Drawing.Size(123, 44);
            this.addProducts_addBtn.TabIndex = 16;
            this.addProducts_addBtn.Text = "Add";
            this.addProducts_addBtn.UseVisualStyleBackColor = false;
            this.addProducts_addBtn.Click += new System.EventHandler(this.addProducts_addBtn_Click_1);
            // 
            // addProduct_status
            // 
            this.addProduct_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_status.FormattingEnabled = true;
            this.addProduct_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.addProduct_status.Location = new System.Drawing.Point(673, 140);
            this.addProduct_status.Name = "addProduct_status";
            this.addProduct_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addProduct_status.Size = new System.Drawing.Size(232, 28);
            this.addProduct_status.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // addProduct_quite
            // 
            this.addProduct_quite.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_quite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_quite.Location = new System.Drawing.Point(673, 100);
            this.addProduct_quite.Name = "addProduct_quite";
            this.addProduct_quite.Size = new System.Drawing.Size(232, 27);
            this.addProduct_quite.TabIndex = 13;
            this.addProduct_quite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock";
            // 
            // addProduct_price
            // 
            this.addProduct_price.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_price.Location = new System.Drawing.Point(673, 52);
            this.addProduct_price.Name = "addProduct_price";
            this.addProduct_price.Size = new System.Drawing.Size(232, 27);
            this.addProduct_price.TabIndex = 11;
            this.addProduct_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // addProduct_productName
            // 
            this.addProduct_productName.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_productName.Location = new System.Drawing.Point(201, 100);
            this.addProduct_productName.Name = "addProduct_productName";
            this.addProduct_productName.Size = new System.Drawing.Size(232, 27);
            this.addProduct_productName.TabIndex = 8;
            this.addProduct_productName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addProduct_productID
            // 
            this.addProduct_productID.Cursor = System.Windows.Forms.Cursors.Default;
            this.addProduct_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_productID.Location = new System.Drawing.Point(201, 54);
            this.addProduct_productID.Name = "addProduct_productID";
            this.addProduct_productID.Size = new System.Drawing.Size(232, 27);
            this.addProduct_productID.TabIndex = 7;
            this.addProduct_productID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product ID";
            // 
            // AddminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddminAddProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1107, 747);
            this.Load += new System.EventHandler(this.AddminAddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox addProduct_productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox addProduct_productName;
        private System.Windows.Forms.ComboBox addProduct_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox addProduct_quite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox addProduct_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProducts_clearBtn;
        private System.Windows.Forms.Button addProducts_removeBtn;
        private System.Windows.Forms.Button addProducts_updateBtn;
        private System.Windows.Forms.Button addProducts_addBtn;
        private System.Windows.Forms.ComboBox addProduct_Category;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
