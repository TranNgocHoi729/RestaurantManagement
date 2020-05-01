using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Restaurant.Employee
{
    public partial class Emp_Report : Form
    {
        List<Entity.Employee> listEmp;
        public Emp_Report()
        {
            listEmp = DataAccess.EmployeeDao.getAllEmp();
            InitializeComponent();
            
        }

        private void Emp_Report_Load(object sender, EventArgs e)
        {
            int allEmp = listEmp.Count;
            String max = highestSalary();
            String min = smallestSalary();
            String total_salary = totalSalary();
            int male = num_of_male();
            int female = allEmp - male;
            Total_emp.Text = Convert.ToString(allEmp);
            Total_salary.Text = total_salary;
            Highest.Text = max;
            Smallest.Text = min;
            Male.Text = Convert.ToString(male);
            Female.Text = Convert.ToString(female);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String highestSalary()
        {
            int max = 0;
            String name = "";
            int id = 0;
            foreach (Entity.Employee emp in listEmp)
            {
                if(emp.Salary >= max)
                {
                    max = emp.Salary;
                    name = emp.Name;
                    id = emp.id;
                }
            }
            foreach (Entity.Employee emp in listEmp)
            {
                if (emp.Salary == max && emp.id != id)
                {
                    name = name +" , " +emp.Name;
                }
            }
            return max + " : " + name;
        }

        private String smallestSalary()
        {
            int min = Int32.MaxValue;
            int id = 0;
            String name = "";
            foreach (Entity.Employee emp in listEmp)
            {
                if (emp.Salary <= min)
                {
                    min = emp.Salary;
                    name = emp.Name;
                    id = emp.id;
                }
            }
            foreach (Entity.Employee emp in listEmp)
            {
                if (emp.Salary == min && emp.id != id)
                {
                    name = name + " , " + emp.Name;
                }
            }
            return min + " : " + name;
        }

        private String totalSalary()
        {
            int total = 0;
            foreach (Entity.Employee emp in listEmp)
            {
                total += emp.Salary;
            }
            return Convert.ToString(total);
        }

        public int num_of_male()
        {
            int total = 0;
            foreach (Entity.Employee emp in listEmp)
            {
                if(emp.Gender == 1)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
