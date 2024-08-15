namespace 党建信息管理系统LS.PerFormLS
{
    partial class F_Rota
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Modify = new System.Windows.Forms.Button();
            this.but_Save = new System.Windows.Forms.Button();
            this.but_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.but_Delete = new System.Windows.Forms.Button();
            this.AutoRota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(25, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(513, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "查询条件：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "姓名",
            "值班日期"});
            this.comboBox1.Location = new System.Drawing.Point(94, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "值班日期";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询类别：";
            // 
            // but_Modify
            // 
            this.but_Modify.Location = new System.Drawing.Point(55, 19);
            this.but_Modify.Name = "but_Modify";
            this.but_Modify.Size = new System.Drawing.Size(75, 32);
            this.but_Modify.TabIndex = 2;
            this.but_Modify.Text = "编辑";
            this.but_Modify.UseVisualStyleBackColor = true;
            this.but_Modify.Click += new System.EventHandler(this.but_Modify_Click);
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(275, 19);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(75, 32);
            this.but_Save.TabIndex = 3;
            this.but_Save.Text = "保存";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // but_Exit
            // 
            this.but_Exit.Location = new System.Drawing.Point(388, 19);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(75, 32);
            this.but_Exit.TabIndex = 4;
            this.but_Exit.Text = "退出";
            this.but_Exit.UseVisualStyleBackColor = true;
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AutoRota);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.but_Delete);
            this.groupBox2.Controls.Add(this.but_Modify);
            this.groupBox2.Controls.Add(this.but_Exit);
            this.groupBox2.Controls.Add(this.but_Save);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(25, 539);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "导出到Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_Delete
            // 
            this.but_Delete.Location = new System.Drawing.Point(166, 19);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(75, 32);
            this.but_Delete.TabIndex = 5;
            this.but_Delete.Text = "删除";
            this.but_Delete.UseVisualStyleBackColor = true;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // AutoRota
            // 
            this.AutoRota.Location = new System.Drawing.Point(55, 57);
            this.AutoRota.Name = "AutoRota";
            this.AutoRota.Size = new System.Drawing.Size(205, 37);
            this.AutoRota.TabIndex = 7;
            this.AutoRota.Text = "自动排班";
            this.AutoRota.UseVisualStyleBackColor = true;
            // 
            // F_Rota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_Rota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Rota";
            this.Load += new System.EventHandler(this.F_Rota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Modify;
        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.Button but_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AutoRota;
    }
}