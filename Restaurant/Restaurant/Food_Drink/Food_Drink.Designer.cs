namespace Restaurant
{
    partial class Food_Drink
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.CB_salad = new System.Windows.Forms.CheckBox();
            this.CB_cake = new System.Windows.Forms.CheckBox();
            this.CB_drink = new System.Windows.Forms.CheckBox();
            this.CB_maindish = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GV_ViewDish = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ViewDish)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_all);
            this.groupBox1.Controls.Add(this.CB_salad);
            this.groupBox1.Controls.Add(this.CB_cake);
            this.groupBox1.Controls.Add(this.CB_drink);
            this.groupBox1.Controls.Add(this.CB_maindish);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 319);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(8, 243);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(119, 37);
            this.cb_all.TabIndex = 8;
            this.cb_all.Text = "All Dishs";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // CB_salad
            // 
            this.CB_salad.AutoSize = true;
            this.CB_salad.Location = new System.Drawing.Point(8, 190);
            this.CB_salad.Name = "CB_salad";
            this.CB_salad.Size = new System.Drawing.Size(97, 37);
            this.CB_salad.TabIndex = 6;
            this.CB_salad.Text = "Salads";
            this.CB_salad.UseVisualStyleBackColor = true;
            this.CB_salad.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // CB_cake
            // 
            this.CB_cake.AutoSize = true;
            this.CB_cake.Location = new System.Drawing.Point(8, 137);
            this.CB_cake.Name = "CB_cake";
            this.CB_cake.Size = new System.Drawing.Size(90, 37);
            this.CB_cake.TabIndex = 5;
            this.CB_cake.Text = "Cakes";
            this.CB_cake.UseVisualStyleBackColor = true;
            this.CB_cake.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // CB_drink
            // 
            this.CB_drink.AutoSize = true;
            this.CB_drink.Location = new System.Drawing.Point(6, 84);
            this.CB_drink.Name = "CB_drink";
            this.CB_drink.Size = new System.Drawing.Size(100, 37);
            this.CB_drink.TabIndex = 4;
            this.CB_drink.Text = "Drinks";
            this.CB_drink.UseVisualStyleBackColor = true;
            this.CB_drink.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CB_maindish
            // 
            this.CB_maindish.AutoSize = true;
            this.CB_maindish.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_maindish.Location = new System.Drawing.Point(8, 31);
            this.CB_maindish.Name = "CB_maindish";
            this.CB_maindish.Size = new System.Drawing.Size(152, 37);
            this.CB_maindish.TabIndex = 3;
            this.CB_maindish.Text = "Main Dishes";
            this.CB_maindish.UseVisualStyleBackColor = true;
            this.CB_maindish.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(881, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1192, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "-----------------------------------------------------------------";
            // 
            // GV_ViewDish
            // 
            this.GV_ViewDish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GV_ViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GV_ViewDish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GV_ViewDish.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GV_ViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_ViewDish.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GV_ViewDish.Location = new System.Drawing.Point(293, 96);
            this.GV_ViewDish.Name = "GV_ViewDish";
            this.GV_ViewDish.RowHeadersWidth = 51;
            this.GV_ViewDish.RowTemplate.Height = 24;
            this.GV_ViewDish.Size = new System.Drawing.Size(1271, 663);
            this.GV_ViewDish.TabIndex = 5;
            this.GV_ViewDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_ViewDish_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 280);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "New Dish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(287, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1283, 690);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // Food_Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 782);
            this.Controls.Add(this.GV_ViewDish);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Food_Drink";
            this.Text = "Food_Drink";
            this.Load += new System.EventHandler(this.Food_Drink_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_ViewDish)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_maindish;
        private System.Windows.Forms.CheckBox CB_salad;
        private System.Windows.Forms.CheckBox CB_cake;
        private System.Windows.Forms.CheckBox CB_drink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GV_ViewDish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}