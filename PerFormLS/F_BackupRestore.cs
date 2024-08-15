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
using System.Diagnostics;

namespace 党建信息管理系统LS.PerFormLS
{
    public partial class F_BackupRestore : Form
    {
        public F_BackupRestore()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();

        private void button1_Click(object sender, EventArgs e)
        {
            string Str_dar = "";
            if (radioButton1.Checked == true)
                Str_dar = System.Environment.CurrentDirectory;
            if (radioButton2.Checked == true)
                Str_dar = textBox2.Text + "\\";
            if (textBox2.Text == "" & radioButton2.Checked == true)
            {
                MessageBox.Show("请选择备份数据库文件的路径。");
                return;
            }
            try
            {
                Str_dar = "backup database 党建信息数据库 to disk='" + Str_dar + MyMC.Date_Format(System.DateTime.Now.ToString()) + MyMC.Time_Format(System.DateTime.Now.ToString()) + ".bak" + "'";
                MyDataClass.getsqlcom(Str_dar);
                MessageBox.Show("数据备份成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    textBox2.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else
                    MessageBox.Show("请先选择其他路径！", "信息提示");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("请选择备份数据库文件的路径。");
                return;
            }
            try
            {
                if (DataClassLS.MeansLS.My_con.State == ConnectionState.Open)
                {
                    DataClassLS.MeansLS.My_con.Close();
                }
                string DateStr = "Data Source=(local);Database=master;User id=sa;PWD=123";
                SqlConnection conn = new SqlConnection(DateStr);
                conn.Open();
                //-------------------杀掉所有连接 党建信息数据库 数据库的进程--------------
                string strSQL = "select spid from master..sysprocesses where dbid=db_id( '党建信息数据库') ";
                SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);
                DataTable spidTable = new DataTable();
                Da.Fill(spidTable);
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;
                for (int iRow = 0; iRow < spidTable.Rows.Count; iRow++)
                {
                    Cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();   //强行关闭用户进程 
                    Cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
                SqlConnection Tem_con = new SqlConnection(DataClassLS.MeansLS.M_str_sqlcon);
                Tem_con.Open();
                SqlCommand SQLcom = new SqlCommand("backup log 党建信息数据库 to disk='"
                    + textBox3.Text.Trim() + "'use master restore database 党建信息数据库 from disk='"
                    + textBox3.Text.Trim() + "' with replace", Tem_con);
                SQLcom.ExecuteNonQuery();
                SQLcom.Dispose();
                Tem_con.Close();
                Tem_con.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MyDataClass.con_open();
                MyDataClass.con_close();
                MessageBox.Show("为了避免数据丢失，在数据库还原后将关闭整个系统。");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.bak|*.bak";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
