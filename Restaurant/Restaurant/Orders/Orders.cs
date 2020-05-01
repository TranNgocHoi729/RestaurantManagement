using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Orders
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            FormatGridView();
            LoadData();

        }

        public void FormatGridView()
        {
            String[] col_name = { "ID", "CustomerID", "OrderDate", "NumTable", "Description" ,"Paid" };
            for (int i = 0; i < col_name.Length; i++)
            {
                View.Columns.Add(col_name[i], col_name[i]);
                View.Columns[col_name[i]].DataPropertyName = col_name[i];
            }

            DataGridViewButtonColumn ViewInfor = new DataGridViewButtonColumn();
            ViewInfor.Name = "Infor";
            ViewInfor.Text = "View";

            DataGridViewButtonColumn paid = new DataGridViewButtonColumn();
            paid.Name = "Pay";
            paid.Text = "Pay";
            View.Columns.Add(paid);
            ViewInfor.UseColumnTextForButtonValue = true;
            paid.UseColumnTextForButtonValue = true;
            View.Columns.Add(ViewInfor);
            View.AutoGenerateColumns = false;
        }
        public void LoadData()
        {
            View.DataSource = DataAccess.OrderDao.getAllOrders();
        }
        private void View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (View.Columns[e.ColumnIndex].Name == "Infor")
                {
                    DataGridViewRow dr = View.Rows[e.RowIndex];
                    int ID = Int32.Parse(dr.Cells["ID"].Value.ToString());
                    OrderDetail detail = new OrderDetail(ID);
                    detail.Show();
                }
                else if (View.Columns[e.ColumnIndex].Name == "Pay")
                {
                    DataGridViewRow dr = View.Rows[e.RowIndex];
                    int ID = Int32.Parse(dr.Cells["ID"].Value.ToString());
                    int check = DataAccess.OrderDao.PayOrder(ID);
                    Console.WriteLine(check + "----------------");
                    LoadData();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.Show();
                 
        }
    }
}
