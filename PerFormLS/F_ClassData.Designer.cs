namespace 党建信息管理系统LS.PerFormLS
{
    partial class F_ClassData
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("16级");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("17级");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("18级");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("19级");
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Sub_Table = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_modify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(230, 69);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(664, 522);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.GreenYellow;
            this.dataGridView1.Location = new System.Drawing.Point(7, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(650, 410);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.Sub_Table);
            this.groupBox5.Controls.Add(this.but_save);
            this.groupBox5.Controls.Add(this.but_cancel);
            this.groupBox5.Controls.Add(this.but_delete);
            this.groupBox5.Controls.Add(this.but_modify);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(8, 441);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(651, 78);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // Sub_Table
            // 
            this.Sub_Table.Location = new System.Drawing.Point(20, 28);
            this.Sub_Table.Margin = new System.Windows.Forms.Padding(4);
            this.Sub_Table.Name = "Sub_Table";
            this.Sub_Table.Size = new System.Drawing.Size(105, 29);
            this.Sub_Table.TabIndex = 5;
            this.Sub_Table.Text = "导出到Excel";
            this.Sub_Table.UseVisualStyleBackColor = true;
            this.Sub_Table.Click += new System.EventHandler(this.Sub_Table_Click);
            // 
            // but_save
            // 
            this.but_save.Enabled = false;
            this.but_save.Location = new System.Drawing.Point(533, 25);
            this.but_save.Margin = new System.Windows.Forms.Padding(4);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(100, 32);
            this.but_save.TabIndex = 4;
            this.but_save.Text = "保存";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(407, 25);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(100, 32);
            this.but_cancel.TabIndex = 3;
            this.but_cancel.Text = "取消";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(290, 25);
            this.but_delete.Margin = new System.Windows.Forms.Padding(4);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(100, 32);
            this.but_delete.TabIndex = 2;
            this.but_delete.Text = "删除";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_modify
            // 
            this.but_modify.Location = new System.Drawing.Point(160, 25);
            this.but_modify.Margin = new System.Windows.Forms.Padding(4);
            this.but_modify.Name = "but_modify";
            this.but_modify.Size = new System.Drawing.Size(100, 32);
            this.but_modify.TabIndex = 0;
            this.but_modify.Text = "编辑";
            this.but_modify.UseVisualStyleBackColor = true;
            this.but_modify.Click += new System.EventHandler(this.Sut_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(237, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分类查询";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询类型：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(402, 21);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 27);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "查询条件：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按年级查询",
            "按性别查询",
            "按姓名查询",
            "按学号查询",
            "按是否递交入党申请书查询"});
            this.comboBox1.Location = new System.Drawing.Point(117, 19);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(12, 69);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "16级";
            treeNode2.Name = "节点1";
            treeNode2.Text = "17级";
            treeNode3.Name = "节点2";
            treeNode3.Text = "18级";
            treeNode4.Name = "节点3";
            treeNode4.Text = "19级";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(211, 435);
            this.treeView1.TabIndex = 12;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("腾祥金砖黑简", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "显示全部信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_ClassData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(902, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_ClassData";
            this.Text = "F_ClassData";
            this.Load += new System.EventHandler(this.F_ClassData_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Sub_Table;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_modify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}