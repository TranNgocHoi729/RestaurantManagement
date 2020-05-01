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
    public partial class OrderDetail : Form
    {
        private int id;
        public OrderDetail()
        {
            InitializeComponent();
        }

        public OrderDetail(int id)
        {
            this.id = id;
            InitializeComponent();
        }


        private void OrderDetail_Load(object sender, EventArgs e)
        {
            FormatView();
            LoadData();
        }

        private void FormatView()
        {
            String[] header = { "ID", "Customer", "Product", "Price", "Discount", "OrderDate", "Num_Table", "Quantity" };
            for (int i = 0; i < header.Length; i++)
            {
                View.Columns.Add(header[i], header[i]);
                View.Columns[header[i]].DataPropertyName = header[i];
            }
            View.AutoGenerateColumns = false;
        }
        private void LoadData()
        {
            View.DataSource = DataAccess.DetailDao.Select_Detail_by_ID(id);
        }
    }
}
