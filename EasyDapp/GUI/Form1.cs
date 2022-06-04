using EasyDapp.GUI;
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

namespace EasyDapp
{
    public partial class Form1 : Form
    {
        public string Global_sting_conn { get; set; }

        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        bool check_fill_name = false;
        bool check_fill_wiev = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConnectionFrom connectionFrom = new ConnectionFrom();
            connectionFrom.ShowDialog();
            treeView1.Nodes[0].Text = connectionFrom.DataBase;
            Global_sting_conn = connectionFrom.ConnString;
            fill_name_table();
        }
        private void fill_grid_view()
        {
            if (treeView1.SelectedNode.Level == 2)
            {
                if (check_fill_wiev == true)
                {
                    table.Clear();
                }
                else
                {
                    check_fill_wiev = false;
                }
                sqlConnection = new SqlConnection(Global_sting_conn);
                sqlConnection.Open();
                adapter = new SqlDataAdapter("SELECT * FROM " + treeView1.SelectedNode.Text, sqlConnection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                check_fill_wiev = true;
            }
            else
            {
                MessageBox.Show("Выберите таблицу!", "Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void fill_name_table()
        {
            if (Global_sting_conn != null)
            {
                if (check_fill_name == true)
                {
                    treeView1.Nodes[0].Nodes[0].Nodes.Clear();
                }
                else
                {
                    check_fill_name = false;
                }
                string sql = "SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_TYPE != 'VIEW'";
                SqlConnection conn = new SqlConnection(Global_sting_conn);
                try
                {
                    conn.Open();
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Ошибка" + se);
                    return;
                }
                SqlCommand command = new SqlCommand(sql, conn);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        treeView1.Nodes[0].Nodes[0].Nodes.Add(reader.GetString(0));
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка:" + ex);
                }
                conn.Close();
                check_fill_name = true;
            }
        }
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            
        }

        private void View_table_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Req_pictureBox_Click(object sender, EventArgs e)
        {
            if (Global_sting_conn != null)
            {
                RequestForm requestForm = new RequestForm();
                requestForm.sqlConn = Global_sting_conn;
                requestForm.Show();
            }
            else
            {
                MessageBox.Show("Подключите БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Refresh_pictureBox_Click(object sender, EventArgs e)
        {
            if (Global_sting_conn != null)
            {
                fill_name_table();
                treeView1.Nodes[0].ExpandAll();
            }
            else
            {
                MessageBox.Show("Подключите БД","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void Show_table_pictureBox_Click(object sender, EventArgs e)
        {
            fill_grid_view();
        }
    }
}
