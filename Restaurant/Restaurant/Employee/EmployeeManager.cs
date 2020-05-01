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
    public partial class EmployeeManager : Form
    {
        public EmployeeManager()
        {
            InitializeComponent();
        }



        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            View.DataSource = DataAccess.EmployeeDao.getAllEmp();
        }
        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = View.Rows[e.RowIndex];
                Object data = dr.DataBoundItem;
                Entity.Employee emp = (Entity.Employee)data;
                New_Emp view = new New_Emp(emp, "Detail", this);
                view.Location = new Point(20, 20);
                view.Visible = true;
            }catch(Exception E)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_Emp view = new New_Emp("Add",this);
            view.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee.Emp_Report report = new Employee.Emp_Report();
            report.Show();
        }


    }
}
