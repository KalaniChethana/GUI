namespace ToyShop
{
    partial class ChashierOder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChashierOder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.casheirOder_Category = new System.Windows.Forms.ComboBox();
            this.casheirOder_clearBtn = new System.Windows.Forms.Button();
            this.casheirOder_removeBtn = new System.Windows.Forms.Button();
            this.casheirOder_aaddBtn = new System.Windows.Forms.Button();
            this.casheirOder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.casheirOder_ProductName = new System.Windows.Forms.Label();
            this.casheirOder_price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.casheirOder_ProductID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.casheirOder_recip = new System.Windows.Forms.Button();
            this.casheirOder_payoder = new System.Windows.Forms.Button();
            this.casheirOder_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.casheirOder_amount = new System.Windows.Forms.MaskedTextBox();
            this.casheirOder_totalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casheirOder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 329);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 263);
            this.dataGridView1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Available Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.casheirOder_Category);
            this.panel2.Controls.Add(this.casheirOder_clearBtn);
            this.panel2.Controls.Add(this.casheirOder_removeBtn);
            this.panel2.Controls.Add(this.casheirOder_aaddBtn);
            this.panel2.Controls.Add(this.casheirOder_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.casheirOder_ProductName);
            this.panel2.Controls.Add(this.casheirOder_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.casheirOder_ProductID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 329);
            this.panel2.TabIndex = 1;
            // 
            // casheirOder_Category
            // 
            this.casheirOder_Category.Cursor = System.Windows.Forms.Cursors.Default;
            this.casheirOder_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_Category.FormattingEnabled = true;
            this.casheirOder_Category.Location = new System.Drawing.Point(116, 40);
            this.casheirOder_Category.Name = "casheirOder_Category";
            this.casheirOder_Category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.casheirOder_Category.Size = new System.Drawing.Size(169, 28);
            this.casheirOder_Category.TabIndex = 36;
            this.casheirOder_Category.SelectedIndexChanged += new System.EventHandler(this.casheirOder_Category_SelectedIndexChanged);
            // 
            // casheirOder_clearBtn
            // 
            this.casheirOder_clearBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.casheirOder_clearBtn.FlatAppearance.BorderSize = 0;
            this.casheirOder_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.casheirOder_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casheirOder_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_clearBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.casheirOder_clearBtn.Location = new System.Drawing.Point(495, 228);
            this.casheirOder_clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.casheirOder_clearBtn.Name = "casheirOder_clearBtn";
            this.casheirOder_clearBtn.Size = new System.Drawing.Size(123, 44);
            this.casheirOder_clearBtn.TabIndex = 35;
            this.casheirOder_clearBtn.Text = "Clear";
            this.casheirOder_clearBtn.UseVisualStyleBackColor = false;
            this.casheirOder_clearBtn.Click += new System.EventHandler(this.casheirOder_clearBtn_Click);
            // 
            // casheirOder_removeBtn
            // 
            this.casheirOder_removeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.casheirOder_removeBtn.FlatAppearance.BorderSize = 0;
            this.casheirOder_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.casheirOder_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casheirOder_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_removeBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.casheirOder_removeBtn.Location = new System.Drawing.Point(263, 228);
            this.casheirOder_removeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.casheirOder_removeBtn.Name = "casheirOder_removeBtn";
            this.casheirOder_removeBtn.Size = new System.Drawing.Size(123, 44);
            this.casheirOder_removeBtn.TabIndex = 34;
            this.casheirOder_removeBtn.Text = "Remove";
            this.casheirOder_removeBtn.UseVisualStyleBackColor = false;
            this.casheirOder_removeBtn.Click += new System.EventHandler(this.casheirOder_removeBtn_Click);
            // 
            // casheirOder_aaddBtn
            // 
            this.casheirOder_aaddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.casheirOder_aaddBtn.FlatAppearance.BorderSize = 0;
            this.casheirOder_aaddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.casheirOder_aaddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casheirOder_aaddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_aaddBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.casheirOder_aaddBtn.Location = new System.Drawing.Point(23, 228);
            this.casheirOder_aaddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.casheirOder_aaddBtn.Name = "casheirOder_aaddBtn";
            this.casheirOder_aaddBtn.Size = new System.Drawing.Size(123, 44);
            this.casheirOder_aaddBtn.TabIndex = 32;
            this.casheirOder_aaddBtn.Text = "Add";
            this.casheirOder_aaddBtn.UseVisualStyleBackColor = false;
            this.casheirOder_aaddBtn.Click += new System.EventHandler(this.casheirOder_aaddBtn_Click);
            // 
            // casheirOder_qty
            // 
            this.casheirOder_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_qty.Location = new System.Drawing.Point(415, 106);
            this.casheirOder_qty.Name = "casheirOder_qty";
            this.casheirOder_qty.Size = new System.Drawing.Size(169, 27);
            this.casheirOder_qty.TabIndex = 31;
            this.casheirOder_qty.ValueChanged += new System.EventHandler(this.casheirOder_qty_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Quantity:";
            // 
            // casheirOder_ProductName
            // 
            this.casheirOder_ProductName.AutoSize = true;
            this.casheirOder_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_ProductName.Location = new System.Drawing.Point(183, 103);
            this.casheirOder_ProductName.Name = "casheirOder_ProductName";
            this.casheirOder_ProductName.Size = new System.Drawing.Size(92, 25);
            this.casheirOder_ProductName.TabIndex = 29;
            this.casheirOder_ProductName.Text = "Category";
            // 
            // casheirOder_price
            // 
            this.casheirOder_price.AutoSize = true;
            this.casheirOder_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_price.Location = new System.Drawing.Point(90, 158);
            this.casheirOder_price.Name = "casheirOder_price";
            this.casheirOder_price.Size = new System.Drawing.Size(92, 25);
            this.casheirOder_price.TabIndex = 28;
            this.casheirOder_price.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Price:";
            // 
            // casheirOder_ProductID
            // 
            this.casheirOder_ProductID.Cursor = System.Windows.Forms.Cursors.Default;
            this.casheirOder_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_ProductID.FormattingEnabled = true;
            this.casheirOder_ProductID.Location = new System.Drawing.Point(415, 37);
            this.casheirOder_ProductID.Name = "casheirOder_ProductID";
            this.casheirOder_ProductID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.casheirOder_ProductID.Size = new System.Drawing.Size(169, 28);
            this.casheirOder_ProductID.TabIndex = 24;
            this.casheirOder_ProductID.SelectedIndexChanged += new System.EventHandler(this.casheirOder_ProductID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.casheirOder_recip);
            this.panel3.Controls.Add(this.casheirOder_payoder);
            this.panel3.Controls.Add(this.casheirOder_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.casheirOder_amount);
            this.panel3.Controls.Add(this.casheirOder_totalPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(688, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 675);
            this.panel3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 39;
            this.label14.Text = "All Orders";
            // 
            // casheirOder_recip
            // 
            this.casheirOder_recip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.casheirOder_recip.FlatAppearance.BorderSize = 0;
            this.casheirOder_recip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.casheirOder_recip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casheirOder_recip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_recip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.casheirOder_recip.Location = new System.Drawing.Point(25, 532);
            this.casheirOder_recip.Margin = new System.Windows.Forms.Padding(0);
            this.casheirOder_recip.Name = "casheirOder_recip";
            this.casheirOder_recip.Size = new System.Drawing.Size(353, 44);
            this.casheirOder_recip.TabIndex = 38;
            this.casheirOder_recip.Text = "Receipt";
            this.casheirOder_recip.UseVisualStyleBackColor = false;
            this.casheirOder_recip.Click += new System.EventHandler(this.casheirOder_recip_Click);
            // 
            // casheirOder_payoder
            // 
            this.casheirOder_payoder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.casheirOder_payoder.FlatAppearance.BorderSize = 0;
            this.casheirOder_payoder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.casheirOder_payoder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.casheirOder_payoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_payoder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.casheirOder_payoder.Location = new System.Drawing.Point(25, 607);
            this.casheirOder_payoder.Margin = new System.Windows.Forms.Padding(0);
            this.casheirOder_payoder.Name = "casheirOder_payoder";
            this.casheirOder_payoder.Size = new System.Drawing.Size(353, 44);
            this.casheirOder_payoder.TabIndex = 37;
            this.casheirOder_payoder.Text = "Pay Orders";
            this.casheirOder_payoder.UseVisualStyleBackColor = false;
            this.casheirOder_payoder.Click += new System.EventHandler(this.casheirOder_payoder_Click);
            // 
            // casheirOder_change
            // 
            this.casheirOder_change.AutoSize = true;
            this.casheirOder_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_change.Location = new System.Drawing.Point(201, 450);
            this.casheirOder_change.Name = "casheirOder_change";
            this.casheirOder_change.Size = new System.Drawing.Size(50, 25);
            this.casheirOder_change.TabIndex = 36;
            this.casheirOder_change.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Change:";
            // 
            // casheirOder_amount
            // 
            this.casheirOder_amount.Cursor = System.Windows.Forms.Cursors.Default;
            this.casheirOder_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_amount.Location = new System.Drawing.Point(206, 399);
            this.casheirOder_amount.Name = "casheirOder_amount";
            this.casheirOder_amount.Size = new System.Drawing.Size(172, 27);
            this.casheirOder_amount.TabIndex = 34;
            this.casheirOder_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.casheirOder_amount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.casheirOder_amount_MaskInputRejected);
            this.casheirOder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.casheirOder_amount_KeyDown);
            // 
            // casheirOder_totalPrice
            // 
            this.casheirOder_totalPrice.AutoSize = true;
            this.casheirOder_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirOder_totalPrice.Location = new System.Drawing.Point(201, 346);
            this.casheirOder_totalPrice.Name = "casheirOder_totalPrice";
            this.casheirOder_totalPrice.Size = new System.Drawing.Size(50, 25);
            this.casheirOder_totalPrice.TabIndex = 33;
            this.casheirOder_totalPrice.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Total Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Amount:";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(353, 263);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ChashierOder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChashierOder";
            this.Size = new System.Drawing.Size(1107, 747);
            this.Load += new System.EventHandler(this.ChashierOder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casheirOder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label casheirOder_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox casheirOder_ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown casheirOder_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label casheirOder_ProductName;
        private System.Windows.Forms.Button casheirOder_clearBtn;
        private System.Windows.Forms.Button casheirOder_removeBtn;
        private System.Windows.Forms.Button casheirOder_aaddBtn;
        private System.Windows.Forms.Label casheirOder_totalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button casheirOder_recip;
        private System.Windows.Forms.Button casheirOder_payoder;
        private System.Windows.Forms.Label casheirOder_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox casheirOder_amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox casheirOder_Category;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
