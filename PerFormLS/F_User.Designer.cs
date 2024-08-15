namespace 党建信息管理系统LS.PerFormLS
{
    partial class F_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_User));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tool_UserAdd = new System.Windows.Forms.ToolStripButton();
            this.tool_UserAmend = new System.Windows.Forms.ToolStripButton();
            this.tool_UserDelete = new System.Windows.Forms.ToolStripButton();
            this.tool_UserPopedom = new System.Windows.Forms.ToolStripButton();
            this.tool_Close = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_UserAdd,
            this.tool_UserAmend,
            this.tool_UserDelete,
            this.tool_UserPopedom,
            this.toolStripSeparator1,
            this.tool_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(383, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(4, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(349, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // tool_UserAdd
            // 
            this.tool_UserAdd.Image = global::党建信息管理系统LS.Properties.Resources._054;
            this.tool_UserAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserAdd.Name = "tool_UserAdd";
            this.tool_UserAdd.Size = new System.Drawing.Size(63, 24);
            this.tool_UserAdd.Text = "添加";
            this.tool_UserAdd.Click += new System.EventHandler(this.tool_UserAdd_Click);
            // 
            // tool_UserAmend
            // 
            this.tool_UserAmend.Image = global::党建信息管理系统LS.Properties.Resources._023;
            this.tool_UserAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserAmend.Name = "tool_UserAmend";
            this.tool_UserAmend.Size = new System.Drawing.Size(63, 24);
            this.tool_UserAmend.Text = "修改";
            this.tool_UserAmend.Click += new System.EventHandler(this.tool_UserAmend_Click);
            // 
            // tool_UserDelete
            // 
            this.tool_UserDelete.Image = global::党建信息管理系统LS.Properties.Resources._039;
            this.tool_UserDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserDelete.Name = "tool_UserDelete";
            this.tool_UserDelete.Size = new System.Drawing.Size(63, 24);
            this.tool_UserDelete.Text = "删除";
            this.tool_UserDelete.Click += new System.EventHandler(this.tool_UserDelete_Click);
            // 
            // tool_UserPopedom
            // 
            this.tool_UserPopedom.Image = global::党建信息管理系统LS.Properties.Resources.key;
            this.tool_UserPopedom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_UserPopedom.Name = "tool_UserPopedom";
            this.tool_UserPopedom.Size = new System.Drawing.Size(63, 24);
            this.tool_UserPopedom.Text = "权限";
            this.tool_UserPopedom.Click += new System.EventHandler(this.tool_UserPopedom_Click);
            // 
            // tool_Close
            // 
            this.tool_Close.Image = ((System.Drawing.Image)(resources.GetObject("tool_Close.Image")));
            this.tool_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Close.Name = "tool_Close";
            this.tool_Close.Size = new System.Drawing.Size(63, 24);
            this.tool_Close.Text = "关闭";
            this.tool_Close.Click += new System.EventHandler(this.tool_Close_Click);
            // 
            // F_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 295);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_User";
            this.Activated += new System.EventHandler(this.F_User_Activated);
            this.Load += new System.EventHandler(this.F_User_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_UserAdd;
        private System.Windows.Forms.ToolStripButton tool_UserAmend;
        private System.Windows.Forms.ToolStripButton tool_UserDelete;
        private System.Windows.Forms.ToolStripButton tool_UserPopedom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}