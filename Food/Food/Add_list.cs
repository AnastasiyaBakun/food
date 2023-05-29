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

namespace Food
{
    public partial class Add_list : Form
    {
        Database database = new Database();

        public Add_list()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save2_Click(object sender, EventArgs e)
        {
            int product_id = Convert.ToInt32(textBox_pr_id.Text);                    

            int amount = Convert.ToInt32(textBox_amount.Text);

            var date = textBox_date.Text;           
            int bought = Convert.ToInt32(checkBox_bought.Checked);

            database.OpenConnection(database.connection);                      

            string sqlCommand = $"INSERT INTO `food`.`shop_list` (`product_pr_id`, `lst_amount`, `lst_date`, `lst_bought`) VALUES ('{product_id}', '{amount}', '{date}', '{bought}'); ";
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

        private void CheckInt(TextBox textBox)
        {
            int amount;

            foreach (int a in textBox.Text)
            {                
                if ((int.TryParse(textBox.Text, out amount))==false)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length-1);
                    textBox.SelectionStart = textBox.Text.Length;
                }                                    
            }
        }

        private void CheckDate(TextBox textBox)
        {
            var periodNow = DateTime.Now;

            if ((textBox.Text == "") || (Convert.ToDateTime(textBox.Text) > periodNow))
            {
                MessageBox.Show("Введите корректную дату!");
                textBox.Clear();
            }
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_amount);
        }

        private void textBox_pr_id_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_pr_id);
        }

        private void textBox_date_Leave(object sender, EventArgs e)
        {
            CheckDate(textBox_date);
        }
    }
}
