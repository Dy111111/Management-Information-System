namespace 党建信息管理系统LS
{
    partial class LoginLS
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttLogin = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("腾祥金砖黑简", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(146, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("腾祥金砖黑简", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(146, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("迷你简雪君", 13F);
            this.textName.Location = new System.Drawing.Point(233, 95);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(143, 29);
            this.textName.TabIndex = 2;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("微软雅黑", 10.00001F, System.Drawing.FontStyle.Bold);
            this.textPass.Location = new System.Drawing.Point(233, 143);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(143, 29);
            this.textPass.TabIndex = 3;
            this.textPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPass_KeyPress);
            // 
            // buttLogin
            // 
            this.buttLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttLogin.Location = new System.Drawing.Point(174, 193);
            this.buttLogin.Name = "buttLogin";
            this.buttLogin.Size = new System.Drawing.Size(75, 32);
            this.buttLogin.TabIndex = 4;
            this.buttLogin.Text = "登录";
            this.buttLogin.UseVisualStyleBackColor = false;
            this.buttLogin.Click += new System.EventHandler(this.buttLogin_Click);
            // 
            // buttClose
            // 
            this.buttClose.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttClose.Location = new System.Drawing.Point(281, 193);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(75, 32);
            this.buttClose.TabIndex = 5;
            this.buttClose.Text = "取消";
            this.buttClose.UseVisualStyleBackColor = false;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(362, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 317);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.buttLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "LoginLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Activated += new System.EventHandler(this.F_Login_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginLS_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginLS_FormClosed);
            this.Load += new System.EventHandler(this.LoginLS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttLogin;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

