namespace Restaurant.Employee
{
    partial class Emp_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Total_emp = new System.Windows.Forms.Label();
            this.Highest = new System.Windows.Forms.Label();
            this.Smallest = new System.Windows.Forms.Label();
            this.Total_salary = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.Total_salary);
            this.groupBox1.Controls.Add(this.Smallest);
            this.groupBox1.Controls.Add(this.Highest);
            this.groupBox1.Controls.Add(this.Total_emp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Highest Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Smallest Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Male";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Total_emp
            // 
            this.Total_emp.AutoSize = true;
            this.Total_emp.Location = new System.Drawing.Point(225, 34);
            this.Total_emp.Name = "Total_emp";
            this.Total_emp.Size = new System.Drawing.Size(64, 30);
            this.Total_emp.TabIndex = 5;
            this.Total_emp.Text = "label7";
            // 
            // Highest
            // 
            this.Highest.AutoSize = true;
            this.Highest.Location = new System.Drawing.Point(225, 86);
            this.Highest.Name = "Highest";
            this.Highest.Size = new System.Drawing.Size(64, 30);
            this.Highest.TabIndex = 6;
            this.Highest.Text = "label8";
            // 
            // Smallest
            // 
            this.Smallest.AutoSize = true;
            this.Smallest.Location = new System.Drawing.Point(225, 143);
            this.Smallest.Name = "Smallest";
            this.Smallest.Size = new System.Drawing.Size(64, 30);
            this.Smallest.TabIndex = 7;
            this.Smallest.Text = "label9";
            // 
            // Total_salary
            // 
            this.Total_salary.AutoSize = true;
            this.Total_salary.Location = new System.Drawing.Point(225, 202);
            this.Total_salary.Name = "Total_salary";
            this.Total_salary.Size = new System.Drawing.Size(76, 30);
            this.Total_salary.TabIndex = 8;
            this.Total_salary.Text = "label10";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(225, 262);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(76, 30);
            this.Male.TabIndex = 9;
            this.Male.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 38);
            this.label12.TabIndex = 10;
            this.label12.Text = "Female";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(225, 318);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(76, 30);
            this.Female.TabIndex = 11;
            this.Female.Text = "label13";
            // 
            // Emp_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Emp_Report";
            this.Text = "Emp_Report";
            this.Load += new System.EventHandler(this.Emp_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Female;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Male;
        private System.Windows.Forms.Label Total_salary;
        private System.Windows.Forms.Label Smallest;
        private System.Windows.Forms.Label Highest;
        private System.Windows.Forms.Label Total_emp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}