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
    public partial class Add_new_dish : Form
    {
        public Boolean NewDish = true;
        public int Dish_Id { get; set; }

        public Add_new_dish()
        {
            InitializeComponent();
        }


        public Add_new_dish(int dish_id)
        {
            InitializeComponent();
            NewDish = false;
            Dish_Id = dish_id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            if(avatar.ShowDialog() == DialogResult.OK)
            {
                String name = avatar.FileName;
               
                var onlyFile = System.IO.Path.GetFileName(avatar.FileName);
                imputImg.Text = "DishImg/" + onlyFile;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                String names = inputName.Text;
                String avt = imputImg.Text;
                int price = Int32.Parse(inputPrice.Text);
                double discount = Double.Parse(InputDiscount.Text);
                int type = InputType.SelectedIndex + 1;
                String dess = InputDescription.Text;
                if (NewDish)
                {
                   Add(names, avt, price, discount, dess, type);
                    MessageBox.Show("Success !!!");

                }
                else
                {
                    Update(names, avt, price, discount, dess, type);
                    MessageBox.Show("Success !!!");
                }

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error !!!");
            }
        }

        private void Add_new_dish_Load(object sender, EventArgs e)
        {
            try
            {
                InputType.Items.Add("Main Dish");
                InputType.Items.Add("Drink");
                InputType.Items.Add("Cake");
                InputType.Items.Add("Salad");
                InputType.SelectedIndex = 0;

                if (!NewDish)
                {
                    Gb_View.Text = "Edit";
                    Entity.Dish dish = DataAccess.DishDao.Get_Dish_By_ID(Dish_Id);
                    inputName.Text = dish.Name;
                    inputPrice.Text = Convert.ToString(dish.Price);
                    InputDiscount.Text = Convert.ToString(dish.Discount);
                    imputImg.Text = dish.avatar;
                    InputDescription.Text = dish.Description;
                    InputType.SelectedIndex = dish.Type - 1;
                }
                else
                {
                    Gb_View.Text = "New Dish";
                }
            }catch(Exception E)
            {
                MessageBox.Show("Error !!!");
            }
        }

        public void Add(String name, String avt , int price , double discount , String des , int type)
        {
             DataAccess.DishDao.addDishAndType(name, avt, price, discount, des, type);
        }

        public void Update(String name, String avt, int price, double discount, String des, int type)
        {
           DataAccess.DishDao.Update_Dish_Type(name, avt, price, discount, des, type);

        }


    }
}
