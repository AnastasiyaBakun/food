namespace Food
{
    partial class Main_menu
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
            this.button_food = new System.Windows.Forms.Button();
            this.button_shop_list = new System.Windows.Forms.Button();
            this.button_meal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_food
            // 
            this.button_food.BackColor = System.Drawing.Color.Plum;
            this.button_food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_food.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_food.Location = new System.Drawing.Point(99, 226);
            this.button_food.Name = "button_food";
            this.button_food.Size = new System.Drawing.Size(150, 76);
            this.button_food.TabIndex = 2;
            this.button_food.Text = "Еда";
            this.button_food.UseVisualStyleBackColor = false;
            this.button_food.Click += new System.EventHandler(this.button_food_Click);
            // 
            // button_shop_list
            // 
            this.button_shop_list.BackColor = System.Drawing.Color.Plum;
            this.button_shop_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shop_list.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shop_list.Location = new System.Drawing.Point(323, 226);
            this.button_shop_list.Name = "button_shop_list";
            this.button_shop_list.Size = new System.Drawing.Size(150, 76);
            this.button_shop_list.TabIndex = 3;
            this.button_shop_list.Text = "Список покупок";
            this.button_shop_list.UseVisualStyleBackColor = false;
            this.button_shop_list.Click += new System.EventHandler(this.button_shop_list_Click);
            // 
            // button_meal
            // 
            this.button_meal.BackColor = System.Drawing.Color.Plum;
            this.button_meal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meal.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_meal.Location = new System.Drawing.Point(554, 226);
            this.button_meal.Name = "button_meal";
            this.button_meal.Size = new System.Drawing.Size(150, 76);
            this.button_meal.TabIndex = 4;
            this.button_meal.Text = "Блюда";
            this.button_meal.UseVisualStyleBackColor = false;
            this.button_meal.Click += new System.EventHandler(this.button_meal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(275, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Питание семьи";
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Plum;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(323, 364);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 76);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Food.Properties.Resources.Меню;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 534);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_meal);
            this.Controls.Add(this.button_shop_list);
            this.Controls.Add(this.button_food);
            this.MaximumSize = new System.Drawing.Size(842, 581);
            this.MinimumSize = new System.Drawing.Size(842, 581);
            this.Name = "Main_menu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_food;
        private System.Windows.Forms.Button button_shop_list;
        private System.Windows.Forms.Button button_meal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
    }
}