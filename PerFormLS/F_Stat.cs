using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 党建信息管理系统LS.PerFormLS
{
    public partial class F_Stat : Form
    {
        public F_Stat()
        {
            InitializeComponent();
        }
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        public static DataSet MyDS_Grid;
        public string ARsign = " AND ";
        public static string Sut_SQL = "select * from PMBasic";
        public static string Term_Field = "民族,性别,身份类型,职称,支部,党内职务,年级";
        public static string Term_Value = "民族,性别,身份类型,职称,支部,党内职务,入学年级";
        public static string[] A_Field = Term_Field.Split(Convert.ToChar(','));
        public static string[] A_Value = Term_Value.Split(Convert.ToChar(','));

        public void Stat_Class(int n,string TableName)
        {
            MyDS_Grid = MyDataClass.getDataSet("select " + A_Field[n] + " as '" + A_Value[n] + "', count(" + A_Field[n] + ")  as '人数' from "+TableName+" group by " + A_Field[n], TableName);
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 80;
        }

        #region  清空控件集上的控件信息
        /// <summary>
        /// 清空GroupBox控件上的控件信息.
        /// </summary>
        /// <param name="n">控件个数</param>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        private void Clear_Box(int n, Control.ControlCollection GBox, string TName)
        {
            for (int i = 0; i < n; i++)
            {
                foreach (Control C in GBox)
                {
                    if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                        if (C.Name.IndexOf(TName) > -1)
                        {
                            C.Text = "";
                        }
                }
            }
        }
        #endregion

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请指定查询范围！", "信息提示", MessageBoxButtons.OK);
            else if (radioButton3.Checked == true)
            {
                Sut_SQL = "select count(*) from PMBasic";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "PMBasic");
                
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
               
                //当合同的起始日期和结束日期不为空时
                if (MyMC.Date_Format(Find1_INDate.Text) != "" && MyMC.Date_Format(Find2_INDate.Text) != "")
                {
                    if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                                  //用ARsign变量连接查询条件
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + ARsign;
                    //设置合同日期的查询条件
                    ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "入党时间>='" + Find1_INDate.Text + "' AND 入党时间<='" + Find2_INDate.Text + "')";
                }
                
                if (FinAge.Text != "")
                {
                    if (ModuleClassLS.ModuleLS.FindValue != "")
                    ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + ARsign;
                    if (Age_Sign.Text != "")
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "FLOOR(datediff(DY,出生日期,getdate())/365.25)" + Age_Sign.Text + FinAge.Text + ")";
                    else
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "FLOOR(datediff(DY,出生日期,getdate())/365.25)=" + FinAge.Text + ")";

                }
                if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                              //将查询条件添加到SQL语句的尾部
                    Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
                //MyDS_Grid = new DataSet();
                //MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "PMBasic");
                //在dataGridView1控件是显示查询的结果
                SqlCommand mycmd = new SqlCommand();
                DataClassLS.MeansLS.getcon();
                mycmd = new SqlCommand(Find_SQL, DataClassLS.MeansLS.My_con);
                textBox1.Text = mycmd.ExecuteScalar().ToString();
                DataClassLS.MeansLS.My_con.Close();
            }
            else if (radioButton4.Checked == true)
            {
                Sut_SQL = "select count(*) from Activist";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "Activist");
                
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
               
                //当合同的起始日期和结束日期不为空时

                if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                              //将查询条件添加到SQL语句的尾部
                    Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
                // MyDS_Grid = new DataSet();
                //MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "Activist");
                //在dataGridView1控件是显示查询的结果
                SqlCommand mycmd = new SqlCommand();
                DataClassLS.MeansLS.getcon();
                mycmd = new SqlCommand(Find_SQL, DataClassLS.MeansLS.My_con);
                textBox1.Text = mycmd.ExecuteScalar().ToString();
                DataClassLS.MeansLS.My_con.Close();


            }
            else if (radioButton5.Checked == true)
            {
                Sut_SQL = "select count(*) from ClassData";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "ClassData");
                
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
        
                //当合同的起始日期和结束日期不为空时

                if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                              //将查询条件添加到SQL语句的尾部
                    Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
                //MyDS_Grid = new DataSet();
                //MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "ClassData");
                //在dataGridView1控件是显示查询的结果

                SqlCommand mycmd = new SqlCommand();
                DataClassLS.MeansLS.getcon();
                mycmd = new SqlCommand(Find_SQL, DataClassLS.MeansLS.My_con);
                textBox1.Text = mycmd.ExecuteScalar().ToString();
                DataClassLS.MeansLS.My_con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_Box(30, groupBox2.Controls, "Fin");
            Clear_Box(4, groupBox2.Controls, "Sign");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 根据选定的统计范围调节组合查询输入控件是否可用
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_英语过级.Enabled = true;
            Find_职称.Enabled = true;
            Find_支部.Enabled = true;
            Find_党内职务.Enabled = true;
            Find1_INDate.Enabled = true;
            Find2_INDate.Enabled = true;
            Find_身份类型.Enabled = true;
            radioButton2.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton9.Enabled = true;
            radioButton8.Enabled = true;
            if (radioButton1.Checked != false)
                radioButton1_CheckedChanged(sender, e);
            else if (radioButton2.Checked != false)
                radioButton2_CheckedChanged(sender, e);
            else if (radioButton6.Checked != false)
                radioButton6_CheckedChanged(sender, e) ;
            else if (radioButton7.Checked != false)
                radioButton7_CheckedChanged(sender, e) ;
            else if (radioButton8.Checked != false)
                radioButton8_CheckedChanged(sender, e);
            else if (radioButton9.Checked != false)
                radioButton9_CheckedChanged(sender, e) ;
            else if (radioButton10.Checked != false)
                radioButton10_CheckedChanged(sender, e);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_英语过级.Enabled = false;
            Find_职称.Enabled = false;
            Find_支部.Enabled = false;
            Find_党内职务.Enabled = false;
            Find1_INDate.Enabled = false;
            Find2_INDate.Enabled = false;
            Find_身份类型.Enabled = false;
            radioButton2.Enabled = false;
            radioButton7.Enabled = true;
            radioButton9.Enabled = false;
            radioButton8.Enabled = false;
            radioButton6.Enabled = true;
            if (radioButton1.Checked != false)
                radioButton1_CheckedChanged(sender, e);
            else if (radioButton6.Checked != false)
                radioButton6_CheckedChanged(sender, e);
            else if (radioButton7.Checked != false)
                radioButton7_CheckedChanged(sender, e);
            else if (radioButton10.Checked != false)
                radioButton10_CheckedChanged(sender, e);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_英语过级.Enabled = false;
            Find_职称.Enabled = false;
            Find_支部.Enabled = false;
            Find_党内职务.Enabled = false;
            Find1_INDate.Enabled = false;
            Find2_INDate.Enabled = false;
            Find_身份类型.Enabled = false;
            radioButton2.Enabled = false;
            radioButton7.Enabled = false;
            radioButton9.Enabled = false;
            radioButton8.Enabled = false;
            radioButton6.Enabled = false;
            if (radioButton1.Checked != false)
                radioButton1_CheckedChanged(sender, e);
            else if (radioButton10.Checked != false)
                radioButton10_CheckedChanged(sender, e);
        }
        #endregion
        private void F_Stat_Load(object sender, EventArgs e)
        {
            MyMC.CoPassData(Find_民族, "Folk");  //向“民族类别”列表框中添加信息
            MyMC.CoPassData(Find_支部, "PartyBranch");  //向"文化程度”列表框中添加信息
            MyMC.CoPassData(Find_年级, "Grade");  //向"正治面貌”列表框中添加信息
            MyMC.CoPassData(Find_身份类型, "Persort");  //向"职工类别”列表框中添加信息
            MyMC.CoPassData(Find_党内职务, "PBJSort");  //向"职务类别”列表框中添加信息
            MyMC.CoPassData(Find_职称, "PTitleSort");  //向"工资类别”列表框中添加信息
            MyMC.CoPassData(Find_专业班级, "ClassData");  //向"部门类别”列表框中添加信息
            MyMC.MaskedTextBox_Format(Find1_INDate);  //指定MaskedTextBox控件的格式
            MyMC.MaskedTextBox_Format(Find2_INDate);
            radioButton3.Checked = true;
        }
        #region 根据基本条件输出分类统计结果
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if(radioButton3.Checked==true)
                Stat_Class(1,"PMBasic");
            else if(radioButton4.Checked == true)
                Stat_Class(1, "Activist");
            else
                Stat_Class(1, "ClassData");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if(radioButton3.Checked==true)
                Stat_Class(5,"PMBasic");
            //else if(radioButton4.Checked == true)
                //Stat_Class(5, "Activist");
            //else
                //Stat_Class(5, "ClassData");
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if (radioButton3.Checked == true)
                Stat_Class(0, "PMBasic");
            else if (radioButton4.Checked == true)
                Stat_Class(0, "Activist");
            else
                Stat_Class(0, "ClassData");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if (radioButton3.Checked == true)
                Stat_Class(4, "PMBasic");
            else if (radioButton4.Checked == true)
                Stat_Class(4, "Activist");
            else
                Stat_Class(4, "ClassData");
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if (radioButton3.Checked == true)
                Stat_Class(3, "PMBasic");
            //else if (radioButton4.Checked == true)
                //Stat_Class(3, "Activist");
           // else
               // Stat_Class(3, "ClassData");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if (radioButton3.Checked == true)
                Stat_Class(2, "PMBasic");
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请先指定统计范围！", "信息提示", MessageBoxButtons.OK);
            else if(radioButton3.Checked==true)
                Stat_Class(6,"PMBasic");
            else if(radioButton4.Checked ==true)
                Stat_Class(6, "Activist");
            else
                Stat_Class(6, "ClassData");
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
