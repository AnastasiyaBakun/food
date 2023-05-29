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
    public partial class Meal : Form
    {

        Database database = new Database();
        int selectedRow;

        public Meal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ChangeColumnsName()
        {
            dataGridView3.Columns[0].HeaderText = "id";
            dataGridView3.Columns[1].HeaderText = "Название блюда";
            dataGridView3.Columns[2].HeaderText = "Название рецепта";
            dataGridView3.Columns[3].HeaderText = "Описание";
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();

            database.OpenConnection(database.connection);
            
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT ml_id, ml_name, rp_name, ml_description FROM food.meal INNER JOIN food.recipe ON recipe_rp_id = rp_id WHERE ml_id <> 1;", database.connection);


            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView3.DataSource = dataSet.Tables[0];

            database.CloseConnection(database.connection);
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView3);
            ChangeColumnsName();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_ml_name.Text = row.Cells[1].Value.ToString();
                textBox_rp_name.Text = row.Cells[2].Value.ToString();
                textBox_description.Text = row.Cells[3].Value.ToString();                
            }
            else
            {
                textBox_id.Text = "";
                textBox_ml_name.Text = "";
                textBox_rp_name.Text = "";
                textBox_description.Text = "";                
            }
        }

        private void Search(DataGridView dgv)
        {
            dgv.Columns.Clear();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT ml_id, ml_name, rp_name, ml_description FROM food.meal INNER JOIN food.recipe ON recipe_rp_id = rp_id WHERE CONCAT (`ml_name`, `rp_name`) LIKE '%" + textBox_search.Text + "%'; ", database.connection);

            database.OpenConnection(database.connection);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            dataGridView3.DataSource = dataSet.Tables[0];

            database.CloseConnection(database.connection);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView3);
            ChangeColumnsName();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main_menu main_Menu = new Main_menu();
            this.Hide();
            main_Menu.ShowDialog();
        }
    }
}
