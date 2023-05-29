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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Food : Form
    {

        Database database = new Database();
        //MySqlConnection connection = new MySqlConnection("SERVER=localhost ;DATABASE=xolodos ;UID=root ;PASSWORD=QkUC7bmE ;");
        int selectedRow;

        public Food()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChangeColumnsName()
        {            
            dataGridView1.Columns[0].HeaderText = "id еды";
            dataGridView1.Columns[1].HeaderText = "Название блюда";
            dataGridView1.Columns[2].HeaderText = "Название продукта";
            dataGridView1.Columns[3].HeaderText = "Количество";
            dataGridView1.Columns[4].HeaderText = "Дата изготовления";
            dataGridView1.Columns[5].HeaderText = "Срок годности";
            dataGridView1.Columns[6].HeaderText = "Цена";            
        }

        private void RefreshDataGrid(DataGridView dgv)
        {            
            dgv.Columns.Clear();            

            database.OpenConnection(database.connection);
            //MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM food.food;", database.connection);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT fd_id, ml_name, pr_name, fd_amount, fd_manufacture_date, fd_expiration_date, fd_cost FROM food.food INNER JOIN food.meal ON meal_ml_id = ml_id INNER JOIN food.shop_list ON shop_list_lst_id = lst_id INNER JOIN food.product ON product_pr_id = pr_id;", database.connection);


            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            
            database.CloseConnection(database.connection);
        }

        private void deleteRow()
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Выбор", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;               

                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                string sqlCommand = $"DELETE FROM `food`.`food` WHERE (`fd_id` = '{id}'); ";
                MySqlCommand command = new MySqlCommand(sqlCommand, database.GetConnection(database.connection));

                database.OpenConnection(database.connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись удалена");
                }
                else
                {
                    MessageBox.Show("Запись не была удалена");
                }

                database.CloseConnection(database.connection);
            }
                        
        }

        private void Search(DataGridView dgv)
        {          
            dgv.Columns.Clear();
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT fd_id, ml_name, pr_name, fd_amount, fd_manufacture_date, fd_expiration_date, fd_cost FROM food.food INNER JOIN food.meal ON meal_ml_id = ml_id INNER JOIN food.shop_list ON shop_list_lst_id = lst_id INNER JOIN food.product ON product_pr_id = pr_id WHERE CONCAT (`ml_name`, `pr_name`, `fd_amount`, `fd_manufacture_date`, `fd_expiration_date`, `fd_cost`) LIKE '%" + textBox_search.Text + "%'; ", database.connection);
                       
            database.OpenConnection(database.connection);

            DataSet dataSet = new DataSet();       
            
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            database.CloseConnection(database.connection);
        }

        private void UpdateState()
        {
            database.connection.Open();

            for(int i=0; i<dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[7].Value;

                if(rowState == RowState.Existed)
                {
                    continue;
                }

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter("DELETE FROM food.food WHERE fd_id = {id};", database.connection);
                    //dataAdapter.SelectCommand.ExecuteNonQuery();
                }
            }

            database.connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                       
            RefreshDataGrid(dataGridView1);
            ChangeColumnsName();                                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_ml_id.Text = row.Cells[1].Value.ToString();
                textBox_lst_id.Text = row.Cells[2].Value.ToString();
                textBox_amount.Text = row.Cells[3].Value.ToString();
                textBox_manufacture.Text = row.Cells[4].Value.ToString();
                textBox_expiration.Text = row.Cells[5].Value.ToString();
                textBox_cost.Text = row.Cells[6].Value.ToString();
            }
            else
            {
                textBox_id.Text = "";
                textBox_ml_id.Text = "";
                textBox_lst_id.Text = "";
                textBox_amount.Text = "";
                textBox_manufacture.Text = "";
                textBox_expiration.Text = "";
                textBox_cost.Text = "";
            }
        }

        private void button_new_row_Click(object sender, EventArgs e)
        {
            Add_form add = new Add_form();
            add.ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ChangeColumnsName();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
            ChangeColumnsName();
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
                if ((char.IsLetter(a) == true) || (a == '-'))
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

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;                                 

            int amount = Convert.ToInt32(textBox_amount.Text);
            var cost = textBox_cost.Text;                       

            if((textBox_amount.Text!="") || (cost != ""))
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(amount, cost);
            }
            else
            {
                MessageBox.Show("Строки не должны быть пустыми!");
            }

            database.OpenConnection(database.connection);

            MySqlCommand command = null;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {               
                string sqlCommand = $"UPDATE `food`.`food` SET fd_amount='{amount}', fd_cost='{cost}' WHERE fd_id='{id}';";
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

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {
            CheckInt(textBox_amount);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_menu main_Menu = new Main_menu();            
            this.Hide();
            main_Menu.ShowDialog();
        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {
            CheckCost(textBox_cost);
        }

        private void textBox_cost_Leave(object sender, EventArgs e)
        {
            CheckDouble(textBox_cost);
        }
    }
}
