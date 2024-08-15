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
    public partial class F_WorkPad : Form
    {
        public F_WorkPad()
        {
            InitializeComponent();
        }
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        public static string AllSql = "select 编号,日期,记事类别,主题,内容 from DayWorkPad";
        public static DataSet MyDS_Grid;  //存储数据表信息
        public static string Word_ID = "";  //存储添加信息时的自动编号
        public static int Word_S = 0;

        public void Show_N()
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    WordPad_1.Value = Convert.ToDateTime(dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString());
                    WordPad_2.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    WordPad_3.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    WordPad_4.Text = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    Word_ID = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                catch
                {
                    WordPad_2.Text = "";
                    WordPad_3.Text = "";
                    WordPad_4.Text = "";
                    Word_ID = "";
                }
            }
            else
            {
                MyMC.Clear_Control(groupBox3.Controls);
                Word_ID = "";
                WordPad_1.Value = Convert.ToDateTime(System.DateTime.Now.ToString());
            }
        }

        private void F_WordPad_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(AllSql, "DayWorkPad");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.AutoGenerateColumns = true;  //是否自动创建列
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 100;

            //隐藏dataGridView1控件中不需要的列字段
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            MyMC.CoPassData(WordPad_2, "PadSort");  //向“记事类别”列表框中添加信息
            MyMC.CoPassData(comboBox1, "PadSort");

            MyMC.Ena_Button(Word_Add, Word_Amend, Word_Cancel, Word_Save, 1, 1, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyMC.Clear_Control(groupBox3.Controls);
            WordPad_1.Value = Convert.ToDateTime(System.DateTime.Now.ToString());
            Word_ID = MyMC.GetAutocoding("DayWorkPad", "编号");  //自动添加编号;
            Word_S = 1;
            MyMC.Ena_Button(Word_Add, Word_Amend, Word_Cancel, Word_Save, 1, 0, 1, 1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MyDS_Grid.Tables[0].Rows.Count > 0)
            {
                Word_S = 2;
                MyMC.Ena_Button(Word_Add, Word_Amend, Word_Cancel, Word_Save, 0, 1, 1, 1);
            }
            else
                MessageBox.Show("当前为空记录，无法进行修改。");

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Show_N();
        }

        private void Word_Cancel_Click(object sender, EventArgs e)
        {
            Word_S = 0;
            MyMC.Ena_Button(Word_Add, Word_Amend, Word_Cancel, Word_Save, 1, 1, 0, 0);

            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(AllSql, "DayWorkPad");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];

        }

        private void Word_Save_Click(object sender, EventArgs e)
        {
            string All_Field = "";
            string All_Value = "";

            if (Word_S == 1)
            {
                All_Field = "编号,日期,记事类别,主题,内容";
                All_Value = "'" + Word_ID + "'," + "'" + Convert.ToDateTime((WordPad_1.Value.ToString())).ToShortDateString() + "'," + "'" + WordPad_2.Text + "'," + "'" + WordPad_3.Text + "'," + "'" + WordPad_4.Text + "'";
                MyDataClass.getsqlcom("insert into DayWorkPad (" + All_Field + ") values(" + All_Value + ")");
            }
            if (Word_S == 2)
            {
                All_Value = "编号='" + Word_ID + "'," + "日期='" + Convert.ToDateTime((WordPad_1.Value.ToString())).ToShortDateString() + "'," + "记事类别='" + WordPad_2.Text + "'," + "主题='" + WordPad_3.Text + "'," + "内容='" + WordPad_4.Text + "'";
                MyDataClass.getsqlcom("update DayWorkPad set " + All_Value + " where 编号='" + Word_ID + "'");
            }
            Word_Cancel_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fing_Sql = "";
            if (checkBox1.Checked == true)
            {
                Fing_Sql = " (日期 = '" + (Convert.ToDateTime(dateTimePicker1.Value.ToString())).ToShortDateString() + "')";
            }
            if (checkBox2.Checked == true)
            {
                if ((comboBox1.Text.Trim()).Length == 0)
                {
                    MessageBox.Show("请添写查询条件。");
                    return;
                }
                else
                {
                    if (Fing_Sql == "")
                        Fing_Sql = "(记事类别= '" + comboBox1.Text + "')";
                    else
                        Fing_Sql = Fing_Sql + " AND " + " (记事类别 = '" + comboBox1.Text + "')";
                }
            }
            if (Fing_Sql != "")
                Fing_Sql = AllSql + " where " + Fing_Sql;
            else
                Fing_Sql = AllSql;
            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(Fing_Sql, "DayWorkPad");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            checkBox3.Checked = false;
            if (MyDS_Grid.Tables[0].Rows.Count < 1) //如果查询结果为空，清除相关文本
            {
                WordPad_2.Text = "";
                WordPad_3.Text = "";
                WordPad_4.Text = "";
                Word_ID = "";
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
                Word_Cancel_Click(sender, e);
        }

        private void Word_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 2)
            {
                MessageBox.Show("数据表为空，不可以删除。");
                return;
            }
            if (Word_ID == "")
            {
                MessageBox.Show("无法删除空记录。");
                return;
            }
            MyDataClass.getsqlcom("Delete DayWorkPad where 编号='" + Word_ID + "'");
            Word_Cancel_Click(sender, e);
        }
    }
}
