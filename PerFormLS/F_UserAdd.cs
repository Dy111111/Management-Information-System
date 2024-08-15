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
    public partial class F_UserAdd : Form
    {
        public F_UserAdd()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        public DataSet DSet;
        public static string AutoID = "";

        private void F_UserAdd_Load(object sender, EventArgs e)
        {
            if ((int)this.Tag == 1)
            {
                text_Name.Text = "";
                text_Pass.Text = "";
            }
            else
            {
                string ID = ModuleClassLS.ModuleLS.User_ID;
                DSet = MyDataClass.getDataSet("select Name,Pass from Login where ID='" + ID + "'", "Login");
                text_Name.Text = Convert.ToString(DSet.Tables[0].Rows[0][0]);
                text_Pass.Text = Convert.ToString(DSet.Tables[0].Rows[0][1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_Name.Text == "" && text_Pass.Text == "")
            {
                MessageBox.Show("请将用户名和密码添加完整。");
                return;
            }
            DSet = MyDataClass.getDataSet("select Name from Login where Name='" + text_Name.Text + "'", "Login");
            if ((int)this.Tag == 2 && text_Name.Text == ModuleClassLS.ModuleLS.User_Name)
            {
                MyDataClass.getsqlcom("update Login set Name='" + text_Name.Text + "',Pass='" + text_Pass.Text + "' where ID='" + ModuleClassLS.ModuleLS.User_ID + "'");
                return;
            }
            if (DSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("当前用户名已存在，请重新输入。");
                text_Name.Text = "";
                text_Pass.Text = "";
                return;
            }
            if ((int)this.Tag == 1)
            {
                AutoID = MyMC.GetAutocoding("Login", "ID");
                MyDataClass.getsqlcom("insert into Login (ID,Name,Pass) values('" + AutoID + "','" + text_Name.Text + "','" + text_Pass.Text + "')");
                MyMC.ADD_Pope(AutoID, 0);
                MessageBox.Show("添加成功。");
            }
            else
            {
                MyDataClass.getsqlcom("update Login set Name='" + text_Name.Text + "',Pass='" + text_Pass.Text + "' where ID='" + ModuleClassLS.ModuleLS.User_ID + "'");
                if (ModuleClassLS.ModuleLS.User_ID == DataClassLS.MeansLS.Login_ID)
                    DataClassLS.MeansLS.Login_Name = text_Name.Text;
                MessageBox.Show("修改成功。");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
