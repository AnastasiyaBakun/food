namespace Food
{
    partial class Add_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_check = new System.Windows.Forms.Button();
            this.rBProduct = new System.Windows.Forms.RadioButton();
            this.rBMeal = new System.Windows.Forms.RadioButton();
            this.textBox_expiration = new System.Windows.Forms.TextBox();
            this.textBox_manufacture = new System.Windows.Forms.TextBox();
            this.textBox_cost2 = new System.Windows.Forms.TextBox();
            this.textBox_amount2 = new System.Windows.Forms.TextBox();
            this.textBox_lst_id2 = new System.Windows.Forms.TextBox();
            this.textBox_ml_id2 = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_expiration_date = new System.Windows.Forms.Label();
            this.label_manufacture_date = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_lst_id = new System.Windows.Forms.Label();
            this.label_ml_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание новой записи";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_check);
            this.panel3.Controls.Add(this.rBProduct);
            this.panel3.Controls.Add(this.rBMeal);
            this.panel3.Controls.Add(this.textBox_expiration);
            this.panel3.Controls.Add(this.textBox_manufacture);
            this.panel3.Controls.Add(this.textBox_cost2);
            this.panel3.Controls.Add(this.textBox_amount2);
            this.panel3.Controls.Add(this.textBox_lst_id2);
            this.panel3.Controls.Add(this.textBox_ml_id2);
            this.panel3.Controls.Add(this.label_cost);
            this.panel3.Controls.Add(this.label_expiration_date);
            this.panel3.Controls.Add(this.label_manufacture_date);
            this.panel3.Controls.Add(this.label_amount);
            this.panel3.Controls.Add(this.label_lst_id);
            this.panel3.Controls.Add(this.label_ml_id);
            this.panel3.Controls.Add(this.label_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(189, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 274);
            this.panel3.TabIndex = 3;
            // 
            // button_check
            // 
            this.button_check.AutoSize = true;
            this.button_check.BackColor = System.Drawing.Color.Plum;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(350, 185);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(138, 31);
            this.button_check.TabIndex = 6;
            this.button_check.Text = "Проверка дат";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // rBProduct
            // 
            this.rBProduct.AutoSize = true;
            this.rBProduct.BackColor = System.Drawing.Color.Transparent;
            this.rBProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBProduct.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBProduct.Location = new System.Drawing.Point(363, 14);
            this.rBProduct.Name = "rBProduct";
            this.rBProduct.Size = new System.Drawing.Size(100, 26);
            this.rBProduct.TabIndex = 20;
            this.rBProduct.TabStop = true;
            this.rBProduct.Text = "Продукт";
            this.rBProduct.UseVisualStyleBackColor = false;
            this.rBProduct.CheckedChanged += new System.EventHandler(this.ProductOrMeal);
            // 
            // rBMeal
            // 
            this.rBMeal.AutoSize = true;
            this.rBMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBMeal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBMeal.Location = new System.Drawing.Point(221, 14);
            this.rBMeal.Name = "rBMeal";
            this.rBMeal.Size = new System.Drawing.Size(86, 26);
            this.rBMeal.TabIndex = 19;
            this.rBMeal.TabStop = true;
            this.rBMeal.Text = "Блюдо";
            this.rBMeal.UseVisualStyleBackColor = true;
            this.rBMeal.CheckedChanged += new System.EventHandler(this.ProductOrMeal);
            // 
            // textBox_expiration
            // 
            this.textBox_expiration.Location = new System.Drawing.Point(221, 147);
            this.textBox_expiration.Name = "textBox_expiration";
            this.textBox_expiration.Size = new System.Drawing.Size(267, 22);
            this.textBox_expiration.TabIndex = 18;
            // 
            // textBox_manufacture
            // 
            this.textBox_manufacture.Location = new System.Drawing.Point(221, 116);
            this.textBox_manufacture.Name = "textBox_manufacture";
            this.textBox_manufacture.Size = new System.Drawing.Size(267, 22);
            this.textBox_manufacture.TabIndex = 17;
            this.textBox_manufacture.Leave += new System.EventHandler(this.textBox_manufacture_Leave);
            // 
            // textBox_cost2
            // 
            this.textBox_cost2.BackColor = System.Drawing.Color.White;
            this.textBox_cost2.Location = new System.Drawing.Point(221, 230);
            this.textBox_cost2.Name = "textBox_cost2";
            this.textBox_cost2.Size = new System.Drawing.Size(267, 22);
            this.textBox_cost2.TabIndex = 14;
            this.textBox_cost2.TextChanged += new System.EventHandler(this.textBox_cost2_TextChanged);
            this.textBox_cost2.Leave += new System.EventHandler(this.textBox_cost2_Leave);
            // 
            // textBox_amount2
            // 
            this.textBox_amount2.BackColor = System.Drawing.Color.White;
            this.textBox_amount2.Location = new System.Drawing.Point(221, 86);
            this.textBox_amount2.Name = "textBox_amount2";
            this.textBox_amount2.Size = new System.Drawing.Size(267, 22);
            this.textBox_amount2.TabIndex = 11;
            this.textBox_amount2.TextChanged += new System.EventHandler(this.textBox_amount2_TextChanged);
            // 
            // textBox_lst_id2
            // 
            this.textBox_lst_id2.BackColor = System.Drawing.Color.White;
            this.textBox_lst_id2.Location = new System.Drawing.Point(221, 54);
            this.textBox_lst_id2.Name = "textBox_lst_id2";
            this.textBox_lst_id2.Size = new System.Drawing.Size(267, 22);
            this.textBox_lst_id2.TabIndex = 10;
            this.textBox_lst_id2.Visible = false;
            this.textBox_lst_id2.TextChanged += new System.EventHandler(this.textBox_lst_id2_TextChanged);
            // 
            // textBox_ml_id2
            // 
            this.textBox_ml_id2.BackColor = System.Drawing.Color.White;
            this.textBox_ml_id2.Location = new System.Drawing.Point(221, 54);
            this.textBox_ml_id2.Name = "textBox_ml_id2";
            this.textBox_ml_id2.Size = new System.Drawing.Size(267, 22);
            this.textBox_ml_id2.TabIndex = 9;
            this.textBox_ml_id2.Visible = false;
            this.textBox_ml_id2.TextChanged += new System.EventHandler(this.textBox_ml_id2_TextChanged);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(142, 229);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(57, 22);
            this.label_cost.TabIndex = 7;
            this.label_cost.Text = "Цена:";
            // 
            // label_expiration_date
            // 
            this.label_expiration_date.AutoSize = true;
            this.label_expiration_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_expiration_date.Location = new System.Drawing.Point(63, 147);
            this.label_expiration_date.Name = "label_expiration_date";
            this.label_expiration_date.Size = new System.Drawing.Size(136, 22);
            this.label_expiration_date.TabIndex = 6;
            this.label_expiration_date.Text = "Срок годности:";
            // 
            // label_manufacture_date
            // 
            this.label_manufacture_date.AutoSize = true;
            this.label_manufacture_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_manufacture_date.Location = new System.Drawing.Point(24, 116);
            this.label_manufacture_date.Name = "label_manufacture_date";
            this.label_manufacture_date.Size = new System.Drawing.Size(175, 22);
            this.label_manufacture_date.TabIndex = 5;
            this.label_manufacture_date.Text = "Дата изготовления:";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(86, 85);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(113, 22);
            this.label_amount.TabIndex = 4;
            this.label_amount.Text = "Количество:";
            // 
            // label_lst_id
            // 
            this.label_lst_id.AutoSize = true;
            this.label_lst_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lst_id.Location = new System.Drawing.Point(86, 53);
            this.label_lst_id.Name = "label_lst_id";
            this.label_lst_id.Size = new System.Drawing.Size(113, 22);
            this.label_lst_id.TabIndex = 3;
            this.label_lst_id.Text = "ID продукта:";
            this.label_lst_id.Visible = false;
            // 
            // label_ml_id
            // 
            this.label_ml_id.AutoSize = true;
            this.label_ml_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ml_id.Location = new System.Drawing.Point(86, 53);
            this.label_ml_id.Name = "label_ml_id";
            this.label_ml_id.Size = new System.Drawing.Size(90, 22);
            this.label_ml_id.TabIndex = 2;
            this.label_ml_id.Text = "ID блюда:";
            this.label_ml_id.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(170, 54);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 22);
            this.label_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись:";
            // 
            // button_save2
            // 
            this.button_save2.AutoSize = true;
            this.button_save2.BackColor = System.Drawing.Color.Plum;
            this.button_save2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save2.Location = new System.Drawing.Point(346, 510);
            this.button_save2.Name = "button_save2";
            this.button_save2.Size = new System.Drawing.Size(144, 51);
            this.button_save2.TabIndex = 5;
            this.button_save2.Text = "Сохранить";
            this.button_save2.UseVisualStyleBackColor = false;
            this.button_save2.Click += new System.EventHandler(this.button_save2_Click);
            // 
            // Add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Food.Properties.Resources.Добавление_записи;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save2);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(818, 661);
            this.MinimumSize = new System.Drawing.Size(818, 661);
            this.Name = "Add_form";
            this.Text = "Add form";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_cost2;
        private System.Windows.Forms.TextBox textBox_amount2;
        private System.Windows.Forms.TextBox textBox_lst_id2;
        private System.Windows.Forms.TextBox textBox_ml_id2;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_expiration_date;
        private System.Windows.Forms.Label label_manufacture_date;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_lst_id;
        private System.Windows.Forms.Label label_ml_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save2;
        private System.Windows.Forms.TextBox textBox_manufacture;
        private System.Windows.Forms.TextBox textBox_expiration;
        private System.Windows.Forms.RadioButton rBProduct;
        private System.Windows.Forms.RadioButton rBMeal;
        private System.Windows.Forms.Button button_check;
    }
}