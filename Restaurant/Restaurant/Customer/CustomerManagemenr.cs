using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Customer
{
    public partial class CustomerManagemenr : Form
    {
        public CustomerManagemenr()
        {
            InitializeComponent();
        }

        private void CustomerManagemenr_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            View.DataSource = DataAccess.CustomerDao.getAllCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCustomer add = new NewCustomer(this);
            add.Show();
        }
    }
}
