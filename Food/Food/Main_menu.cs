using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_food_Click(object sender, EventArgs e)
        {
            Food frm1 = new Food();
            this.Hide();
            frm1.ShowDialog();
        }

        private void button_shop_list_Click(object sender, EventArgs e)
        {
            Shop_list list = new Shop_list();
            this.Hide();
            list.ShowDialog();
        }

        private void button_meal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            this.Hide();
            meal.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
