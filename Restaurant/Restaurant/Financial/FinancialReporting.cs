using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Financial
{
    public partial class FinancialReporting : Form
    {
        public FinancialReporting()
        {
            InitializeComponent();
        }

        private void FinancialReporting_Load(object sender, EventArgs e)
        {
          
        }

        public void loadData()
        {
            
            DateTime fr = From.Value;
            DateTime to = To.Value;
            int days = (to - fr).Days;
            int TotalSalary = DataAccess.FinancialDao.TotalSalary(days);
            Salary.Text = Convert.ToString(TotalSalary + " VND");
            int TotalIncome = DataAccess.FinancialDao.AllIncomeInRange(fr, to);
            int TotalOut = DataAccess.FinancialDao.TotalOutComeInRange(fr,to);
            OutCome.Text = Convert.ToString(TotalOut + " VND");
            Income.Text = Convert.ToString(TotalIncome + " VND");
            int insertss = TotalIncome - TotalSalary - TotalOut;
            Interestlb.Text = Convert.ToString(insertss + " VND");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int outCome = Int32.Parse(OutComeInput.Text);
                int check = DataAccess.FinancialDao.addOutCome(outCome);
                if(check == 1)
                {
                    MessageBox.Show("Success !!");
                    OutComeInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Error !!");
                }
            }catch(Exception E)
            {
                MessageBox.Show("Error !!");
            }
            

        }
    }
}
