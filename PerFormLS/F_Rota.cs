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
    public partial class F_Rota : Form
    {
        public F_Rota()
        {
            InitializeComponent();
        }
        public static string RotaName;
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        DataSet MyDS_Grid=new DataSet();
        SqlDataAdapter myda = new SqlDataAdapter();
        public static string connstring= DataClassLS.MeansLS.M_str_sqlcon;
        SqlConnection mycon = new SqlConnection();
        private void F_Rota_Load(object sender, EventArgs e)
        {
            //MyDS_Grid = MyDataClass.getDataSet("select 姓名 ,班级,值班日期,时间 from Rota order by 值班日期", "Rota");
            
            mycon.ConnectionString=connstring;
            mycon.Open();          
            myda = new SqlDataAdapter("select 姓名 ,班级,值班日期,星期,时间 from Rota order by 值班日期",mycon );
            myda.Fill(MyDS_Grid, "Rota");     
            dataGridView1.DataSource = MyDS_Grid.Tables["Rota"];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;           
            mycon.Close();
            textBox1.Text = "";
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                RotaName = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                but_Modify.Enabled = true;
                but_Delete.Enabled = true;
                but_Save.Enabled = true;
            }
            else
            {
                RotaName = "";
                but_Modify.Enabled = true;
                but_Delete.Enabled = true;
                but_Save.Enabled = true;
            }
        }

        private void but_Delete_Click(object sender, EventArgs e)
        {
            if (RotaName != "")
            {
                if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MyDataClass.getsqlcom("Delete Rota where 姓名='" + RotaName + "'");
                    MyDS_Grid = MyDataClass.getDataSet("select 姓名, 班级, 值班日期,星期, 时间 from Rota order by 值班日期", "Rota");
                    dataGridView1.DataSource = MyDS_Grid.Tables[0];
                }
            }
            else
                MessageBox.Show("无法删除空数据表。");
        }

        private void but_Modify_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            MessageBox.Show("界面已进入可编辑状态！", "信息提示", MessageBoxButtons.OK);
        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder mycmd = new SqlCommandBuilder(myda);
            if(MyDS_Grid.HasChanges())
            {
                bool t=true;
                try
                {
                    myda.Update(MyDS_Grid, "Rota");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据修改不正确，如姓名重复等", "信息提示");
                    t = false;

                }
                if(t)
                MessageBox.Show("保存成功！", "信息提示");
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
               dataGridView1.Rows[i].Selected = false;
            }
                if (comboBox1.Text == "" || (textBox1.Text == ""&&dateTimePicker1.Text==""))
                MessageBox.Show("请将查询类别及条件填写完整！", "信息提示", MessageBoxButtons.OK);
            else if(comboBox1.Text.Trim()=="姓名")
            {
                int i=0;               
                while(i < dataGridView1.RowCount)
                { 
                    if(textBox1.Text.Trim()== dataGridView1[0, i].Value.ToString())
                        break;
                    i++;
                }
                if (i == dataGridView1.RowCount)
                    MessageBox.Show("查无此人！", "信息提示");
                else
                { 
                    dataGridView1.Rows[i].Selected=true;
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                }
                

            }
            else
            {
                int i,d=0;
                for (i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (Convert.ToDateTime(dataGridView1[2, i].Value).ToString("d")==dateTimePicker1.Value.ToString("d"))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[2, i];
                        d = 1;
                    }
                }
                if (d==0) 
                    MessageBox.Show("此时间无人值班！", "信息提示");
                    
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "姓名")
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
            if (comboBox1.Text.Trim() == "值班日期")
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModuleClassLS.ModuleLS module = new ModuleClassLS.ModuleLS();
            module.print(dataGridView1);
        }
    }
}
