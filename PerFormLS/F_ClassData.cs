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
    public partial class F_ClassData : Form
    {
        public F_ClassData()
        {
            InitializeComponent();
        }
        public static string RotaName;
        public static string tem_Field = "";
        public static string tem_Value = "";
        public static string ClassDataName;
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        DataSet MyDS_Grid = new DataSet();
        SqlDataAdapter myda = new SqlDataAdapter();
        public static string connstring = DataClassLS.MeansLS.M_str_sqlcon;
        SqlConnection mycon = new SqlConnection();
        #region 根据数据表中班级信息自动生成TreeView节点
        public void PassData(TreeView treeV, string TableName1, string TableName2)
        {
            treeV.Nodes.Clear();
            DataClassLS.MeansLS MyDataClsaa = new DataClassLS.MeansLS();
            SqlDataReader MyDR = MyDataClsaa.getcom("select * from " + TableName1);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    TreeNode tree1;
                    if (MyDR[1].ToString() != "" && MyDR[1].ToString() != null)
                    {
                        tree1 = treeV.Nodes.Add(MyDR[1].ToString());
                        string[] str = tree1.Text.Split(Convert.ToChar('级'));
                        DataClassLS.MeansLS DataClsaa = new DataClassLS.MeansLS();
                        SqlDataReader MDR = DataClsaa.getcom("select * from " + TableName2);
                        if (MDR.HasRows)
                        {
                            while (MDR.Read())
                            {
                                if (MDR[1].ToString() != "" && MDR[1].ToString() != null)
                                    if (MDR[1].ToString().IndexOf(str[0]) > -1)
                                        tree1.Nodes.Add(MDR[1].ToString());
                            }
                        }
                    }
                }
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
            MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData where " + tem_Field + "='" + tem_Value + "'", "ClassData");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            //textBox1.Text = Grid_Inof(dataGridView1);  //显示党员信息表的当前记录            
        }
        #endregion
        private void F_ClassData_Load(object sender, EventArgs e)
        {
            PassData(treeView1, "Grade", "Class");
            mycon.ConnectionString = connstring;
            mycon.Open();
            myda = new SqlDataAdapter("select * from ClassData", mycon);
            myda.Fill(MyDS_Grid, "ClassData");
            dataGridView1.DataSource = MyDS_Grid.Tables["ClassData"];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            mycon.Close();
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)  //向comboBox2控件中添加相应的查询条件
            {
                case 0:
                    {
                        MyMC.CoPassData(comboBox2, "Grade");  //文化程度
                        tem_Field = "年级";
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
                        //MyMC.CoPassData(comboBox2, "Folk");  //民族类别
                        tem_Field = "姓名";
                        break;
                    }
                case 3:
                    {
                       //MyMC.CoPassData(comboBox2, "Grade");  //文化程度
                        tem_Field = "学号";
                        break;
                    }
                case 4:
                    {
                        comboBox2.Items.Clear();
                        comboBox2.Items.Add("是");
                        comboBox2.Items.Add("否");
                        tem_Field = "入党申请时间";
                        break;
                    }
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" ||comboBox2.Text == "")
                MessageBox.Show("请将查询条件输入完整", "信息提示");
            else
            {
                if (comboBox1.Text == "按是否递交入党申请书查询")
                {
                    if (comboBox2.Text == "是")
                    {
                        MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData where 入党申请时间 is not null", "ClassData");
                        dataGridView1.DataSource = MyDS_Grid.Tables[0];
                    }
                    else if (comboBox2.Text == "否")
                    {
                        MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData where 入党申请时间 is null", "ClassData");
                        dataGridView1.DataSource = MyDS_Grid.Tables[0];
                    }

                    else
                    {
                        MessageBox.Show("操作不合规范！", "信息提示");
                        comboBox2.Text = "";
                    }
                }
                else
                {
                    tem_Value = comboBox2.Text;
                    Condition_Lookup(tem_Value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData", "ClassData");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                RotaName = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                but_modify.Enabled = true;
                but_delete.Enabled = true;
                but_save.Enabled = true;
            }
            else
            {
                RotaName = "";
                but_modify.Enabled = true;
                but_delete.Enabled = true;
                but_save.Enabled = true;
            }
        }

        private void Sut_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            MessageBox.Show("界面已进入可编辑状态！", "信息提示", MessageBoxButtons.OK);
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder mycmd = new SqlCommandBuilder(myda);
            if (MyDS_Grid.HasChanges())
            {
                bool t = true;
                try
                {
                    myda.Update(MyDS_Grid, "ClassData");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据修改不正确，如姓名重复等", "信息提示");
                    t = false;

                }
                if (t)
                    MessageBox.Show("保存成功！", "信息提示");
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (RotaName != "")
            {
                if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MyDataClass.getsqlcom("Delete ClassData where 姓名='" + RotaName + "'");
                    MyDS_Grid = MyDataClass.getDataSet("select * from ClassData", "ClassData");
                    dataGridView1.DataSource = MyDS_Grid.Tables[0];
                }
            }
            else
                MessageBox.Show("无法删除空数据表。");
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData", "ClassData");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            mycon.Close();       
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Parent!=null)
            {
                string svalue = e.Node.Text.Trim();
                MyDS_Grid = MyDataClass.getDataSet("Select * from ClassData where 专业班级='"+svalue+"'", "ClassData");
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
            }
        }

        private void Sub_Table_Click(object sender, EventArgs e)
        {
            MyMC.print(dataGridView1);
        }
    }
}
