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
    public partial class F_AddressList : Form
    {
        public F_AddressList()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        public static DataSet MyDS_Grid;
        public static string AllSql = "Select 编号,姓名,性别,身份证号,联系电话, QQ as QQ号,Email as 邮箱地址 from AddressBook";
        public static string Find_Field = "";

        public void ShowAll()
        {
            ModuleClassLS.ModuleLS.Address_ID = "";
            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(AllSql, "AddressBook");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            if (dataGridView1.RowCount > 1)
            {
                Address_Amend.Enabled = true;
                Address_Delete.Enabled = true;
            }
            else
            {
                Address_Amend.Enabled = false;
                Address_Delete.Enabled = false;
            }
        }

        private void F_AddressList_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void Address_Add_Click(object sender, EventArgs e)
        {
            PerFormLS.F_AddressAdd FrmAddress = new PerFormLS.F_AddressAdd();
            FrmAddress.Text = "通讯录添加操作";
            FrmAddress.Tag = 1;
            FrmAddress.ShowDialog(this);
            ShowAll();
        }

        private void Address_Amend_Click(object sender, EventArgs e)
        {
            PerFormLS.F_AddressAdd FrmAddress = new PerFormLS.F_AddressAdd();
            FrmAddress.Text = "通讯录修改操作";
            FrmAddress.Tag = 2;
            FrmAddress.ShowDialog(this);
            ShowAll();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                ModuleClassLS.ModuleLS.Address_ID = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                Address_Amend.Enabled = true;
                Address_Delete.Enabled = true;

            }
            else
            {
                Address_Amend.Enabled = false;
                Address_Delete.Enabled = false;
            }
        }

        private void Address_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MyDataClass.getsqlcom("Delete AddressBook where 编号='" + ModuleClassLS.ModuleLS.Address_ID + "'");
                ShowAll();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    {
                        Find_Field = "姓名";
                        break;
                    }
                case 1:
                    {
                        Find_Field = "性别";
                        break;
                    }
                case 2:
                    {
                        Find_Field = "Email";
                        break;
                    }
                case 3:
                    {
                        Find_Field = "身份证号";
                        break;
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入查询条件。");
                return;
            }
            ModuleClassLS.ModuleLS.Address_ID = "";
            //用dataGridView1控件显示职工的名称
            MyDS_Grid = MyDataClass.getDataSet(AllSql + " where " + Find_Field + " like '%" + textBox1.Text.Trim() + "%'", "AddressBook");
            dataGridView1.DataSource = MyDS_Grid.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            if (dataGridView1.RowCount > 1)
            {
                Address_Amend.Enabled = true;
                Address_Delete.Enabled = true;
            }
            else
            {
                Address_Amend.Enabled = false;
                Address_Delete.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void Address_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
