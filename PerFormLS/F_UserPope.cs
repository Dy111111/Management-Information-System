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
    public partial class F_UserPope : Form
    {
        public F_UserPope()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        private void F_UserPope_Load(object sender, EventArgs e)
        {

        }

        private void F_UserPope_Shown(object sender, EventArgs e)
        {
            User_ID.Text = ModuleClassLS.ModuleLS.User_ID;
            User_Name.Text = ModuleClassLS.ModuleLS.User_Name;
            if (User_Name.Text.Trim() == "TSoft")//
                User_Save.Enabled = false;
            MyMC.Show_Pope(groupBox2.Controls, ModuleClassLS.ModuleLS.User_ID);
        }

        private void User_Save_Click(object sender, EventArgs e)
        {
            MyMC.Amend_Pope(groupBox2.Controls, ModuleClassLS.ModuleLS.User_ID);
            MessageBox.Show("保存成功！", "信息提示");
            if (DataClassLS.MeansLS.Login_ID == ModuleClassLS.ModuleLS.User_ID)
                DataClassLS.MeansLS.Login_n = 2;
        }

        private void User_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_All_MouseDown(object sender, MouseEventArgs e)
        {
            bool tt = false;
            if (((CheckBox)sender).Checked == true)
                tt = false;
            else
                tt = true;
            foreach (Control C in groupBox2.Controls)
            {
                string sID = C.Name;
                if (sID.IndexOf("User_") > -1)
                {
                    ((CheckBox)C).Checked = tt;
                }
            }
        }

        private void User_Folk_MouseUp(object sender, MouseEventArgs e)
        {
            if (((CheckBox)sender).Checked == false)
            {
                User_All.Checked = false;
            }
        }

        private void User_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
