using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food_Drink f = new Food_Drink();
            f.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeManager emp = new EmployeeManager();
            emp.Visible = true;
            emp.Location = new Point(10, 10);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders.Orders order = new Orders.Orders();
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer.CustomerManagemenr customer = new Customer.CustomerManagemenr();
            customer.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Financial.FinancialReporting finan = new Financial.FinancialReporting();
            finan.Show();
        }
    }
}
