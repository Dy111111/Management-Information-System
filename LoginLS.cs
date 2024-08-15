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

namespace 党建信息管理系统LS
{
    public partial class LoginLS : Form
    {
        DataClassLS.MeansLS Myclass = new DataClassLS.MeansLS();
        public LoginLS()
        {
            InitializeComponent();
        }

        private void buttClose_Click(object sender, EventArgs e)
        {
            if ((int)(this.Tag) == 1)
            {
                DataClassLS.MeansLS.Login_n = 3;
                Application.Exit();
            }
            else
                if ((int)(this.Tag) == 2)
                this.Close();
        }

        private void buttLogin_Click(object sender, EventArgs e)
        {
            if(textName.Text!=""&&textPass.Text!="")
            {
                SqlDataReader myreader =Myclass.getcom("select * from Login where Name='"+textName.Text.Trim()+"' and Pass='"+textPass.Text.Trim()+"'");
                bool ifcom = myreader.Read();
                if (ifcom)
                {
                    DataClassLS.MeansLS.Login_Name = textName.Text.Trim();
                    DataClassLS.MeansLS.Login_ID = myreader.GetString(0);
                    DataClassLS.MeansLS.My_con.Close();
                    DataClassLS.MeansLS.My_con.Dispose();//Dispose方法与Close不同之处在于它直接清空了connectionstring，无法再用open方法打开
                    DataClassLS.MeansLS.Login_n = (int)(this.Tag);
                    this.Close();
                }
                else
                { 
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Text = "";
                    textPass.Text = "";
                }
            }
            else
                MessageBox.Show("请将登录信息填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginLS_Load(object sender, EventArgs e)
        {
            try
            {
                Myclass.con_open();
                Myclass.con_close();
                textName.Text = "";
                textPass.Text = "";
            }
            catch
            {
                MessageBox.Show("数据库连接失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            DataSet DSet = Myclass.getDataSet("select * from keepLogin ", "keepLogin");
            if(DSet.Tables[0].Rows.Count!=0)
            { 
                int keepLogin = Convert.ToInt32(DSet.Tables[0].Rows[0][1]);
                if (keepLogin != 0)
                {
                    checkBox1.Checked = true;
                    textName.Text = Convert.ToString(DSet.Tables[0].Rows[0][2]);
                    textPass.Text= Convert.ToString(DSet.Tables[0].Rows[0][3]);
                }
            }
        }
        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                textPass.Focus();
        }

        private void textPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttLogin.Focus();
        }

        private void F_Login_Activated(object sender, EventArgs e)
        {
            textName.Focus();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPass.Text != "")
               { 
                    int Un = 0;
                    if (checkBox1.Checked == true)
                        Un = 1;
                    else
                        Un = 0;
                    Myclass.getsqlcom("update keepLogin set keepLogin=" + Un + ",Name='"+textName.Text.Trim()+"',UID='"+textPass.Text.Trim()+"'");
                }            
        }

        private void LoginLS_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void LoginLS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataClassLS.MeansLS.Login_ID == "" || DataClassLS.MeansLS.Login_Name == "")
                Application.Exit();

        }
    }
}
