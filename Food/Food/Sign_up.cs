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
    public partial class Sign_up : Form
    {

        Database database = new Database();

        public Sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '•';
            pictureBox_show2.Visible = false;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login2.Text;
            var passwordUser = textBox_password2.Text;

            if (CheckUser() == true)
            {
                database.OpenConnection(database.connection2);                               

                string sqlCommand = $"INSERT INTO `registration`.`registr` (`login`, `password`) VALUES ('{loginUser}', '{passwordUser}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection2));

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!");
                    Log_in login = new Log_in();
                    this.Hide();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Аккаунт не был создан!");
                }
            }                               

            database.CloseConnection(database.connection2);
        }

        private Boolean CheckUser()
        {
            var loginUser = textBox_login2.Text;
            var passwordUser = textBox_password2.Text;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string sqlCommand = $"SELECT id, login, password FROM `registration`.`registr` WHERE login='{loginUser}' AND password='{passwordUser}'; ";
            MySqlCommand command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection2));
                        
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует!");
                textBox_login2.Clear();
                textBox_password2.Clear();
                return false;
            }
            else
            {
                return true;
            }            
        }

        private void pictureBox_hide2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox_hide2.Visible = false;
            pictureBox_show2.Visible = true;            
        }

        private void pictureBox_show2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox_show2.Visible = false;
            pictureBox_hide2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Log_in log_in = new Log_in();
            this.Hide();
            log_in.ShowDialog();
        }
    }
}
