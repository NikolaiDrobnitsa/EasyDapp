﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyDapp.GUI
{
    public partial class ConnectionFrom : Form
    {
        public ConnectionFrom()
        {
            InitializeComponent();
        }

        private void Check_button_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = " + Name_database_textBox.Text +"; Initial Catalog = "+Name_data_textBox.Text + "; User Id = "+Name_user_textBox.Text+"; Password = "+ Pass_user_textBox.Text;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Проверка подключение выполнена!");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Ошибка введенных данных!");

            }
        }

        private void Pass_user_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_database_textBox.Text != "" && Name_user_textBox.Text != "" && Pass_user_textBox.Text !="" && Name_data_textBox.Text != "")
            {
                Check_button.Enabled = true;
            }
            else
            {
                Check_button.Enabled = false;
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
