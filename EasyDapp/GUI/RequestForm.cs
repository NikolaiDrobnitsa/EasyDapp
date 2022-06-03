using System;
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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }
        public string sqlConn { get; set; }
        private void Req_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    SqlConnection SqlConnection = new SqlConnection(sqlConn);
                    SqlCommand SqlCommand = SqlConnection.CreateCommand();
                    SqlCommand.CommandText = textBox1.Text;
                    SqlConnection.Open();

                    var returnValue = SqlCommand.ExecuteScalar();

                    MessageBox.Show("Успешное выполнение запроса");
                    SqlConnection.Close();
                    textBox1.Clear();
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода запроса");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Req_button.Enabled = true;
            }
            else
            {
                Req_button.Enabled = false;
            }
        }
    }
}
