namespace Restaurant.Orders
{
    partial class NewOrder
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
            this.DCustomer = new System.Windows.Forms.ComboBox();
            this.dishType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_OrderDetail = new System.Windows.Forms.RichTextBox();
            this.rtbOrder_table = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Order_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListDish = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DCustomer
            // 
            this.DCustomer.FormattingEnabled = true;
            this.DCustomer.Location = new System.Drawing.Point(164, 51);
            this.DCustomer.Name = "DCustomer";
            this.DCustomer.Size = new System.Drawing.Size(328, 39);
            this.DCustomer.TabIndex = 0;
            // 
            // dishType
            // 
            this.dishType.FormattingEnabled = true;
            this.dishType.Location = new System.Drawing.Point(164, 121);
            this.dishType.Name = "dishType";
            this.dishType.Size = new System.Drawing.Size(245, 39);
            this.dishType.TabIndex = 1;
            this.dishType.SelectedIndexChanged += new System.EventHandler(this.dishType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dish Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.numTable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtb_OrderDetail);
            this.groupBox1.Controls.Add(this.rtbOrder_table);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Order_panel);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ListDish);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dishType);
            this.groupBox1.Controls.Add(this.DCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1441, 761);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // numTable
            // 
            this.numTable.Location = new System.Drawing.Point(809, 54);
            this.numTable.Name = "numTable";
            this.numTable.Size = new System.Drawing.Size(196, 39);
            this.numTable.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Table Number ";
            // 
            // rtb_OrderDetail
            // 
            this.rtb_OrderDetail.Location = new System.Drawing.Point(1028, 505);
            this.rtb_OrderDetail.Name = "rtb_OrderDetail";
            this.rtb_OrderDetail.Size = new System.Drawing.Size(382, 239);
            this.rtb_OrderDetail.TabIndex = 13;
            this.rtb_OrderDetail.Text = "Description Order Detail";
            // 
            // rtbOrder_table
            // 
            this.rtbOrder_table.Location = new System.Drawing.Point(1028, 213);
            this.rtbOrder_table.Name = "rtbOrder_table";
            this.rtbOrder_table.Size = new System.Drawing.Size(382, 240);
            this.rtbOrder_table.TabIndex = 12;
            this.rtbOrder_table.Text = "Description Order Table";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 541);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "Refesh Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Order_panel
            // 
            this.Order_panel.BackColor = System.Drawing.Color.PapayaWhip;
            this.Order_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Order_panel.Location = new System.Drawing.Point(649, 213);
            this.Order_panel.Name = "Order_panel";
            this.Order_panel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Order_panel.Size = new System.Drawing.Size(336, 531);
            this.Order_panel.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1268, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 106);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListDish
            // 
            this.ListDish.BackColor = System.Drawing.Color.PapayaWhip;
            this.ListDish.FormattingEnabled = true;
            this.ListDish.ItemHeight = 31;
            this.ListDish.Location = new System.Drawing.Point(18, 213);
            this.ListDish.Name = "ListDish";
            this.ListDish.Size = new System.Drawing.Size(388, 531);
            this.ListDish.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(613, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "-----=====     Order     =====-----";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1477, 872);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DCustomer;
        private System.Windows.Forms.ComboBox dishType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListDish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel Order_panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtb_OrderDetail;
        private System.Windows.Forms.RichTextBox rtbOrder_table;
        private System.Windows.Forms.TextBox numTable;
        private System.Windows.Forms.Label label4;
    }
}