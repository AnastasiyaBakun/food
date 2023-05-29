namespace Food
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.label1 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox_show = new System.Windows.Forms.PictureBox();
            this.pictureBox_hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.DarkViolet;
            this.label_login.Location = new System.Drawing.Point(102, 174);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(107, 35);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Логин:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.DarkViolet;
            this.label_password.Location = new System.Drawing.Point(81, 239);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(130, 35);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBox_login.Location = new System.Drawing.Point(252, 174);
            this.textBox_login.MaxLength = 50;
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(259, 35);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBox_password.Location = new System.Drawing.Point(252, 239);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(259, 35);
            this.textBox_password.TabIndex = 4;
            // 
            // button_enter
            // 
            this.button_enter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_enter.AutoSize = true;
            this.button_enter.BackColor = System.Drawing.Color.Plum;
            this.button_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Tai Le", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter.Location = new System.Drawing.Point(268, 335);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(188, 54);
            this.button_enter.TabIndex = 5;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(281, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 22);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ещё нет аккаунта?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox_show
            // 
            this.pictureBox_show.BackColor = System.Drawing.Color.White;
            this.pictureBox_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_show.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_show.Image")));
            this.pictureBox_show.Location = new System.Drawing.Point(534, 239);
            this.pictureBox_show.Name = "pictureBox_show";
            this.pictureBox_show.Size = new System.Drawing.Size(42, 35);
            this.pictureBox_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_show.TabIndex = 7;
            this.pictureBox_show.TabStop = false;
            this.pictureBox_show.Click += new System.EventHandler(this.pictureBox_show_Click);
            // 
            // pictureBox_hide
            // 
            this.pictureBox_hide.BackColor = System.Drawing.Color.White;
            this.pictureBox_hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_hide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hide.Image")));
            this.pictureBox_hide.Location = new System.Drawing.Point(534, 239);
            this.pictureBox_hide.Name = "pictureBox_hide";
            this.pictureBox_hide.Size = new System.Drawing.Size(42, 35);
            this.pictureBox_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_hide.TabIndex = 8;
            this.pictureBox_hide.TabStop = false;
            this.pictureBox_hide.Click += new System.EventHandler(this.pictureBox_hide_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Food.Properties.Resources.Регистрация_и_авторизация;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_hide);
            this.Controls.Add(this.pictureBox_show);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.MaximumSize = new System.Drawing.Size(733, 497);
            this.MinimumSize = new System.Drawing.Size(733, 497);
            this.Name = "Log_in";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox_show;
        private System.Windows.Forms.PictureBox pictureBox_hide;
    }
}