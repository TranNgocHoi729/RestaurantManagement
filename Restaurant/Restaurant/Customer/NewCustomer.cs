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
    public partial class NewCustomer : Form
    {
        CustomerManagemenr cus;
        public NewCustomer()
        {
            InitializeComponent();
        }

        public NewCustomer(CustomerManagemenr cus)
        {
            this.cus = cus;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = NameTb.Text;
            String phone = phoneTb.Text;
            String address = AddressTB.Text;
            String des = DessRb.Text;
            try
            {
                int check = DataAccess.CustomerDao.insertCustomer(name,phone,des,address);
                if(check == 1)
                {
                    MessageBox.Show("Add Success !!");
                    cus.loadData();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Wrong format !!");
                }
            }catch(Exception E)
            {
                MessageBox.Show("Wrong format !!");
            }
        }
    }
}
