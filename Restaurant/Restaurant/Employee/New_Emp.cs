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
    public partial class New_Emp : Form
    {
        private Entity.Employee emp;
        private String mode;
        EmployeeManager view;
        public New_Emp()
        {
            InitializeComponent();
            Emp_gender.DataSource = genders;
            Emp_role.DataSource = role;
        }
        public New_Emp(Entity.Employee emp, String mode, EmployeeManager view)
        {
            InitializeComponent();
            this.emp = emp;
            this.mode = mode;
            this.view = view;
        }

        public New_Emp( String mode, EmployeeManager view)
        {
            InitializeComponent();
            this.mode = mode;
            Emp_gender.DataSource = genders;
            Emp_role.DataSource = role;
            this.view = view;
        }
        private void New_Emp_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "Add":
                    Control_button.Text = "Add";
                    btn_update.Visible = false;
                    Remove_btn.Visible = false;
                    break;              
                case "Detail":
                    btn_update.Visible = true;
                    Remove_btn.Visible = true;
                    loadEmpInfor();
                    Control_button.Text = "Exit";
                    break;
            }
        }

        protected void loadEmpInfor()
        {
            Emp_gender.DataSource = genders;
            Emp_role.DataSource = role;
            Emp_id.Text = Convert.ToString(emp.id);
            Emp_name.Text = emp.Name;
            Emp_iden.Text = emp.Identity;
            Emp_dob.Text = emp.Dob;
            int gender = emp.Gender;
            if (gender == 1)
            {
                Emp_gender.Text = "Male";
            }
            else
            {
                Emp_gender.Text = "Female";
            }
            Emp_phone.Text = emp.Phone;
            Emp_Address.Text = emp.Address;
            Console.WriteLine(emp.Role);
            Emp_role.Text = emp.Role;
            Emp_salary.Text = Convert.ToString(emp.Salary);
            Emp_start.Text = emp.Start_date;
           
        }

        private void Control_button_Click(object sender, EventArgs e)
        {
            if (mode.Equals("Detail"))
            {
                this.Close();
            }else if (mode.Equals("Add"))
            {
                String name = Emp_name.Text;
                String Identify = Emp_iden.Text;
                String dob = Emp_dob.Text;
                int Gender = Emp_gender.SelectedIndex;
                String Phone = Emp_phone.Text;
                String Address = Emp_Address.Text;
                String Role = Emp_role.Text;
                String Des = Emp_des.Text;
                int Salary = Int32.Parse(Emp_salary.Text);
                String des = Emp_des.Text;
                Entity.Employee emp = new Entity.Employee(name, Identify, dob, Gender, Phone, Address, Role, Salary, des);
                int check = DataAccess.EmployeeDao.InsertEmp(emp);
                if(check == 1)
                {
                    MessageBox.Show("Add Complete !!");
                    view.loadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error !!!! \r\n Not Valid Data " );
                }
            }
        }
     
        String[] genders= {  "Female","Male" };
        String[] role = { "Manager", "Waiter", "Chief", "Reception", "Vice-cook", "Sanitation worker", "Guard", "Accountant" };

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(Emp_id.Text);
                String Phone = Emp_phone.Text;
                String Address = Emp_Address.Text;
                String Role = Emp_role.Text;
                String Des = Emp_des.Text;
                int Salary = Int32.Parse(Emp_salary.Text);
                String des = Emp_des.Text;
                int check = DataAccess.EmployeeDao.updateEmp(Phone, Address, Role, Salary, des, id);
                if (check == 1)
                {
                    view.loadData();
                    MessageBox.Show("Add Complete !!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error !!!! \r\n Not Valid Data ");
                }
            }catch(Exception E)
            {
                MessageBox.Show("Error !!!! \r\n Not Valid Data ");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(Emp_id.Text);
                int check = DataAccess.EmployeeDao.deleteEmp(id);
                if (check == 1)
                {
                    MessageBox.Show("Delete Sucessful !!!");
                    view.loadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Delete Error !!!");
                }
            }
            catch
            {
                MessageBox.Show("Delete Error !!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
