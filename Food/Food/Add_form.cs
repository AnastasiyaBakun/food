using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Food
{
    public partial class Add_form : Form
    {
        Database database = new Database();

        public Add_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save2_Click(object sender, EventArgs e)
        {           
            if(CheckDate(textBox_manufacture, textBox_expiration) == true)
            {
                int meal_id = 1;

                if (textBox_ml_id2.Text != "")
                {
                    meal_id = Convert.ToInt32(textBox_ml_id2.Text);
                }

                int list_id = 1;
                if (textBox_lst_id2.Text != "")
                {
                    list_id = Convert.ToInt32(textBox_lst_id2.Text);
                }

                int amount = Convert.ToInt32(textBox_amount2.Text);
                var manufacture = textBox_manufacture.Text;
                var expiration = textBox_expiration.Text;
                var cost = textBox_cost2.Text;

                database.OpenConnection(database.connection);

                string sqlCommand = $"INSERT INTO `food`.`food` (`meal_ml_id`, `shop_list_lst_id`, `fd_amount`, `fd_manufacture_date`, `fd_expiration_date`, `fd_cost`) VALUES ('{meal_id}', '{list_id}', '{amount}', '{manufacture}', '{expiration}', '{cost}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection));

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно создана!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Запись не была создана!");
                }

                database.CloseConnection(database.connection);
            }           
                        
        }      

        private void ProductOrMeal(object sender, EventArgs e)
        {
            if (rBMeal.Checked)
            {
                label_ml_id.Visible = true;
                textBox_ml_id2.Visible = true;
                label_lst_id.Visible = false;
                textBox_lst_id2.Visible = false;
                textBox_lst_id2.Text = "";
            }
            if (rBProduct.Checked)
            {
                label_lst_id.Visible = true;
                textBox_lst_id2.Visible = true;
                label_ml_id.Visible = false;
                textBox_ml_id2.Visible = false;
                textBox_ml_id2.Text = "";
            }
        }

        private void CheckInt(TextBox textBox)
        {
            int amount;

            foreach (int a in textBox.Text)
            {
                if ((int.TryParse(textBox.Text, out amount)) == false)
                {                   
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void CheckCost(TextBox textBox)
        {          
            foreach (char a in textBox.Text)
            {
                if ((char.IsLetter(a) == true) || (a=='-'))
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }                              
            }

            char[] symbols = new char[] { ',', '_', '*', '/', '|', '!', '=', '+', '@', '"', '#', '№', '$', ';', '%', '^', ':', '&', '?', '(', ')', '\'', '<', '>', '[', ']', '{', '}', '~', '`' };
            foreach (char a in textBox.Text)
            {
                foreach (char x in symbols)
                {
                    if (a == x)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                        textBox.SelectionStart = textBox.Text.Length;
                    }
                }
            }
        }

        private void CheckDouble(TextBox textBox)
        {           
            int i = 0;
            foreach (char a in textBox.Text)
            {
                if (a == '.')
                {
                    i++;
                }
            }
            if (i > 1)
            {
                MessageBox.Show("Введите корректную цену!");
                textBox.Clear();
            }
        }

        private bool CheckDate(TextBox textBox1, TextBox textBox2)
        {
            if((textBox1.Text == "") || (textBox2.Text == "") || (Convert.ToDateTime(textBox1.Text) > Convert.ToDateTime(textBox2.Text)))
            {
                MessageBox.Show("Перепроверьте даты!");
                textBox1.Clear();                
                textBox2.Clear();
                return false;
            }
            else
            {
                MessageBox.Show("Даты корректны!");
                return true;
            }
        }

        private void CheckTodayDate(TextBox textBox)
        {
            var periodNow = DateTime.Now;

            if ((textBox.Text == "") || (Convert.ToDateTime(textBox.Text) > periodNow))
            {
                MessageBox.Show("Введите корректную дату!");
                textBox.Clear();
            }
        }

        private void textBox_amount2_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_amount2);
        }

        private void textBox_lst_id2_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_lst_id2);
        }

        private void textBox_ml_id2_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_ml_id2);
        }      

        private void button_check_Click(object sender, EventArgs e)
        {
            CheckDate(textBox_manufacture, textBox_expiration);
        }

        private void textBox_manufacture_Leave(object sender, EventArgs e)
        {
            CheckTodayDate(textBox_manufacture);
        }

        private void textBox_cost2_Leave(object sender, EventArgs e)
        {
            CheckDouble(textBox_cost2);
        }

        private void textBox_cost2_TextChanged(object sender, EventArgs e)
        {
            CheckCost(textBox_cost2);
        }
    }
}
