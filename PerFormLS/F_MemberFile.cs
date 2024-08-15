using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;


namespace 党建信息管理系统LS.PerFormLS
{
    public partial class F_MemberFile : Form
    {
        public F_MemberFile()
        {
            InitializeComponent();
        }
        #region  当前窗体的所有共公变量
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        public static DataSet MyDS_Grid;
        public static string tem_Field = "";
        public static string tem_Value = "";
        public static string tem_ID = "";
        public static int hold_n = 0;
        public static byte[] imgBytesIn;  //用来存储图片的二进制数
        public static int Ima_n = 0;  //判断是否对图片进行了操作
        public static string Part_ID = "";  //存储数据表的ID信息

        #endregion

        public void ShowData_Image(byte[] DI, PictureBox Ima)  //显示数据库图片
        {
            byte[] buffer = DI;
            MemoryStream ms = new MemoryStream(buffer);
            Ima.Image = Image.FromStream(ms);
        }

        #region 定义函数根据生日计算年龄
        public int Getage(DateTime birthday)//根据生日计算年龄
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;
            if (now.Month < birthday.Month || (now.Month == birthday.Month) && (now.Day < birthday.Day))
                age--;
            return age < 0 ? 0 : age;
        }
        #endregion
        public int Yearfull(DateTime d1,DateTime d2)//计算是否满一年
        {
            int age = d1.Year - d2.Year;
            if (d1.Month < d2.Month || (d1.Month == d2.Month) && (d1.Day < d2.Day))
                age--;
            return age < 0 ? 0 : age;
        }
        #region  显示“党员基本信息”表中的指定记录
        /// <summary>
        /// 动态读取指定的记录行，并进行显示.
        /// </summary>
        /// <param name="DGrid">DataGridView控件</param>
        /// <returns>返回string对象</returns> 
        public string Grid_Inof(DataGridView DGrid)
        {
            byte[] pic; //定义一个字节数组
            //当DataGridView控件的记录>1时，将当前行中信息显示在相应的控件上
            if (DGrid.RowCount >0)
            {
                textBox17.Text= DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_0.Text = DGrid[0, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_1.Text = DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();
                comboBox21.Text= DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_2.Text = DGrid[2, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_3.Text = DGrid[3, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_4.Text = DGrid[4, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_5.Text = DGrid[5, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_6.Text = DGrid[6, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_7.Text = DGrid[7, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_8.Text = DGrid[8, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_22.Text = DGrid[22, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_9.Text = DGrid[9, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_10.Text = DGrid[10, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_11.Text = MyMC.Date_Format(Convert.ToString(DGrid[11, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_12.Text = DGrid[12, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_13.Text= MyMC.Date_Format(Convert.ToString(DGrid[13, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_14.Text = MyMC.Date_Format(Convert.ToString(DGrid[14, DGrid.CurrentCell.RowIndex].Value).Trim());
                S_15.Text= DGrid[15, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_16.Text = DGrid[16, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_17.Text = DGrid[17, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_18.Text = DGrid[18, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_19.Text = DGrid[19, DGrid.CurrentCell.RowIndex].Value.ToString();
                comboBox22.Text= DGrid[20, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_20.Text= DGrid[20, DGrid.CurrentCell.RowIndex].Value.ToString();
                S_21.Text = DGrid[21, DGrid.CurrentCell.RowIndex].Value.ToString();
               
                b_age.Text = Getage(Convert.ToDateTime(DGrid[11, DGrid.CurrentCell.RowIndex].Value)).ToString();
                DGrid.AllowUserToAddRows = false;
                try
                {
                    //将数据库中的图片存入到字节数组中
                    pic = (byte[])(MyDS_Grid.Tables[0].Rows[DGrid.CurrentCell.RowIndex][23]);
                    MemoryStream ms = new MemoryStream(pic);			//将字节数组存入到二进制流中
                    b_Photo.Image = Image.FromStream(ms);   //二进制流Image控件中显示
                }
                catch { b_Photo.Image = null; } //当出现错误时，将Image控件清空
                tem_ID = S_0.Text.Trim();   //获取当前党员编号
                return DGrid[1, DGrid.CurrentCell.RowIndex].Value.ToString();   //返回当前党员的姓名
            }
            else
            {
                //使用MyMeans公共类中的Clear_Control()方法清空指定控件集中的相应控件
                MyMC.Clear_Control(tabControl1.TabPages[0].Controls);
                tem_ID = "";
                return "";
            }
        }
        #endregion

        #region  按条件显示“党员基本信息”表的内容
        /// <summary>
        /// 通过公共变量动态进行查询.
        /// </summary>
        /// <param name="C_Value">条件值</param>
        public void Condition_Lookup(string C_Value)
        {
            MyDS_Grid = MyDataClass.getDataSet("Select * from PMBasic where " + tem_Field + "='" + tem_Value + "'", "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            textBox1.Text = Grid_Inof(dataGridView1);  //显示党员信息表的当前记录            
        }
        #endregion

        #region  将图片转换成字节数组
        public void Read_Image(OpenFileDialog openF, PictureBox MyImage)
        {
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";   //指定OpenFileDialog控件打开的文件格式
            if (openF.ShowDialog(this) == DialogResult.OK)  //如果打开了图片文件
            {
                try
                {
                    MyImage.Image = System.Drawing.Image.FromFile(openF.FileName);  //将图片文件存入到PictureBox控件中
                    string strimg = openF.FileName.ToString();  //记录图片的所在路径
                    FileStream fs = new FileStream(strimg, FileMode.Open, FileAccess.Read); //将图片以文件流的形式进行保存
                    BinaryReader br = new BinaryReader(fs);
                    imgBytesIn = br.ReadBytes((int)fs.Length);  //将流读入到字节数组中
                }
                catch
                {
                    MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    b_Photo.Image = null;
                }
            }
        }
        #endregion
        private void F_MemberFile_Load(object sender, EventArgs e)
        {
            // 用dataGridView1控件显示职工的名称
            //string ql = "select * from Activist";
            MyDS_Grid = MyDataClass.getDataSet("Select * from PMBasic", "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;

            for (int i = 2; i < dataGridView1.ColumnCount; i++)  //隐藏dataGridView1控件中不需要的列字段
            {
                dataGridView1.Columns[i].Visible = false;
            }
            MyMC.MaskedTextBox_Format(S_11);  //指定MaskedTextBox控件的格式
            MyMC.MaskedTextBox_Format(S_13);
            MyMC.MaskedTextBox_Format(S_14);

            MyMC.CoPassData(S_3, "Folk");  //向“民族类别”列表框中添加信息
            MyMC.CoPassData(S_20, "PartyBranch");  //向"支部类别”列表框中添加信息
            MyMC.CoPassData(S_22, "PBJSort");  //向"党内职务”列表框中添加信息
            MyMC.CoPassData(S_5, "Persort");  //向"党内职务”列表框中添加信息
            MyMC.CoPassData(S_7, "MemberSort");  //向"党内职务”列表框中添加信息
            MyMC.CoPassData(S_21, "Grade");
            MyMC.CoPassData(S_8, "PTitleSort");
            //S_23.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  //使S_BeAware控件具有查询功能
            //S_23.AutoCompleteSource = AutoCompleteSource.ListItems;
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的首记录
            DataClassLS.MeansLS.AllSql = "Select * from PMBasic ";
        }

        private void Sut_Add_Click(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToAddRows = true;
            S_1.Enabled = true;
            MyMC.Clear_Control(tabControl1.TabPages[0].Controls);   //清空党员基本信息的相应文本框
            MyMC.Clear_Control(tabControl1.TabPages[1].Controls);   //清空党员基本信息的相应文本框
            textBox17.Text = "";
            comboBox21.Text = "";
            comboBox22.Text = "";
            S_0.Text=MyMC.GetAutocoding("PMBasic", "编号");  //自动添加编号
            hold_n = 1;  //用于记录添加操作的标识
            MyMC.Ena_Button(Sut_Add, Sut_Amend, Sut_Cancel, Sut_Save, 0, 0, 1, 1);
            groupBox5.Text = "当前正在添加信息";
            button2.Enabled = true;   //使图片选择按钮为可用状态
            button3.Enabled = true;
            dataGridView1.Enabled = false;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            /*groupBox5.Enabled = true;
            Sut_Delete.Enabled = true;
            MyMC.Ena_Button(Sut_Add, Sut_Amend, Sut_Cancel, Sut_Save, 1, 1, 0, 0);
            hold_n = 0;  //恢复原始标识
            MyMC.Ena_Button(Sut_Add, Sut_Amend, Sut_Cancel, Sut_Save, 1, 1, 0, 0);  //
            groupBox5.Text = "";
            Ima_n = 0;//标识是否选择了照片
            button2.Enabled = false;  //使按钮为不可用状态
            button3.Enabled = false;
            Sub_Table.Enabled = true;*/
        }
        #region 根据组合框1中的内容为组合框2添加信息
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)  //向comboBox2控件中添加相应的查询条件
            {
                case 0:
                    {
                        MyMC.CityInfo(comboBox2, "select distinct 姓名 from PMBasic", 0);  //姓名
                        tem_Field = "姓名";
                        break;
                    }
                case 1:  //性别
                    {
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("男");
                        comboBox2.Items.Add("女");
                        tem_Field = "性别";
                        break;

                    }
                case 2:
                    {
                        MyMC.CoPassData(comboBox2, "Folk");  //民族类别
                        tem_Field = "民族";
                        break;
                    }
                case 3:
                    {
                        MyMC.CoPassData(comboBox2, "Grade");  //入学年级
                        tem_Field = "年级";
                        break;
                    }
                case 4:
                    {
                        MyMC.CoPassData(comboBox2, "PartyBranch");  //支部类别
                        tem_Field = "支部";
                        break;
                    }
                case 5:
                    {
                        MyMC.CoPassData(comboBox2, "PBJSort");  //党内职务类别
                        tem_Field = "党内职务";
                        break;
                    }
                case 6:
                    {
                        MyMC.CoPassData(comboBox2, "MemberSort");  //职务类别
                        tem_Field = "职务";
                        break;
                    }
                case 7:
                    {
                        MyMC.CoPassData(comboBox2, "PTitleSort");  //职称类别
                        tem_Field = "职称";
                        break;
                    }
            }

        }
        #endregion

        #region 按钮上一个、下一个、、单击事件
        private void N_First_Click(object sender, EventArgs e)
        {
            int ColInd = 0;
            if (dataGridView1.CurrentCell.ColumnIndex == -1 || dataGridView1.CurrentCell.ColumnIndex > 1)
                ColInd = 0;
            else
                ColInd = dataGridView1.CurrentCell.ColumnIndex;
            if ((((Button)sender).Name) == "N_First")
            {
                dataGridView1.CurrentCell = this.dataGridView1[ColInd, 0];
                MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 0, 0, 1, 1);
            }
            if ((((Button)sender).Name) == "N_Previous")
            {
                if (dataGridView1.CurrentCell.RowIndex == 0)
                {
                    MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 0, 0, 1, 1);
                }
                else
                {
                    dataGridView1.CurrentCell = this.dataGridView1[ColInd, dataGridView1.CurrentCell.RowIndex - 1];
                    MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 1, 1, 1, 1);
                }
            }
            if ((((Button)sender).Name) == "N_Next")
            {
                if (dataGridView1.CurrentCell.RowIndex == dataGridView1.RowCount - 1)
                {
                    MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 1, 1, 0, 0);
                }
                else
                {
                    dataGridView1.CurrentCell = this.dataGridView1[ColInd, dataGridView1.CurrentCell.RowIndex + 1];
                    MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 1, 1, 1, 1);
                }
            }
            if ((((Button)sender).Name) == "N_Cauda")
            {
                dataGridView1.CurrentCell = this.dataGridView1[ColInd, dataGridView1.RowCount - 1];
                MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 1, 1, 0, 0);
            }

        }

        private void N_Previous_Click(object sender, EventArgs e)
        {
            N_First_Click(sender, e);
        }

        private void N_Next_Click(object sender, EventArgs e)
        {
            N_First_Click(sender, e);
        }

        private void N_Cauda_Click(object sender, EventArgs e)
        {
            N_First_Click(sender, e);
        }
        #endregion
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)///////////
        {
            try
            {
                if (dataGridView1.CurrentCell.RowIndex > -1)
                {
                    textBox1.Text = Grid_Inof(dataGridView1);  //显示党员信息表的当前记录
                    MyMC.Ena_Button(N_First, N_Previous, N_Next, N_Cauda, 1, 1, 1, 1);  //使窗体中的编辑按钮可用
                    //MyMC.Show_DGrid(dataGridView2, groupBox7.Controls, "Word_");
                }
            }
            catch { }
        }
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tem_Value = comboBox2.SelectedItem.ToString();
                Condition_Lookup(tem_Value);
               
            }
            catch
            {
                comboBox2.Text = "";
                //MessageBox.Show("只能以选择方式查询。", "提示", MessageBoxButtons.OK);待修改
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tem_Field = "";
            MyDS_Grid = MyDataClass.getDataSet(DataClassLS.MeansLS.AllSql, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的当前记录
        }
        private void Sut_Amend_Click(object sender, EventArgs e)
        {
            hold_n = 2;  //用于记录修改操作的标识
            MyMC.Ena_Button(Sut_Add, Sut_Amend, Sut_Cancel, Sut_Save, 0, 0, 1, 1);
            groupBox5.Text = "当前正在修改信息";
            button2.Enabled = true;   //使图片选择按钮为可用状态
            button3.Enabled = true;
        }
        private void Sut_Cancel_Click(object sender, EventArgs e)
        {
            hold_n = 0;  //恢复原始标识
            MyMC.Ena_Button(Sut_Add, Sut_Amend, Sut_Cancel, Sut_Save, 1, 1, 0, 0);
            groupBox5.Text = "";
            Ima_n = 0;
            if (tem_Field == "")
                button1_Click(sender, e);
            else
                Condition_Lookup(tem_Value);
            button2.Enabled = false;
            button3.Enabled = false;
            dataGridView1.Enabled = true;
        }
        private void Sut_Save_Click(object sender, EventArgs e)
        {
            //定义字符串变量，并存储将“党员基本信息表”中的所有字段
            string All_Field = "编号,姓名,性别,民族,身份证号,身份类型,专业班级,职务,职称,联系电话,籍贯,出生日期,申请时间,入党时间,转正时间,介绍人或联系人,中级党校时间,英语过级,计算机等级,获奖情况,支部,年级,党内职务";
            try
            {
                if (hold_n == 1 || hold_n == 2) //判断当前是添加，还是修改操作
                {
                    ModuleClassLS.ModuleLS.ADDs = ""; //清空Module公共类中的ADDs变量
                                                      //用Module公共类中的Part_SaveClass()方法组合添加或修改的SQL语句
                    MyMC.Part_SaveClass(All_Field, S_0.Text.Trim(), tabControl1.TabPages[0].Controls,groupBox6.Controls, groupBox7.Controls, "S_", "PMBasic", 30, hold_n);
                    //如果ADDs变量不为空，则通过Means公共类中的getsqlcom()方法执行添加、修改操作
                    if (ModuleClassLS.ModuleLS.ADDs != "")
                        MyDataClass.getsqlcom(ModuleClassLS.ModuleLS.ADDs);
                }
                if (Ima_n > 0)  //如果图片标识大于0
                {
                    //通过Module公共类中r的SaveImage()方法将图片存入数据库中
                    MyMC.SaveImage(S_0.Text.Trim(), imgBytesIn);
                }
                Sut_Cancel_Click(sender, e);    //调用“取消”按钮的单击事件
            }

            catch
            {
                MessageBox.Show("请输入正确的职工信息！");
            }
            dataGridView1.Enabled = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Read_Image(openFileDialog1, b_Photo);
            Ima_n = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            b_Photo.Image = null;
            imgBytesIn = new byte[65536];
            Ima_n = 2;
        }
        private void Sut_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 2) //判断dataGridView1控件中是否有记录
            {
                MessageBox.Show("数据表为空，不可以删除。");
                return;
            }
            //删除信息表中的当前记录，及其他相关表中的信息
            MyDataClass.getsqlcom("Delete PMBasic where 编号='" + S_0.Text.Trim() + "'");
            //DataClass.getsqlcom("Delete tb_WordResume where ID='" + no.Trim().Trim() + "'");级联删除联系人，待完善
            Sut_Cancel_Click(sender, e);    //调用“取消”按钮的单击事件
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_All_Click(object sender, EventArgs e)
        {
            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(DataClassLS.MeansLS.AllSql, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的当前记录

            for (int i = 2; i < dataGridView1.ColumnCount; i++)  //隐藏dataGridView1控件中不需要的列字段
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            //用dataGridView1控件显示职工的名称
            string sql = "Select * from PMBasic where 身份类型='本科生'";
            MyDS_Grid = MyDataClass.getDataSet(sql, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width =100;
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的当前记录

            for (int i = 2; i < dataGridView1.ColumnCount; i++)  //隐藏dataGridView1控件中不需要的列字段
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void button_y_Click(object sender, EventArgs e)
        {
            //用dataGridView1控件显示职工的名称
            string sql = "Select * from PMBasic where 身份类型='研究生'";
            MyDS_Grid = MyDataClass.getDataSet(sql, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的当前记录

            for (int i = 2; i < dataGridView1.ColumnCount; i++)  //隐藏dataGridView1控件中不需要的列字段
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void button_j_Click(object sender, EventArgs e)
        {
            //用dataGridView1控件显示职工的名称
            string sql = "Select * from PMBasic where 身份类型 not in('本科生','研究生')";
            MyDS_Grid = MyDataClass.getDataSet(sql, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            textBox1.Text = Grid_Inof(dataGridView1);  //显示职工信息表的当前记录

            for (int i = 2; i < dataGridView1.ColumnCount; i++)  //隐藏dataGridView1控件中不需要的列字段
            {
                dataGridView1.Columns[i].Visible = false;
            }
        }

        private void S_5_TextChanged(object sender, EventArgs e)
        {
            if(S_5.Text.Trim()=="本科生"||S_5.Text.Trim()=="研究生")
            {
                S_8.Enabled = false;
                S_21.Enabled = true;
                S_12.Enabled = true;
                S_7.Enabled = true;
                S_4.Enabled = true;
                S_15.Enabled = true;
                S_16.Enabled = true;
            }
            else
            {
                S_8.Enabled = true;
                S_21.Enabled = false;
                S_12.Enabled = false;
                S_7.Enabled = false;
                S_4.Enabled = false;
                S_15.Enabled = false;
                S_16.Enabled = false;
            }
        }

        private void S_14_TextChanged(object sender, EventArgs e)
        {
            if (S_13.Text != "" &&S_14.Text!="")
            { 
               // if( Yearfull(Convert.ToDateTime(S_14.Text), Convert.ToDateTime(S_13.Text)) < 1)
                //{ 
                //    MessageBox.Show("入党满一年方可发展！", "信息提示");待完善
                //    S_13.Text = "";
              //  }
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (Sut_Save.Enabled == true)
            {
                if (MessageBox.Show("是否保存修改内容", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Sut_Save_Click(sender, e);
                else
                    Sut_Cancel_Click(sender, e);
            }
        }

        private void S_1_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = S_1.Text;
        }

        private void S_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox21.Text = S_2.Text;
        }

        private void S_20_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox22.Text = S_20.Text;
        }

        private void Sub_Table_Click(object sender, EventArgs e)
        {
            MyMC.print(dataGridView1);
        }
        #region 输入回车键换到下一个
        private void S_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_5.Focus();
        }

        private void S_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')              
            if(S_21.Enabled == true)
                    S_21.Focus();
            else
                    S_3.Focus();
        }

        private void S_21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_3.Focus();
        }
    

        private void S_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' )
                if (S_12.Enabled == true)
                    S_12.Focus();
                else
                    S_11.Focus();
        }

        private void S_12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_11.Focus();
        }

        private void S_11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_13.Focus();
        }

        private void S_13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_10.Focus();
        }

        private void S_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_2.Focus();
        }

        private void S_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_22.Focus();
        }

        private void S_22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' )
                if (S_6.Enabled == true)
                    S_6.Focus();
                else
                    S_14.Focus();
        }

        private void S_6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_14.Focus();
        }

        private void S_14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                if (S_8.Enabled == true)
                    S_8.Focus();
                else
                    S_20.Focus();
        }

        private void S_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_20.Focus();
        }

        private void S_20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_9.Focus();
        }

        private void S_9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                if (S_7.Enabled == true)
                    S_7.Focus();
                else
                    S_4.Focus();
        }

        private void S_7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_4.Focus();
        }

        private void S_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                if (S_15.Enabled == true)
                    S_15.Focus();
                else if(S_16.Enabled == true)
                    S_16.Focus();
        }

        private void S_15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_16.Focus();
        }

        private void S_16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_17.Focus();
        }

        private void S_17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                S_18.Focus();
        }

        private void S_18_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion
    }
    
}
