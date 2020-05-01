namespace Restaurant.Financial
{
    partial class FinancialReporting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OutCome = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Interestlb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OutComeInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "-----=====     Financial Report     =====-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(156, 124);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(252, 22);
            this.From.TabIndex = 3;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(657, 124);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(252, 22);
            this.To.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutComeInput);
            this.groupBox1.Controls.Add(this.Interestlb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.OutCome);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Income);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1137, 339);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Income";
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Location = new System.Drawing.Point(228, 69);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(26, 29);
            this.Income.TabIndex = 1;
            this.Income.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Salary";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(228, 133);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(26, 29);
            this.Salary.TabIndex = 3;
            this.Salary.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "OutCome";
            // 
            // OutCome
            // 
            this.OutCome.AutoSize = true;
            this.OutCome.Location = new System.Drawing.Point(228, 204);
            this.OutCome.Name = "OutCome";
            this.OutCome.Size = new System.Drawing.Size(26, 29);
            this.OutCome.TabIndex = 7;
            this.OutCome.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Interest";
            // 
            // Interestlb
            // 
            this.Interestlb.AutoSize = true;
            this.Interestlb.Location = new System.Drawing.Point(228, 267);
            this.Interestlb.Name = "Interestlb";
            this.Interestlb.Size = new System.Drawing.Size(26, 29);
            this.Interestlb.TabIndex = 9;
            this.Interestlb.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1017, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1017, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add OutCome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutComeInput
            // 
            this.OutComeInput.Location = new System.Drawing.Point(800, 29);
            this.OutComeInput.Name = "OutComeInput";
            this.OutComeInput.Size = new System.Drawing.Size(172, 35);
            this.OutComeInput.TabIndex = 11;
            // 
            // FinancialReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinancialReporting";
            this.Text = "FinancialReporting";
            this.Load += new System.EventHandler(this.FinancialReporting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Interestlb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label OutCome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutComeInput;
        private System.Windows.Forms.Button button2;
    }
}