using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 党建信息管理系统LS.PerFormLS
{
    public partial class F_Find : Form
    {
        public F_Find()
        {
            InitializeComponent();
        }
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        public static DataSet MyDS_Grid;
        public string ARsign = " AND ";
        public static string Sut_SQL = "select * from PMBasic";

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

        private void F_Find_Load(object sender, EventArgs e)
        {
            MyMC.CoPassData(Find_民族, "Folk");  //向“民族类别”列表框中添加信息
            MyMC.CoPassData(Find_支部, "PartyBranch");  //向"文化程度”列表框中添加信息
            MyMC.CoPassData(Find_年级, "Grade");  //向"年级”列表框中添加信息
            MyMC.CoPassData(Find_身份类型, "Persort");  //向"身份类别”列表框中添加信息
            MyMC.CoPassData(Find_党内职务, "PBJSort");  //向"职务类别”列表框中添加信息
            MyMC.CoPassData(Find_职称, "PTitleSort");  //向"职称”列表框中添加信息
            MyMC.CoPassData(Find_专业班级, "Class");  //向"专业班级”列表框中添加信息
            MyMC.MaskedTextBox_Format(Find1_INDate);  //指定MaskedTextBox控件的格式
            MyMC.MaskedTextBox_Format(Find2_INDate);
            //根据SQL语句进行查询
            MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "PMBasic");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            radioButton3.Checked = true;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " AND ";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ARsign = " OR ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked != true && radioButton4.Checked != true && radioButton5.Checked != true)
                MessageBox.Show("请指定查询范围！", "信息提示", MessageBoxButtons.OK);
            else if(radioButton3.Checked == true)
            {
                Sut_SQL = "select * from PMBasic";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "PMBasic");
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                    string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                    MyMC.Find_Grids(groupBox1.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
                    MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);
                    //当合同的起始日期和结束日期不为空时
                    if (MyMC.Date_Format(Find1_INDate.Text) != "" && MyMC.Date_Format(Find2_INDate.Text) != "")
                    {
                        if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                            //用ARsign变量连接查询条件
                            ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + ARsign;
                        //设置合同日期的查询条件
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "入党时间>='" + Find1_INDate.Text + "' AND 入党时间<='" + Find2_INDate.Text + "')";
                    }
                    
                    if(FinAge.Text!="")
                    {
                    if (ModuleClassLS.ModuleLS.FindValue != "")
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + ARsign;
                    if (Age_Sign.Text != "")
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "FLOOR(datediff(DY,出生日期,getdate())/365.25)" + Age_Sign.Text + FinAge.Text+")";
                    else
                        ModuleClassLS.ModuleLS.FindValue = ModuleClassLS.ModuleLS.FindValue + "(" + "FLOOR(datediff(DY,出生日期,getdate())/365.25)="  + FinAge.Text + ")";

                    }
                    if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                        //将查询条件添加到SQL语句的尾部
                        Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
                //MyDS_Grid = new DataSet();
                MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "PMBasic");
                    //在dataGridView1控件是显示查询的结果
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                checkBox1.Checked = false;
            }
            else if(radioButton4.Checked==true)
            {
                Sut_SQL = "select * from Activist";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "Activist");
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                MyMC.Find_Grids(groupBox1.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
                MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);
                //当合同的起始日期和结束日期不为空时
                
                if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                              //将查询条件添加到SQL语句的尾部
                    Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
               // MyDS_Grid = new DataSet();
                MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "Activist");
                //在dataGridView1控件是显示查询的结果
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                checkBox1.Checked = false;
            }
            else if(radioButton5.Checked==true)
            {
                Sut_SQL = "select * from ClassData";
                MyDS_Grid = MyDataClass.getDataSet(Sut_SQL, "ClassData");
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                ModuleClassLS.ModuleLS.FindValue = "";    //清空存储查询语句的变量
                string Find_SQL = Sut_SQL;  //存储显示数据表中所有信息的SQL语句
                MyMC.Find_Grids(groupBox1.Controls, "Find", ARsign);    //将指定控件集下的控件组合成查询条件
                MyMC.Find_Grids(groupBox2.Controls, "Find", ARsign);
                //当合同的起始日期和结束日期不为空时
            
                if (ModuleClassLS.ModuleLS.FindValue != "")   //如果FindValue字段不为空
                                                              //将查询条件添加到SQL语句的尾部
                    Find_SQL = Find_SQL + " where " + ModuleClassLS.ModuleLS.FindValue;
                //按照指定的条件进行查询
                //MyDS_Grid = new DataSet();
                MyDS_Grid = MyDataClass.getDataSet(Find_SQL, "ClassData");
                //在dataGridView1控件是显示查询的结果
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
                dataGridView1.AutoGenerateColumns = true;
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_Box(7, groupBox1.Controls, "Find_");
            Clear_Box(12, groupBox2.Controls, "Fin");
            Clear_Box(4, groupBox2.Controls, "Sign");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_学号.Enabled = false;
            Find_英语过级.Enabled = true;
           // Find_学号.Enabled = false;
            Find_职称.Enabled = true;
            Find_支部.Enabled = true;
            Find_党内职务.Enabled = true;
            Find1_INDate.Enabled = true;
            Find2_INDate.Enabled = true;
            Find_身份类型.Enabled = true;
            Find_身份证号.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_英语过级.Enabled = false;
            Find_学号.Enabled = false;
            Find_职称.Enabled = false;
            Find_支部.Enabled = false;
            Find_党内职务.Enabled = false;
            Find1_INDate.Enabled = false;
            Find2_INDate.Enabled = false;
            Find_身份类型.Enabled = false;
            Find_身份证号.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox1.Controls);
            MyMC.Clear_Control(groupBox2.Controls);
            Find_英语过级.Enabled = false;
            Find_学号.Enabled = true;
            Find_职称.Enabled = false;
            Find_支部.Enabled = false;
            Find_党内职务.Enabled = false;
            Find1_INDate.Enabled = false;
            Find2_INDate.Enabled = false;
            Find_身份类型.Enabled = false;
            Find_身份证号.Enabled = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
