
namespace EasyDapp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Таблицы");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("dbo_", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show_table_label = new System.Windows.Forms.Label();
            this.Show_table_pictureBox = new System.Windows.Forms.PictureBox();
            this.Request_label = new System.Windows.Forms.Label();
            this.Refresh_label = new System.Windows.Forms.Label();
            this.Refresh_pictureBox = new System.Windows.Forms.PictureBox();
            this.Req_pictureBox = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelAddBD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_table_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Show_table_label);
            this.panel1.Controls.Add(this.Show_table_pictureBox);
            this.panel1.Controls.Add(this.Request_label);
            this.panel1.Controls.Add(this.Refresh_label);
            this.panel1.Controls.Add(this.Refresh_pictureBox);
            this.panel1.Controls.Add(this.Req_pictureBox);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.labelAddBD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // Show_table_label
            // 
            this.Show_table_label.AutoSize = true;
            this.Show_table_label.Location = new System.Drawing.Point(50, 367);
            this.Show_table_label.Name = "Show_table_label";
            this.Show_table_label.Size = new System.Drawing.Size(86, 13);
            this.Show_table_label.TabIndex = 10;
            this.Show_table_label.Text = "Вывод таблицы";
            // 
            // Show_table_pictureBox
            // 
            this.Show_table_pictureBox.BackgroundImage = global::EasyDapp.Properties.Resources.table_img;
            this.Show_table_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Show_table_pictureBox.Location = new System.Drawing.Point(62, 322);
            this.Show_table_pictureBox.Name = "Show_table_pictureBox";
            this.Show_table_pictureBox.Size = new System.Drawing.Size(60, 41);
            this.Show_table_pictureBox.TabIndex = 9;
            this.Show_table_pictureBox.TabStop = false;
            this.Show_table_pictureBox.Click += new System.EventHandler(this.Show_table_pictureBox_Click);
            // 
            // Request_label
            // 
            this.Request_label.AutoSize = true;
            this.Request_label.Location = new System.Drawing.Point(147, 43);
            this.Request_label.MaximumSize = new System.Drawing.Size(70, 0);
            this.Request_label.Name = "Request_label";
            this.Request_label.Size = new System.Drawing.Size(44, 13);
            this.Request_label.TabIndex = 8;
            this.Request_label.Text = "Запрос";
            // 
            // Refresh_label
            // 
            this.Refresh_label.AutoSize = true;
            this.Refresh_label.Location = new System.Drawing.Point(76, 43);
            this.Refresh_label.MaximumSize = new System.Drawing.Size(70, 0);
            this.Refresh_label.Name = "Refresh_label";
            this.Refresh_label.Size = new System.Drawing.Size(56, 13);
            this.Refresh_label.TabIndex = 7;
            this.Refresh_label.Text = "Обновить";
            // 
            // Refresh_pictureBox
            // 
            this.Refresh_pictureBox.BackgroundImage = global::EasyDapp.Properties.Resources.pngtree_reload_vector_icon_png_image_696434;
            this.Refresh_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refresh_pictureBox.Location = new System.Drawing.Point(73, 6);
            this.Refresh_pictureBox.Name = "Refresh_pictureBox";
            this.Refresh_pictureBox.Size = new System.Drawing.Size(59, 34);
            this.Refresh_pictureBox.TabIndex = 6;
            this.Refresh_pictureBox.TabStop = false;
            this.Refresh_pictureBox.Click += new System.EventHandler(this.Refresh_pictureBox_Click);
            // 
            // Req_pictureBox
            // 
            this.Req_pictureBox.BackgroundImage = global::EasyDapp.Properties.Resources.req;
            this.Req_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Req_pictureBox.Location = new System.Drawing.Point(138, 6);
            this.Req_pictureBox.Name = "Req_pictureBox";
            this.Req_pictureBox.Size = new System.Drawing.Size(59, 34);
            this.Req_pictureBox.TabIndex = 5;
            this.Req_pictureBox.TabStop = false;
            this.Req_pictureBox.Click += new System.EventHandler(this.Req_pictureBox_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(8, 72);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Tables";
            treeNode1.Text = "Таблицы";
            treeNode2.Name = "NameBD";
            treeNode2.Text = "dbo_";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(173, 244);
            this.treeView1.TabIndex = 2;
            // 
            // labelAddBD
            // 
            this.labelAddBD.AutoSize = true;
            this.labelAddBD.Location = new System.Drawing.Point(3, 43);
            this.labelAddBD.MaximumSize = new System.Drawing.Size(70, 0);
            this.labelAddBD.Name = "labelAddBD";
            this.labelAddBD.Size = new System.Drawing.Size(69, 26);
            this.labelAddBD.TabIndex = 1;
            this.labelAddBD.Text = "Подключить БД";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EasyDapp.Properties.Resources.database_symbol_test_data_management_icon_1142395;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // dbToolStripMenuItem
            // 
            this.dbToolStripMenuItem.Name = "dbToolStripMenuItem";
            this.dbToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.dbToolStripMenuItem.Text = "Db";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(200, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 450);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EasyDapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Show_table_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAddBD;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dbToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Req_pictureBox;
        private System.Windows.Forms.PictureBox Refresh_pictureBox;
        private System.Windows.Forms.PictureBox Show_table_pictureBox;
        private System.Windows.Forms.Label Request_label;
        private System.Windows.Forms.Label Refresh_label;
        private System.Windows.Forms.Label Show_table_label;
    }
}

