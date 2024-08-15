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
    public partial class F_ClearData : Form
    {
        public F_ClearData()
        {
            InitializeComponent();
        }
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();

        private void but_clear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否确定删除所有选定数据？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                MyMC.Clear_Table(groupBox2.Controls, "Table_");
        }

        private void ALL_Table_MouseDown(object sender, MouseEventArgs e)
        {
            bool tt = false;
            if (((CheckBox)sender).Checked == true)
                tt = false;
            else
                tt = true;
            foreach (Control C in groupBox2.Controls)
            {
                string sID = C.Name;
                if (sID.IndexOf("Table_") > -1)
                {
                    ((CheckBox)C).Checked = tt;
                }
            }

        }

        private void Table_Branch_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_ClearData_Load(object sender, EventArgs e)
        {

        }
    }
}
