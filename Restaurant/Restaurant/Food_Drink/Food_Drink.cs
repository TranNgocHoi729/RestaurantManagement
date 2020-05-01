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
    public partial class Food_Drink : Form
    {
        public Food_Drink()
        {
            InitializeComponent();
            
        }



        private void Food_Drink_Load(object sender, EventArgs e)
        {
            
            GV_ViewDish.Columns.Add("ID", "ID");
            GV_ViewDish.Columns["ID"].DataPropertyName = "ID";

            GV_ViewDish.Columns.Add("Name", "Name");
            GV_ViewDish.Columns["Name"].DataPropertyName = "Name";

            GV_ViewDish.Columns.Add("Discount", "Discount");
            GV_ViewDish.Columns["Discount"].DataPropertyName = "Discount";

            GV_ViewDish.Columns.Add("Price", "Price");
            GV_ViewDish.Columns["Price"].DataPropertyName = "Price";

            GV_ViewDish.Columns.Add("Description", "Description");
            GV_ViewDish.Columns["Description"].DataPropertyName = "Description";

            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.Name = "Editcol";
            editcol.Text = "Edit";
            editcol.UseColumnTextForButtonValue = true;
            GV_ViewDish.Columns.Add(editcol);
            GV_ViewDish.AutoGenerateColumns = false;
        }

        // --- Checked Box
        CheckBox BoxChecking = null;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Just_One_box_select(CB_maindish);
            int type = 1;
            GV_ViewDish.DataSource = DataAccess.DishDao.Select_By_ID(type);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Just_One_box_select(CB_drink);
            int type = 2;
            GV_ViewDish.DataSource = DataAccess.DishDao.Select_By_ID(type);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Just_One_box_select(CB_cake);
            int type = 3;
            GV_ViewDish.DataSource = DataAccess.DishDao.Select_By_ID(type);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Just_One_box_select(CB_salad);
            int type = 4;
            GV_ViewDish.DataSource = DataAccess.DishDao.Select_By_ID(type);
        }


      

        public void Just_One_box_select(CheckBox cb)
        {
            if(BoxChecking == null)
            {
                BoxChecking = cb;
                return;
            }
            BoxChecking.Checked = false;
            BoxChecking = cb;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Add_new_dish add = new Add_new_dish();
            add.Visible = true;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
             Just_One_box_select(cb_all);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   List<Entity.Dish> list = DataAccess.DishDao.Select_All();
            GV_ViewDish.DataSource = list;
        }

        private void GV_ViewDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV_ViewDish.Columns[e.ColumnIndex].Name == "Editcol")
            {
                DataGridViewRow dr = GV_ViewDish.Rows[e.RowIndex];
                Object data = dr.DataBoundItem;
                Entity.Dish dish = (Entity.Dish)data;
                int ID = dish.ID;
                Add_new_dish update = new Add_new_dish(ID);
                update.Visible = true;
            }
        }
    }
}
