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
    public partial class F_User : Form
    {
        public F_User()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();

        public static DataSet MyDS_Grid;

        private void tool_UserAdd_Click(object sender, EventArgs e)
        {
            PerFormLS.F_UserAdd FrmUserAdd = new F_UserAdd();
            FrmUserAdd.Tag = 1;
            FrmUserAdd.Text = tool_UserAdd.Text + "用户";
            FrmUserAdd.ShowDialog(this);
        }

        private void tool_UserAmend_Click(object sender, EventArgs e)
        {
            if (ModuleClassLS.ModuleLS.User_ID.Trim() == "0001")
            {
                MessageBox.Show("不能修改超级用户。");
                return;
            }
            PerFormLS.F_UserAdd FrmUserAdd = new F_UserAdd();
            FrmUserAdd.Tag = 2;
            FrmUserAdd.Text = tool_UserAmend.Text + "用户";
            FrmUserAdd.ShowDialog(this);
        }

        private void F_User_Load(object sender, EventArgs e)
        {
            MyDS_Grid = MyDataClass.getDataSet("select ID as 编号,Name as 用户名 from Login", "Login");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                ModuleClassLS.ModuleLS.User_ID = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                ModuleClassLS.ModuleLS.User_Name = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                tool_UserAmend.Enabled = true;
                tool_UserDelete.Enabled = true;
                tool_UserPopedom.Enabled = true;
            }
            else
            {
                ModuleClassLS.ModuleLS.User_ID = "";
                ModuleClassLS.ModuleLS.User_Name = "";
                tool_UserAmend.Enabled = false;
                tool_UserDelete.Enabled = false;
                tool_UserPopedom.Enabled = false;
            }
        }

        private void tool_UserPopedom_Click(object sender, EventArgs e)
        {
            if (ModuleClassLS.ModuleLS.User_ID.Trim() == "0001")
            {
                MessageBox.Show("不能修改超级用户权限。");
                return;
            }
            F_UserPope FrmUserPope = new F_UserPope();
            FrmUserPope.Text = "用户权限设置";
            FrmUserPope.ShowDialog(this);
        }

        private void tool_UserDelete_Click(object sender, EventArgs e)
        {
            if (ModuleClassLS.ModuleLS.User_ID != "")
            {
                if (ModuleClassLS.ModuleLS.User_ID.Trim() == "0001")
                {
                    MessageBox.Show("不能删除超级用户。");
                    return;
                }
                MyDataClass.getsqlcom("Delete Login where ID='" + ModuleClassLS.ModuleLS.User_ID.Trim() + "'");
                MyDataClass.getsqlcom("Delete UserPope where ID='" + ModuleClassLS.ModuleLS.User_ID.Trim() + "'");
                MyDS_Grid = MyDataClass.getDataSet("select ID as 编号,Name as 用户名 from Login", "Login");
                dataGridView1.DataSource = MyDS_Grid.Tables[0];
            }
            else
                MessageBox.Show("无法删除空数据表。");
        }

        private void F_User_Activated(object sender, EventArgs e)
        {
            MyDS_Grid = MyDataClass.getDataSet("select ID as 编号,Name as 用户名 from Login", "Login");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
        }

        private void tool_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
