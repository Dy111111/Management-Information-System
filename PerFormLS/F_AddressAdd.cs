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
    public partial class F_AddressAdd : Form
    {
        public F_AddressAdd()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDataClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMC = new ModuleClassLS.ModuleLS();
        public static DataSet MyDS_Grid;
        public static string Address_ID = "";

        private void F_Address_Load(object sender, EventArgs e)
        {
            if ((int)(this.Tag) == 1)
            {
                Address_ID = MyMC.GetAutocoding("AddressBook", "编号");
            }
            if ((int)this.Tag == 2)
            {
                MyDS_Grid = MyDataClass.getDataSet("select 编号,姓名,性别,联系电话,QQ,Email from AddressBook where 编号='" + ModuleClassLS.ModuleLS.Address_ID + "'", "AddressBook");
                Address_ID = MyDS_Grid.Tables[0].Rows[0][0].ToString();
                this.Address_1.Text = MyDS_Grid.Tables[0].Rows[0][1].ToString();
                this.Address_2.Text = MyDS_Grid.Tables[0].Rows[0][2].ToString();
                this.Address_3.Text = MyDS_Grid.Tables[0].Rows[0][3].ToString();
                this.Address_4.Text = MyDS_Grid.Tables[0].Rows[0][4].ToString();
                this.Address_5.Text = MyDS_Grid.Tables[0].Rows[0][5].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Address_1.Text != "")
            {
                MyMC.Part_SaveClass("编号,姓名,性别,联系电话,QQ,Email", Address_ID, "", this.groupBox1.Controls, "Address_", "AddressBook", 6, (int)this.Tag);
                MyDataClass.getsqlcom(ModuleClassLS.ModuleLS.ADDs);
                this.Close();
            }
            else
                MessageBox.Show("人员姓名不能为空。");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
