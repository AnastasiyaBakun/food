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
    public partial class Log_in : Form
    {

        Database database = new Database();

        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {           
            textBox_password.PasswordChar = '•';
            pictureBox_show.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up form_signup = new Sign_up();
            form_signup.ShowDialog();
            this.Close();            
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passwordUser = textBox_password.Text;

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string sqlCommand = $"SELECT id, login, password FROM `registration`.`registr` WHERE login='{loginUser}' AND password='{passwordUser}'; ";
            MySqlCommand command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection2));

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                this.Hide();
                Main_menu menu = new Main_menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!");
                textBox_login.Clear();
                textBox_password.Clear();
            }            
        }

        private void pictureBox_hide_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_hide.Visible = false;
            pictureBox_show.Visible = true;            
        }

        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;            
            pictureBox_show.Visible = false;
            pictureBox_hide.Visible = true;
        }
    }
}
