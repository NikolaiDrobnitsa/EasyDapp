
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelAddBD = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View_table_button = new System.Windows.Forms.Button();
            this.Req_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Req_pictureBox);
            this.panel1.Controls.Add(this.View_table_button);
            this.panel1.Controls.Add(this.Refresh_button);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.labelAddBD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
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
            this.labelAddBD.Location = new System.Drawing.Point(7, 43);
            this.labelAddBD.MaximumSize = new System.Drawing.Size(70, 0);
            this.labelAddBD.Name = "labelAddBD";
            this.labelAddBD.Size = new System.Drawing.Size(69, 26);
            this.labelAddBD.TabIndex = 1;
            this.labelAddBD.Text = "Подключить БД";
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
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(96, 13);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(75, 23);
            this.Refresh_button.TabIndex = 3;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
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
            // View_table_button
            // 
            this.View_table_button.Location = new System.Drawing.Point(96, 43);
            this.View_table_button.Name = "View_table_button";
            this.View_table_button.Size = new System.Drawing.Size(75, 23);
            this.View_table_button.TabIndex = 4;
            this.View_table_button.Text = "Wiev";
            this.View_table_button.UseVisualStyleBackColor = true;
            this.View_table_button.Click += new System.EventHandler(this.View_table_button_Click);
            // 
            // Req_pictureBox
            // 
            this.Req_pictureBox.BackgroundImage = global::EasyDapp.Properties.Resources.req;
            this.Req_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Req_pictureBox.Location = new System.Drawing.Point(17, 322);
            this.Req_pictureBox.Name = "Req_pictureBox";
            this.Req_pictureBox.Size = new System.Drawing.Size(59, 34);
            this.Req_pictureBox.TabIndex = 5;
            this.Req_pictureBox.TabStop = false;
            this.Req_pictureBox.Click += new System.EventHandler(this.Req_pictureBox_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "EasyDapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Req_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAddBD;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dbToolStripMenuItem;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View_table_button;
        private System.Windows.Forms.PictureBox Req_pictureBox;
    }
}

