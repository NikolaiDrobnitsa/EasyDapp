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
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConnectionFrom connectionFrom = new ConnectionFrom();
            connectionFrom.Show();
                
        }
        bool check_fill_wiev = false;
        private void fill_grid_view()
        {
            if (check_fill_wiev == true)
            {
                table.Clear();
            }
            else
            {
                check_fill_wiev = false;
            }
            sqlConnection = new SqlConnection(@"Data Source=SQL5108.site4now.net;Initial Catalog=db_a85cd7_nick;User Id=db_a85cd7_nick_admin;Password=Passvbu011");
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM " + treeView1.SelectedNode.Text, sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            check_fill_wiev = true;
        }
        bool check_fill_name = false;
        private void fill_name_table()
        {
            if (check_fill_name == true)
            {
                treeView1.Nodes[0].Nodes[0].Nodes.Clear();
            }
            else
            {
                check_fill_name = false;
            }
            string connStr = @"Data Source=SQL5108.site4now.net;Initial Catalog=db_a85cd7_nick;User Id=db_a85cd7_nick_admin;Password=Passvbu011";
            //treeView1.Nodes[0].Nodes[0].Nodes.Clear();
            //treeView1.Nodes[0].Nodes[1].Text = "ssssss";
            string sql = "SELECT TABLE_NAME FROM information_schema.TABLES WHERE TABLE_TYPE != 'VIEW'";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                MessageBox.Show("Ок");
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
                    //string table = reader.GetString(0);
                    //textBox1.Text += "\n" + reader.GetString(0);
                    //MessageBox.Show(reader.GetString(0));
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
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            fill_name_table();
        }

        private void View_table_button_Click(object sender, EventArgs e)
        {
            fill_grid_view();
        }
    }
}
