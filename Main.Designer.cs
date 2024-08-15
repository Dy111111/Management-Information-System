namespace 党建信息管理系统LS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PMBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.Activist = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassData = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu9 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_PTitleSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Grade = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Folk = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_PartyBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Class = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_PadSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_PBJSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MemberSort = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DayWorkPad = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu11 = new System.Windows.Forms.ToolStripMenuItem();
            this.BirthdayNotice = new System.Windows.Forms.ToolStripMenuItem();
            this.RotaNotice = new System.Windows.Forms.ToolStripMenuItem();
            this.AddressBook = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculater = new System.Windows.Forms.ToolStripMenuItem();
            this.Rota = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu5 = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearData = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu6 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSet = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu10 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu7 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mprocess = new System.Windows.Forms.ToolStripMenuItem();
            this.BasicKnowledge = new System.Windows.Forms.ToolStripMenuItem();
            this.SumExperience = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Button_PMBasic = new System.Windows.Forms.ToolStripButton();
            this.Button_Find = new System.Windows.Forms.ToolStripButton();
            this.Button_BasicKonwledge = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_AddressBook = new System.Windows.Forms.ToolStripButton();
            this.Button_DayWorkPad = new System.Windows.Forms.ToolStripButton();
            this.Button_ApplicationExit = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1,
            this.Menu2,
            this.Menu3,
            this.Menu4,
            this.Menu5,
            this.Menu6,
            this.Menu7,
            this.Menu8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.White;
            this.Menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PMBasic,
            this.Activist,
            this.ClassData});
            this.Menu1.ForeColor = System.Drawing.Color.Black;
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(111, 24);
            this.Menu1.Text = "基础信息管理";
            // 
            // PMBasic
            // 
            this.PMBasic.Name = "PMBasic";
            this.PMBasic.Size = new System.Drawing.Size(198, 24);
            this.PMBasic.Text = "党员信息管理";
            this.PMBasic.Click += new System.EventHandler(this.PMBasic_Click);
            // 
            // Activist
            // 
            this.Activist.Name = "Activist";
            this.Activist.Size = new System.Drawing.Size(198, 24);
            this.Activist.Text = "积极分子信息管理";
            this.Activist.Click += new System.EventHandler(this.Activist_Click);
            // 
            // ClassData
            // 
            this.ClassData.Name = "ClassData";
            this.ClassData.Size = new System.Drawing.Size(198, 24);
            this.ClassData.Text = "各班党建信息管理";
            this.ClassData.Click += new System.EventHandler(this.ClassData_Click);
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.Color.White;
            this.Menu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Find,
            this.Statistic,
            this.Menu9});
            this.Menu2.ForeColor = System.Drawing.Color.Black;
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(111, 24);
            this.Menu2.Text = "基本信息处理";
            // 
            // Find
            // 
            this.Find.Image = global::党建信息管理系统LS.Properties.Resources._113;
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(172, 26);
            this.Find.Text = "信息查询";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Statistic
            // 
            this.Statistic.Image = global::党建信息管理系统LS.Properties.Resources._110;
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(172, 26);
            this.Statistic.Text = "信息统计";
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // Menu9
            // 
            this.Menu9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_PTitleSort,
            this.Tool_Grade,
            this.Tool_Folk,
            this.Tool_PartyBranch,
            this.Tool_Class,
            this.Tool_PadSort,
            this.Tool_PBJSort,
            this.Tool_MemberSort});
            this.Menu9.Image = global::党建信息管理系统LS.Properties.Resources._109;
            this.Menu9.Name = "Menu9";
            this.Menu9.Size = new System.Drawing.Size(172, 26);
            this.Menu9.Text = "基础数据设置";
            // 
            // Tool_PTitleSort
            // 
            this.Tool_PTitleSort.Name = "Tool_PTitleSort";
            this.Tool_PTitleSort.Size = new System.Drawing.Size(198, 24);
            this.Tool_PTitleSort.Text = "职称类别设置";
            this.Tool_PTitleSort.Click += new System.EventHandler(this.Tool_PTitleSort_Click_1);
            // 
            // Tool_Grade
            // 
            this.Tool_Grade.Name = "Tool_Grade";
            this.Tool_Grade.Size = new System.Drawing.Size(198, 24);
            this.Tool_Grade.Text = "年级类别设置";
            this.Tool_Grade.Click += new System.EventHandler(this.Tool_Grade_Click_1);
            // 
            // Tool_Folk
            // 
            this.Tool_Folk.Name = "Tool_Folk";
            this.Tool_Folk.Size = new System.Drawing.Size(198, 24);
            this.Tool_Folk.Text = "民族类别设置";
            this.Tool_Folk.Click += new System.EventHandler(this.Tool_Folk_Click_1);
            // 
            // Tool_PartyBranch
            // 
            this.Tool_PartyBranch.Name = "Tool_PartyBranch";
            this.Tool_PartyBranch.Size = new System.Drawing.Size(198, 24);
            this.Tool_PartyBranch.Text = "支部类别设置";
            this.Tool_PartyBranch.Click += new System.EventHandler(this.Tool_PartyBranch_Click_1);
            // 
            // Tool_Class
            // 
            this.Tool_Class.Name = "Tool_Class";
            this.Tool_Class.Size = new System.Drawing.Size(198, 24);
            this.Tool_Class.Text = "班级类别设置";
            this.Tool_Class.Click += new System.EventHandler(this.Tool_Class_Click);
            // 
            // Tool_PadSort
            // 
            this.Tool_PadSort.Name = "Tool_PadSort";
            this.Tool_PadSort.Size = new System.Drawing.Size(198, 24);
            this.Tool_PadSort.Text = "记事本类别设置";
            this.Tool_PadSort.Click += new System.EventHandler(this.Tool_PadSort_Click_1);
            // 
            // Tool_PBJSort
            // 
            this.Tool_PBJSort.Name = "Tool_PBJSort";
            this.Tool_PBJSort.Size = new System.Drawing.Size(198, 24);
            this.Tool_PBJSort.Text = "党内职务类别设置";
            this.Tool_PBJSort.Click += new System.EventHandler(this.Tool_PBJSort_Click_1);
            // 
            // Tool_MemberSort
            // 
            this.Tool_MemberSort.Name = "Tool_MemberSort";
            this.Tool_MemberSort.Size = new System.Drawing.Size(198, 24);
            this.Tool_MemberSort.Text = "班级职务类别设置";
            this.Tool_MemberSort.Click += new System.EventHandler(this.Tool_MemberSort_Click_1);
            // 
            // Menu3
            // 
            this.Menu3.BackColor = System.Drawing.Color.White;
            this.Menu3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DayWorkPad,
            this.Menu11,
            this.AddressBook});
            this.Menu3.ForeColor = System.Drawing.Color.Black;
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(81, 24);
            this.Menu3.Text = "备忘记录";
            // 
            // DayWorkPad
            // 
            this.DayWorkPad.Image = global::党建信息管理系统LS.Properties.Resources._105;
            this.DayWorkPad.Name = "DayWorkPad";
            this.DayWorkPad.Size = new System.Drawing.Size(156, 26);
            this.DayWorkPad.Text = "日常记事";
            this.DayWorkPad.Click += new System.EventHandler(this.DayWorkPad_Click);
            // 
            // Menu11
            // 
            this.Menu11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BirthdayNotice,
            this.RotaNotice});
            this.Menu11.Image = global::党建信息管理系统LS.Properties.Resources._104;
            this.Menu11.Name = "Menu11";
            this.Menu11.Size = new System.Drawing.Size(156, 26);
            this.Menu11.Text = "提示信息";
            this.Menu11.Click += new System.EventHandler(this.Notice_Click);
            // 
            // BirthdayNotice
            // 
            this.BirthdayNotice.Name = "BirthdayNotice";
            this.BirthdayNotice.Size = new System.Drawing.Size(138, 24);
            this.BirthdayNotice.Text = "生日提示";
            this.BirthdayNotice.Click += new System.EventHandler(this.BirthdayNotice_Click);
            // 
            // RotaNotice
            // 
            this.RotaNotice.Name = "RotaNotice";
            this.RotaNotice.Size = new System.Drawing.Size(138, 24);
            this.RotaNotice.Text = "值班提示";
            this.RotaNotice.Click += new System.EventHandler(this.RotaNotice_Click);
            // 
            // AddressBook
            // 
            this.AddressBook.Image = global::党建信息管理系统LS.Properties.Resources._106;
            this.AddressBook.Name = "AddressBook";
            this.AddressBook.Size = new System.Drawing.Size(156, 26);
            this.AddressBook.Text = "通讯录";
            this.AddressBook.Click += new System.EventHandler(this.AddressBook_Click);
            // 
            // Menu4
            // 
            this.Menu4.BackColor = System.Drawing.Color.White;
            this.Menu4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoteBook,
            this.Calculater,
            this.Rota});
            this.Menu4.ForeColor = System.Drawing.Color.Black;
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(81, 24);
            this.Menu4.Text = "工具管理";
            // 
            // NoteBook
            // 
            this.NoteBook.Image = global::党建信息管理系统LS.Properties.Resources._023;
            this.NoteBook.Name = "NoteBook";
            this.NoteBook.Size = new System.Drawing.Size(156, 26);
            this.NoteBook.Text = "记事本";
            this.NoteBook.Click += new System.EventHandler(this.NoteBook_Click);
            // 
            // Calculater
            // 
            this.Calculater.Image = global::党建信息管理系统LS.Properties.Resources.calculator;
            this.Calculater.Name = "Calculater";
            this.Calculater.Size = new System.Drawing.Size(156, 26);
            this.Calculater.Text = "计算器";
            this.Calculater.Click += new System.EventHandler(this.Calculater_Click);
            // 
            // Rota
            // 
            this.Rota.Image = global::党建信息管理系统LS.Properties.Resources.calendar1;
            this.Rota.Name = "Rota";
            this.Rota.Size = new System.Drawing.Size(156, 26);
            this.Rota.Text = "值班表";
            this.Rota.Click += new System.EventHandler(this.Rota_Click);
            // 
            // Menu5
            // 
            this.Menu5.BackColor = System.Drawing.Color.White;
            this.Menu5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupRestore,
            this.ClearData});
            this.Menu5.ForeColor = System.Drawing.Color.Black;
            this.Menu5.Name = "Menu5";
            this.Menu5.Size = new System.Drawing.Size(96, 24);
            this.Menu5.Text = "数据库维护";
            // 
            // BackupRestore
            // 
            this.BackupRestore.BackColor = System.Drawing.SystemColors.Control;
            this.BackupRestore.Image = global::党建信息管理系统LS.Properties.Resources._054;
            this.BackupRestore.Name = "BackupRestore";
            this.BackupRestore.Size = new System.Drawing.Size(193, 26);
            this.BackupRestore.Text = "备份/还原数据库";
            this.BackupRestore.Click += new System.EventHandler(this.BackupRestore_Click);
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.SystemColors.Control;
            this.ClearData.Image = global::党建信息管理系统LS.Properties.Resources._039;
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(193, 26);
            this.ClearData.Text = "清空数据库";
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // Menu6
            // 
            this.Menu6.BackColor = System.Drawing.Color.White;
            this.Menu6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReLogin,
            this.UserSet,
            this.Menu10});
            this.Menu6.ForeColor = System.Drawing.Color.Black;
            this.Menu6.Name = "Menu6";
            this.Menu6.Size = new System.Drawing.Size(81, 24);
            this.Menu6.Text = "系统管理";
            // 
            // ReLogin
            // 
            this.ReLogin.Image = global::党建信息管理系统LS.Properties.Resources._106;
            this.ReLogin.Name = "ReLogin";
            this.ReLogin.Size = new System.Drawing.Size(156, 26);
            this.ReLogin.Text = "重新登录";
            this.ReLogin.Click += new System.EventHandler(this.ReLogin_Click);
            // 
            // UserSet
            // 
            this.UserSet.Image = global::党建信息管理系统LS.Properties.Resources.settings;
            this.UserSet.Name = "UserSet";
            this.UserSet.Size = new System.Drawing.Size(156, 26);
            this.UserSet.Text = "用户设置";
            this.UserSet.Click += new System.EventHandler(this.UserSet_Click);
            // 
            // Menu10
            // 
            this.Menu10.Image = global::党建信息管理系统LS.Properties.Resources._014;
            this.Menu10.Name = "Menu10";
            this.Menu10.Size = new System.Drawing.Size(156, 26);
            this.Menu10.Text = "系统退出";
            this.Menu10.Click += new System.EventHandler(this.ApplicationExit_Click);
            // 
            // Menu7
            // 
            this.Menu7.BackColor = System.Drawing.Color.White;
            this.Menu7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mprocess,
            this.BasicKnowledge,
            this.SumExperience});
            this.Menu7.ForeColor = System.Drawing.Color.Black;
            this.Menu7.Name = "Menu7";
            this.Menu7.Size = new System.Drawing.Size(96, 24);
            this.Menu7.Text = "党建小课堂";
            // 
            // Mprocess
            // 
            this.Mprocess.Image = global::党建信息管理系统LS.Properties.Resources._103;
            this.Mprocess.Name = "Mprocess";
            this.Mprocess.Size = new System.Drawing.Size(172, 26);
            this.Mprocess.Text = "入党流程";
            this.Mprocess.Click += new System.EventHandler(this.Mprocess_Click);
            // 
            // BasicKnowledge
            // 
            this.BasicKnowledge.Image = global::党建信息管理系统LS.Properties.Resources._111;
            this.BasicKnowledge.Name = "BasicKnowledge";
            this.BasicKnowledge.Size = new System.Drawing.Size(172, 26);
            this.BasicKnowledge.Text = "必备知识";
            this.BasicKnowledge.Click += new System.EventHandler(this.BasicKonwledge_Click);
            // 
            // SumExperience
            // 
            this.SumExperience.Image = global::党建信息管理系统LS.Properties.Resources._107;
            this.SumExperience.Name = "SumExperience";
            this.SumExperience.Size = new System.Drawing.Size(172, 26);
            this.SumExperience.Text = "党建经验总结";
            this.SumExperience.Click += new System.EventHandler(this.SumExperience_Click);
            // 
            // Menu8
            // 
            this.Menu8.BackColor = System.Drawing.Color.White;
            this.Menu8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Help});
            this.Menu8.ForeColor = System.Drawing.Color.Black;
            this.Menu8.Name = "Menu8";
            this.Menu8.Size = new System.Drawing.Size(51, 24);
            this.Menu8.Text = "帮助";
            this.Menu8.Click += new System.EventHandler(this.Menu8_Click);
            // 
            // Tool_Help
            // 
            this.Tool_Help.Image = global::党建信息管理系统LS.Properties.Resources._101;
            this.Tool_Help.Name = "Tool_Help";
            this.Tool_Help.Size = new System.Drawing.Size(156, 26);
            this.Tool_Help.Text = "系统帮助";
            this.Tool_Help.Click += new System.EventHandler(this.Tool_Help_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(189, 20);
            this.toolStripStatusLabel1.Text = "欢迎使用党建信息管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel2.Text = "当前登录用户：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(170, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Button_PMBasic,
            this.Button_Find,
            this.Button_BasicKonwledge,
            this.toolStripSeparator1,
            this.Button_AddressBook,
            this.Button_DayWorkPad,
            this.Button_ApplicationExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Button_PMBasic
            // 
            this.Button_PMBasic.BackColor = System.Drawing.Color.White;
            this.Button_PMBasic.ForeColor = System.Drawing.Color.Black;
            this.Button_PMBasic.Image = global::党建信息管理系统LS.Properties.Resources._112;
            this.Button_PMBasic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_PMBasic.Name = "Button_PMBasic";
            this.Button_PMBasic.Size = new System.Drawing.Size(123, 24);
            this.Button_PMBasic.Text = "党员信息管理";
            this.Button_PMBasic.Click += new System.EventHandler(this.Button_PMBasic_Click);
            // 
            // Button_Find
            // 
            this.Button_Find.BackColor = System.Drawing.Color.White;
            this.Button_Find.ForeColor = System.Drawing.Color.Black;
            this.Button_Find.Image = global::党建信息管理系统LS.Properties.Resources._113;
            this.Button_Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(93, 24);
            this.Button_Find.Text = "信息查询";
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Button_BasicKonwledge
            // 
            this.Button_BasicKonwledge.BackColor = System.Drawing.Color.White;
            this.Button_BasicKonwledge.ForeColor = System.Drawing.Color.Black;
            this.Button_BasicKonwledge.Image = global::党建信息管理系统LS.Properties.Resources._111;
            this.Button_BasicKonwledge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_BasicKonwledge.Name = "Button_BasicKonwledge";
            this.Button_BasicKonwledge.Size = new System.Drawing.Size(93, 24);
            this.Button_BasicKonwledge.Text = "必备知识";
            this.Button_BasicKonwledge.Click += new System.EventHandler(this.Button_BasicKonwledge_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Button_AddressBook
            // 
            this.Button_AddressBook.BackColor = System.Drawing.Color.White;
            this.Button_AddressBook.ForeColor = System.Drawing.Color.Black;
            this.Button_AddressBook.Image = ((System.Drawing.Image)(resources.GetObject("Button_AddressBook.Image")));
            this.Button_AddressBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_AddressBook.Name = "Button_AddressBook";
            this.Button_AddressBook.Size = new System.Drawing.Size(78, 24);
            this.Button_AddressBook.Text = "通讯录";
            this.Button_AddressBook.Click += new System.EventHandler(this.Button_AddressBook_Click);
            // 
            // Button_DayWorkPad
            // 
            this.Button_DayWorkPad.BackColor = System.Drawing.Color.White;
            this.Button_DayWorkPad.ForeColor = System.Drawing.Color.Black;
            this.Button_DayWorkPad.Image = global::党建信息管理系统LS.Properties.Resources._105;
            this.Button_DayWorkPad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_DayWorkPad.Name = "Button_DayWorkPad";
            this.Button_DayWorkPad.Size = new System.Drawing.Size(93, 24);
            this.Button_DayWorkPad.Text = "日常记事";
            this.Button_DayWorkPad.Click += new System.EventHandler(this.Button_DayWorkPad_Click);
            // 
            // Button_ApplicationExit
            // 
            this.Button_ApplicationExit.BackColor = System.Drawing.Color.White;
            this.Button_ApplicationExit.ForeColor = System.Drawing.Color.Black;
            this.Button_ApplicationExit.Image = ((System.Drawing.Image)(resources.GetObject("Button_ApplicationExit.Image")));
            this.Button_ApplicationExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_ApplicationExit.Name = "Button_ApplicationExit";
            this.Button_ApplicationExit.Size = new System.Drawing.Size(93, 24);
            this.Button_ApplicationExit.Text = "退出系统";
            this.Button_ApplicationExit.Click += new System.EventHandler(this.Button_ApplicationExit_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.Indent = 18;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(0, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(167, 591);
            this.treeView1.TabIndex = 3;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu1;
        private System.Windows.Forms.ToolStripMenuItem PMBasic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClassData;
        private System.Windows.Forms.ToolStripMenuItem Menu2;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ToolStripMenuItem Statistic;
        private System.Windows.Forms.ToolStripMenuItem Menu3;
        private System.Windows.Forms.ToolStripMenuItem DayWorkPad;
        private System.Windows.Forms.ToolStripMenuItem Menu11;
        private System.Windows.Forms.ToolStripMenuItem AddressBook;
        private System.Windows.Forms.ToolStripMenuItem Menu4;
        private System.Windows.Forms.ToolStripMenuItem NoteBook;
        private System.Windows.Forms.ToolStripMenuItem Calculater;
        private System.Windows.Forms.ToolStripMenuItem Rota;
        private System.Windows.Forms.ToolStripMenuItem Menu6;
        private System.Windows.Forms.ToolStripMenuItem ReLogin;
        private System.Windows.Forms.ToolStripMenuItem UserSet;
        private System.Windows.Forms.ToolStripMenuItem Menu10;
        private System.Windows.Forms.ToolStripMenuItem Menu7;
        private System.Windows.Forms.ToolStripMenuItem Mprocess;
        private System.Windows.Forms.ToolStripMenuItem BasicKnowledge;
        private System.Windows.Forms.ToolStripMenuItem SumExperience;
        private System.Windows.Forms.ToolStripMenuItem Menu8;
        private System.Windows.Forms.ToolStripMenuItem Tool_Help;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton Button_PMBasic;
        private System.Windows.Forms.ToolStripButton Button_Find;
        private System.Windows.Forms.ToolStripButton Button_BasicKonwledge;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Button_AddressBook;
        private System.Windows.Forms.ToolStripButton Button_DayWorkPad;
        private System.Windows.Forms.ToolStripButton Button_ApplicationExit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Menu5;
        private System.Windows.Forms.ToolStripMenuItem BackupRestore;
        private System.Windows.Forms.ToolStripMenuItem ClearData;
        private System.Windows.Forms.ToolStripMenuItem BirthdayNotice;
        private System.Windows.Forms.ToolStripMenuItem RotaNotice;
        private System.Windows.Forms.ToolStripMenuItem Activist;
        private System.Windows.Forms.ToolStripMenuItem Menu9;
        private System.Windows.Forms.ToolStripMenuItem Tool_PTitleSort;
        private System.Windows.Forms.ToolStripMenuItem Tool_Grade;
        private System.Windows.Forms.ToolStripMenuItem Tool_Folk;
        private System.Windows.Forms.ToolStripMenuItem Tool_PartyBranch;
        private System.Windows.Forms.ToolStripMenuItem Tool_Class;
        private System.Windows.Forms.ToolStripMenuItem Tool_PadSort;
        private System.Windows.Forms.ToolStripMenuItem Tool_PBJSort;
        private System.Windows.Forms.ToolStripMenuItem Tool_MemberSort;
    }
}