
namespace EasyDapp.GUI
{
    partial class ConnectionFrom
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
            this.TitleInfolabel = new System.Windows.Forms.Label();
            this.Date_Source_Label = new System.Windows.Forms.Label();
            this.Date_source_textBox = new System.Windows.Forms.TextBox();
            this.Name_database_label = new System.Windows.Forms.Label();
            this.Name_database_textBox = new System.Windows.Forms.TextBox();
            this.Auth_label = new System.Windows.Forms.Label();
            this.Check_fake_label = new System.Windows.Forms.Label();
            this.Check_fake_sql_textBox = new System.Windows.Forms.TextBox();
            this.Name_user_label = new System.Windows.Forms.Label();
            this.Pass_user_label = new System.Windows.Forms.Label();
            this.Name_user_textBox = new System.Windows.Forms.TextBox();
            this.Pass_user_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Check_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Name_data_textBox = new System.Windows.Forms.TextBox();
            this.Name_date_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleInfolabel
            // 
            this.TitleInfolabel.AutoSize = true;
            this.TitleInfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleInfolabel.Location = new System.Drawing.Point(32, 18);
            this.TitleInfolabel.Name = "TitleInfolabel";
            this.TitleInfolabel.Size = new System.Drawing.Size(442, 16);
            this.TitleInfolabel.TabIndex = 0;
            this.TitleInfolabel.Text = "Введите данные для подключения к выбраному источнику данных";
            // 
            // Date_Source_Label
            // 
            this.Date_Source_Label.AutoSize = true;
            this.Date_Source_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Source_Label.Location = new System.Drawing.Point(32, 46);
            this.Date_Source_Label.Name = "Date_Source_Label";
            this.Date_Source_Label.Size = new System.Drawing.Size(108, 15);
            this.Date_Source_Label.TabIndex = 1;
            this.Date_Source_Label.Text = "Иточник данных: ";
            // 
            // Date_source_textBox
            // 
            this.Date_source_textBox.Enabled = false;
            this.Date_source_textBox.Location = new System.Drawing.Point(35, 63);
            this.Date_source_textBox.Name = "Date_source_textBox";
            this.Date_source_textBox.Size = new System.Drawing.Size(286, 20);
            this.Date_source_textBox.TabIndex = 2;
            this.Date_source_textBox.Text = "Microsoft SQL Server (SqlClient)";
            // 
            // Name_database_label
            // 
            this.Name_database_label.AutoSize = true;
            this.Name_database_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_database_label.Location = new System.Drawing.Point(32, 86);
            this.Name_database_label.Name = "Name_database_label";
            this.Name_database_label.Size = new System.Drawing.Size(89, 15);
            this.Name_database_label.TabIndex = 3;
            this.Name_database_label.Text = "Имя сервера: ";
            // 
            // Name_database_textBox
            // 
            this.Name_database_textBox.Location = new System.Drawing.Point(35, 103);
            this.Name_database_textBox.Name = "Name_database_textBox";
            this.Name_database_textBox.Size = new System.Drawing.Size(286, 20);
            this.Name_database_textBox.TabIndex = 4;
            // 
            // Auth_label
            // 
            this.Auth_label.AutoSize = true;
            this.Auth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_label.Location = new System.Drawing.Point(32, 174);
            this.Auth_label.Name = "Auth_label";
            this.Auth_label.Size = new System.Drawing.Size(96, 15);
            this.Auth_label.TabIndex = 5;
            this.Auth_label.Text = "Вход на сервер";
            // 
            // Check_fake_label
            // 
            this.Check_fake_label.AutoSize = true;
            this.Check_fake_label.Location = new System.Drawing.Point(10, 5);
            this.Check_fake_label.Name = "Check_fake_label";
            this.Check_fake_label.Size = new System.Drawing.Size(128, 13);
            this.Check_fake_label.TabIndex = 6;
            this.Check_fake_label.Text = "Проверка подлинности:";
            // 
            // Check_fake_sql_textBox
            // 
            this.Check_fake_sql_textBox.Enabled = false;
            this.Check_fake_sql_textBox.Location = new System.Drawing.Point(134, 3);
            this.Check_fake_sql_textBox.Name = "Check_fake_sql_textBox";
            this.Check_fake_sql_textBox.Size = new System.Drawing.Size(206, 20);
            this.Check_fake_sql_textBox.TabIndex = 7;
            this.Check_fake_sql_textBox.Text = "Проверка подлинности SQL Server";
            // 
            // Name_user_label
            // 
            this.Name_user_label.AutoSize = true;
            this.Name_user_label.Location = new System.Drawing.Point(41, 32);
            this.Name_user_label.Name = "Name_user_label";
            this.Name_user_label.Size = new System.Drawing.Size(109, 13);
            this.Name_user_label.TabIndex = 8;
            this.Name_user_label.Text = "Имя пользователя: ";
            // 
            // Pass_user_label
            // 
            this.Pass_user_label.AutoSize = true;
            this.Pass_user_label.Location = new System.Drawing.Point(41, 60);
            this.Pass_user_label.Name = "Pass_user_label";
            this.Pass_user_label.Size = new System.Drawing.Size(51, 13);
            this.Pass_user_label.TabIndex = 9;
            this.Pass_user_label.Text = "Пароль: ";
            // 
            // Name_user_textBox
            // 
            this.Name_user_textBox.Location = new System.Drawing.Point(151, 29);
            this.Name_user_textBox.Name = "Name_user_textBox";
            this.Name_user_textBox.Size = new System.Drawing.Size(189, 20);
            this.Name_user_textBox.TabIndex = 10;
            // 
            // Pass_user_textBox
            // 
            this.Pass_user_textBox.Location = new System.Drawing.Point(151, 56);
            this.Pass_user_textBox.Name = "Pass_user_textBox";
            this.Pass_user_textBox.Size = new System.Drawing.Size(189, 20);
            this.Pass_user_textBox.TabIndex = 11;
            this.Pass_user_textBox.TextChanged += new System.EventHandler(this.Pass_user_textBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Check_fake_sql_textBox);
            this.panel1.Controls.Add(this.Pass_user_textBox);
            this.panel1.Controls.Add(this.Check_fake_label);
            this.panel1.Controls.Add(this.Name_user_textBox);
            this.panel1.Controls.Add(this.Name_user_label);
            this.panel1.Controls.Add(this.Pass_user_label);
            this.panel1.Location = new System.Drawing.Point(35, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 100);
            this.panel1.TabIndex = 12;
            // 
            // Check_button
            // 
            this.Check_button.Enabled = false;
            this.Check_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_button.Location = new System.Drawing.Point(35, 308);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(164, 28);
            this.Check_button.TabIndex = 13;
            this.Check_button.Text = "Проверка подключения";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // OK_button
            // 
            this.OK_button.Enabled = false;
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_button.Location = new System.Drawing.Point(311, 308);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(76, 28);
            this.OK_button.TabIndex = 14;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(408, 308);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(76, 28);
            this.Cancel_button.TabIndex = 15;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Name_data_textBox
            // 
            this.Name_data_textBox.Location = new System.Drawing.Point(35, 144);
            this.Name_data_textBox.Name = "Name_data_textBox";
            this.Name_data_textBox.Size = new System.Drawing.Size(286, 20);
            this.Name_data_textBox.TabIndex = 17;
            // 
            // Name_date_label
            // 
            this.Name_date_label.AutoSize = true;
            this.Name_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_date_label.Location = new System.Drawing.Point(32, 126);
            this.Name_date_label.Name = "Name_date_label";
            this.Name_date_label.Size = new System.Drawing.Size(148, 15);
            this.Name_date_label.TabIndex = 16;
            this.Name_date_label.Text = "Название базы данных: ";
            // 
            // ConnectionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 348);
            this.Controls.Add(this.Name_data_textBox);
            this.Controls.Add(this.Name_date_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Auth_label);
            this.Controls.Add(this.Name_database_textBox);
            this.Controls.Add(this.Name_database_label);
            this.Controls.Add(this.Date_source_textBox);
            this.Controls.Add(this.Date_Source_Label);
            this.Controls.Add(this.TitleInfolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionFrom";
            this.Text = "ConnectionFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleInfolabel;
        private System.Windows.Forms.Label Date_Source_Label;
        private System.Windows.Forms.TextBox Date_source_textBox;
        private System.Windows.Forms.Label Name_database_label;
        private System.Windows.Forms.TextBox Name_database_textBox;
        private System.Windows.Forms.Label Auth_label;
        private System.Windows.Forms.Label Check_fake_label;
        private System.Windows.Forms.TextBox Check_fake_sql_textBox;
        private System.Windows.Forms.Label Name_user_label;
        private System.Windows.Forms.Label Pass_user_label;
        private System.Windows.Forms.TextBox Name_user_textBox;
        private System.Windows.Forms.TextBox Pass_user_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox Name_data_textBox;
        private System.Windows.Forms.Label Name_date_label;
    }
}