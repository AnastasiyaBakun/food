namespace Food
{
    partial class Add_list
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
            this.button_save2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_bought = new System.Windows.Forms.CheckBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_pr_id = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_bought = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_pr_id = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.button_save2.TabIndex = 8;
            this.button_save2.Text = "Сохранить";
            this.button_save2.UseVisualStyleBackColor = false;
            this.button_save2.Click += new System.EventHandler(this.button_save2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.checkBox_bought);
            this.panel3.Controls.Add(this.textBox_date);
            this.panel3.Controls.Add(this.textBox_amount);
            this.panel3.Controls.Add(this.textBox_pr_id);
            this.panel3.Controls.Add(this.label_cost);
            this.panel3.Controls.Add(this.label_bought);
            this.panel3.Controls.Add(this.label_date);
            this.panel3.Controls.Add(this.label_amount);
            this.panel3.Controls.Add(this.label_pr_id);
            this.panel3.Controls.Add(this.label_id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(209, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 207);
            this.panel3.TabIndex = 7;
            // 
            // checkBox_bought
            // 
            this.checkBox_bought.AutoSize = true;
            this.checkBox_bought.Enabled = false;
            this.checkBox_bought.Location = new System.Drawing.Point(202, 158);
            this.checkBox_bought.Name = "checkBox_bought";
            this.checkBox_bought.Size = new System.Drawing.Size(18, 17);
            this.checkBox_bought.TabIndex = 18;
            this.checkBox_bought.UseVisualStyleBackColor = true;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(202, 122);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(267, 22);
            this.textBox_date.TabIndex = 17;
            this.textBox_date.Leave += new System.EventHandler(this.textBox_date_Leave);
            // 
            // textBox_amount
            // 
            this.textBox_amount.BackColor = System.Drawing.Color.White;
            this.textBox_amount.Location = new System.Drawing.Point(202, 92);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(267, 22);
            this.textBox_amount.TabIndex = 11;
            this.textBox_amount.TextChanged += new System.EventHandler(this.textBox_amount_TextChanged);
            // 
            // textBox_pr_id
            // 
            this.textBox_pr_id.BackColor = System.Drawing.Color.White;
            this.textBox_pr_id.Location = new System.Drawing.Point(202, 60);
            this.textBox_pr_id.Name = "textBox_pr_id";
            this.textBox_pr_id.Size = new System.Drawing.Size(267, 22);
            this.textBox_pr_id.TabIndex = 10;
            this.textBox_pr_id.TextChanged += new System.EventHandler(this.textBox_pr_id_TextChanged);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(142, 203);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 22);
            this.label_cost.TabIndex = 7;
            // 
            // label_bought
            // 
            this.label_bought.AutoSize = true;
            this.label_bought.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bought.Location = new System.Drawing.Point(104, 153);
            this.label_bought.Name = "label_bought";
            this.label_bought.Size = new System.Drawing.Size(75, 22);
            this.label_bought.TabIndex = 6;
            this.label_bought.Text = "Куплен:";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(40, 122);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(140, 22);
            this.label_date.TabIndex = 5;
            this.label_date.Text = "Дата внесения:";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(67, 91);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(113, 22);
            this.label_amount.TabIndex = 4;
            this.label_amount.Text = "Количество:";
            // 
            // label_pr_id
            // 
            this.label_pr_id.AutoSize = true;
            this.label_pr_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pr_id.Location = new System.Drawing.Point(67, 59);
            this.label_pr_id.Name = "label_pr_id";
            this.label_pr_id.Size = new System.Drawing.Size(113, 22);
            this.label_pr_id.TabIndex = 3;
            this.label_pr_id.Text = "ID продукта:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(151, 60);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 22);
            this.label_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Запись:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(222, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание новой записи";
            // 
            // Add_list
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
            this.Name = "Add_list";
            this.Text = "Add list";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_pr_id;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_pr_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bought;
        private System.Windows.Forms.CheckBox checkBox_bought;
    }
}