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
    public partial class Shop_list : Form
    {

        Database database = new Database();
        int selectedRow;

        public Shop_list()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChangeColumnsName()
        {
            dataGridView2.Columns[0].HeaderText = "id";
            dataGridView2.Columns[1].HeaderText = "Название продукта";
            dataGridView2.Columns[2].HeaderText = "Количество";
            dataGridView2.Columns[3].HeaderText = "Дата внесения";
            dataGridView2.Columns[4].HeaderText = "Куплен";            
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();

            database.OpenConnection(database.connection);
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT lst_id, pr_name, lst_amount, lst_date, lst_bought FROM food.shop_list INNER JOIN food.product ON product_pr_id = pr_id WHERE lst_id <> 1;", database.connection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            database.CloseConnection(database.connection);
        }

        private void Shop_list_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
            ChangeColumnsName();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_pr_id.Text = row.Cells[1].Value.ToString();
                textBox_amount.Text = row.Cells[2].Value.ToString();
                textBox_date.Text = row.Cells[3].Value.ToString();              
                comboBox1.Text= row.Cells[4].Value.ToString();
            }
            else
            {
                textBox_id.Text = "";
                textBox_pr_id.Text = "";
                textBox_amount.Text = "";
                textBox_date.Text = "";
                comboBox1.Text = string.Empty;
            }
        }

        private void button_new_row_Click(object sender, EventArgs e)
        {
            Add_list addlist = new Add_list();
            addlist.ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
            ChangeColumnsName();
        }

        private void Search(DataGridView dgv)
        {
            dgv.Columns.Clear();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT lst_id, pr_name, lst_amount, lst_date, lst_bought FROM shop_list INNER JOIN product ON product_pr_id = pr_id WHERE CONCAT (`pr_name`) LIKE '%" + textBox_search.Text + "%'; ", database.connection);

            database.OpenConnection(database.connection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];

            database.CloseConnection(database.connection);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView2);
            ChangeColumnsName();
        }

        private void Change()
        {           
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var bought = 0;

            if (comboBox1.Text == "True")
            {
                bought = 1;
            }
            else
            {
                bought = 0;
            }

            dataGridView2.Rows[selectedRowIndex].SetValues(bought);

            database.OpenConnection(database.connection);

            MySqlCommand command = null;           

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string sqlCommand = $"UPDATE `food`.`shop_list` SET lst_bought='{bought}' WHERE lst_id='{id}';";
                command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection));
            }

            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Запись не была изменена!");
            }
            else
            {
                MessageBox.Show("Запись успешно изменена!");
            }

            database.CloseConnection(database.connection);
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "True")
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_menu main_Menu = new Main_menu();
            this.Hide();
            main_Menu.ShowDialog();
        }
    }
}
