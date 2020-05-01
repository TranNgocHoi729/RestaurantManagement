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
    public partial class NewOrder : Form
    {
        Dictionary<String, NumericUpDown> choose = new Dictionary<String, NumericUpDown>();
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            loadDataToCustomer();
            loadDataToType();
            loadDishToList();
        }

        private void loadDataToType()
        {
            DataTable type = DataAccess.DishDao.getTypes();
            foreach (DataRow dr in type.Rows)
            {              
                String name = Convert.ToString(dr["name"]);
                dishType.Items.Add(name);
            }
            int numofType = dishType.Items.Count;
            if (numofType > 0)
            {
                dishType.SelectedIndex = 0;
            }
        }
            

        private void loadDataToCustomer()
        {
            DataTable customer = DataAccess.CustomerDao.getAllCustomer();
            foreach (DataRow dr in customer.Rows)
            {
                String id = Convert.ToString(dr["id"]);
                String name = Convert.ToString(dr["name"]);
                DCustomer.Items.Add(id + ":" + name);
            }
            int numofCus = DCustomer.Items.Count;
            if (numofCus > 0)
            {
                DCustomer.SelectedIndex = 0;
            }
        }


        private void loadDishToList()
        {
            String type = dishType.Text;
            ListDish.Items.Clear();

            DataTable dt = DataAccess.DishDao.getDishesByTypeName(type);
            foreach(DataRow dr in dt.Rows)
            {
                ListDish.Items.Add(Convert.ToString(dr["name"]));
            }
        }

        private void dishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDishToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ListDish.SelectedItem != null)
            {
                Label label = new Label();
                NumericUpDown num = new NumericUpDown();
                num.Value = 1;
                label.Text = ListDish.SelectedItem.ToString();
                label.AutoSize = true;
                try
                {
                    choose.Add(ListDish.SelectedItem.ToString(), num);
                    lastDish = label.Text;
                    Order_panel.Controls.Add(label);
                    Order_panel.Controls.Add(num);
                }
                catch
                {                 
                }
                ListDish.ClearSelected();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String descrip_table = rtbOrder_table.Text;
                String descrip_Detail = rtb_OrderDetail.Text;
                String[] splCustomerInfor = DCustomer.Text.Split(':');
                int tablenum = Int32.Parse(numTable.Text);
                int id = Int32.Parse(splCustomerInfor[0]);

                if (choose.Count > 0)
                {
                    DataAccess.OrderDao.InsertOrderTable(id, tablenum, descrip_table);
                    foreach (KeyValuePair<String, NumericUpDown> orderDetails in choose)
                    {
                        int O_id = DataAccess.OrderDao.getLastOrder_id();
                        int p_id = DataAccess.DishDao.Get_id_by_name(orderDetails.Key);
                        int quant = Int32.Parse(orderDetails.Value.Value.ToString());
                        DataAccess.OrderDao.InsertOrderDetail(O_id, p_id, descrip_Detail, quant);
                    }
                    MessageBox.Show("Order Success !!!");
                }
            }catch(Exception E)
            {
                MessageBox.Show("Order Error !!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order_panel.Controls.Clear();
            choose = new Dictionary<String, NumericUpDown>();
        }


        // declare last dish to remove it in Order(Dictionary) if user delete
        String lastDish = "";

        private void button2_Click(object sender, EventArgs e)
        {
           int size =  Order_panel.Controls.Count;
           if(size >= 2)
            {
                Order_panel.Controls.RemoveAt(size - 1);
                Order_panel.Controls.RemoveAt(size - 2);
                choose.Remove(lastDish);
            }
        }


    }
}
