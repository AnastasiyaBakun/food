namespace Food
{
    partial class Food
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_change = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new_row = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_expiration = new System.Windows.Forms.TextBox();
            this.textBox_manufacture = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_lst_id = new System.Windows.Forms.TextBox();
            this.textBox_ml_id = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_expiration_date = new System.Windows.Forms.Label();
            this.label_manufacture_date = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_lst_id = new System.Windows.Forms.Label();
            this.label_ml_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 750);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Food.Properties.Resources.Еда;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 69);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Food.Properties.Resources.BackArrow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Food.Properties.Resources.BackArrow;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(688, 23);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(239, 29);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Food.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(644, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_update
            // 
            this.button_update.AutoSize = true;
            this.button_update.BackColor = System.Drawing.Color.Plum;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(955, 23);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(176, 34);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Обновить таблицу";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Еда семьи";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 294);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_change);
            this.panel4.Controls.Add(this.button_delete);
            this.panel4.Controls.Add(this.button_new_row);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(766, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 275);
            this.panel4.TabIndex = 1;
            // 
            // button_change
            // 
            this.button_change.AutoSize = true;
            this.button_change.BackColor = System.Drawing.Color.Plum;
            this.button_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change.Location = new System.Drawing.Point(100, 203);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(144, 51);
            this.button_change.TabIndex = 3;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.BackColor = System.Drawing.Color.Plum;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(100, 129);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(144, 51);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new_row
            // 
            this.button_new_row.AutoSize = true;
            this.button_new_row.BackColor = System.Drawing.Color.Plum;
            this.button_new_row.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new_row.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_row.Location = new System.Drawing.Point(100, 56);
            this.button_new_row.Name = "button_new_row";
            this.button_new_row.Size = new System.Drawing.Size(144, 51);
            this.button_new_row.TabIndex = 1;
            this.button_new_row.Text = "Новая запись";
            this.button_new_row.UseVisualStyleBackColor = false;
            this.button_new_row.Click += new System.EventHandler(this.button_new_row_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Управление записями:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_cost);
            this.panel3.Controls.Add(this.textBox_expiration);
            this.panel3.Controls.Add(this.textBox_manufacture);
            this.panel3.Controls.Add(this.textBox_amount);
            this.panel3.Controls.Add(this.textBox_lst_id);
            this.panel3.Controls.Add(this.textBox_ml_id);
            this.panel3.Controls.Add(this.textBox_id);
            this.panel3.Controls.Add(this.label_cost);
            this.panel3.Controls.Add(this.label_expiration_date);
            this.panel3.Controls.Add(this.label_manufacture_date);
            this.panel3.Controls.Add(this.label_amount);
            this.panel3.Controls.Add(this.label_lst_id);
            this.panel3.Controls.Add(this.label_ml_id);
            this.panel3.Controls.Add(this.label_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(27, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 275);
            this.panel3.TabIndex = 0;
            // 
            // textBox_cost
            // 
            this.textBox_cost.BackColor = System.Drawing.Color.White;
            this.textBox_cost.Location = new System.Drawing.Point(223, 244);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(267, 22);
            this.textBox_cost.TabIndex = 14;
            this.textBox_cost.TextChanged += new System.EventHandler(this.textBox_cost_TextChanged);
            this.textBox_cost.Leave += new System.EventHandler(this.textBox_cost_Leave);
            // 
            // textBox_expiration
            // 
            this.textBox_expiration.BackColor = System.Drawing.Color.White;
            this.textBox_expiration.Location = new System.Drawing.Point(223, 211);
            this.textBox_expiration.Name = "textBox_expiration";
            this.textBox_expiration.ReadOnly = true;
            this.textBox_expiration.Size = new System.Drawing.Size(267, 22);
            this.textBox_expiration.TabIndex = 13;
            // 
            // textBox_manufacture
            // 
            this.textBox_manufacture.BackColor = System.Drawing.Color.White;
            this.textBox_manufacture.Location = new System.Drawing.Point(223, 179);
            this.textBox_manufacture.Name = "textBox_manufacture";
            this.textBox_manufacture.ReadOnly = true;
            this.textBox_manufacture.Size = new System.Drawing.Size(267, 22);
            this.textBox_manufacture.TabIndex = 12;
            // 
            // textBox_amount
            // 
            this.textBox_amount.BackColor = System.Drawing.Color.White;
            this.textBox_amount.Location = new System.Drawing.Point(223, 148);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(267, 22);
            this.textBox_amount.TabIndex = 11;
            this.textBox_amount.TextChanged += new System.EventHandler(this.textBox_amount_TextChanged);
            // 
            // textBox_lst_id
            // 
            this.textBox_lst_id.BackColor = System.Drawing.Color.White;
            this.textBox_lst_id.Location = new System.Drawing.Point(223, 116);
            this.textBox_lst_id.Name = "textBox_lst_id";
            this.textBox_lst_id.ReadOnly = true;
            this.textBox_lst_id.Size = new System.Drawing.Size(267, 22);
            this.textBox_lst_id.TabIndex = 10;
            // 
            // textBox_ml_id
            // 
            this.textBox_ml_id.BackColor = System.Drawing.Color.White;
            this.textBox_ml_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ml_id.Location = new System.Drawing.Point(223, 85);
            this.textBox_ml_id.Name = "textBox_ml_id";
            this.textBox_ml_id.ReadOnly = true;
            this.textBox_ml_id.Size = new System.Drawing.Size(267, 22);
            this.textBox_ml_id.TabIndex = 9;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.White;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(223, 53);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(267, 22);
            this.textBox_id.TabIndex = 8;
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(144, 243);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(57, 22);
            this.label_cost.TabIndex = 7;
            this.label_cost.Text = "Цена:";
            // 
            // label_expiration_date
            // 
            this.label_expiration_date.AutoSize = true;
            this.label_expiration_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expiration_date.Location = new System.Drawing.Point(65, 209);
            this.label_expiration_date.Name = "label_expiration_date";
            this.label_expiration_date.Size = new System.Drawing.Size(136, 22);
            this.label_expiration_date.TabIndex = 6;
            this.label_expiration_date.Text = "Срок годности:";
            // 
            // label_manufacture_date
            // 
            this.label_manufacture_date.AutoSize = true;
            this.label_manufacture_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manufacture_date.Location = new System.Drawing.Point(26, 178);
            this.label_manufacture_date.Name = "label_manufacture_date";
            this.label_manufacture_date.Size = new System.Drawing.Size(175, 22);
            this.label_manufacture_date.TabIndex = 5;
            this.label_manufacture_date.Text = "Дата изготовления:";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(88, 147);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(113, 22);
            this.label_amount.TabIndex = 4;
            this.label_amount.Text = "Количество:";
            // 
            // label_lst_id
            // 
            this.label_lst_id.AutoSize = true;
            this.label_lst_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lst_id.Location = new System.Drawing.Point(23, 115);
            this.label_lst_id.Name = "label_lst_id";
            this.label_lst_id.Size = new System.Drawing.Size(178, 22);
            this.label_lst_id.TabIndex = 3;
            this.label_lst_id.Text = "Название продукта:";
            // 
            // label_ml_id
            // 
            this.label_ml_id.AutoSize = true;
            this.label_ml_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ml_id.Location = new System.Drawing.Point(46, 83);
            this.label_ml_id.Name = "label_ml_id";
            this.label_ml_id.Size = new System.Drawing.Size(155, 22);
            this.label_ml_id.TabIndex = 2;
            this.label_ml_id.Text = "Название блюда:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(170, 54);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(31, 22);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись:";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1202, 797);
            this.MinimumSize = new System.Drawing.Size(1202, 797);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_expiration;
        private System.Windows.Forms.TextBox textBox_manufacture;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_lst_id;
        private System.Windows.Forms.TextBox textBox_ml_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_expiration_date;
        private System.Windows.Forms.Label label_manufacture_date;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_lst_id;
        private System.Windows.Forms.Label label_ml_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new_row;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

