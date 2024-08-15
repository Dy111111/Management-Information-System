using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 党建信息管理系统LS
{
    public partial class Main : Form
    {
        DataClassLS.MeansLS MyClass = new DataClassLS.MeansLS();
        ModuleClassLS.ModuleLS MyMenu = new ModuleClassLS.ModuleLS();
        public Main()
        {
            InitializeComponent();
        }
        #region  通过权限对主窗体进行初始化
        /// <summary>
        /// 对主窗体初始化
        /// </summary>
        private void Preen_Main()
        {
            statusStrip1.Items[2].Text = DataClassLS.MeansLS.Login_Name;  //在状态栏显示当前登录的用户名
            treeView1.Nodes.Clear();
            MyMenu.GetMenu(treeView1, menuStrip1);  //调用公共类MyModule下的GetMenu()方法，将menuStrip1控件的子菜单添加到treeView1控件中
            MyMenu.MainMenuF(menuStrip1);   //将菜单栏中的各子菜单项设为不可用状态
            MyMenu.MainPope(menuStrip1, DataClassLS.MeansLS.Login_Name);  //根据权限设置相应子菜单的可用状态
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoginLS FrmLogin = new LoginLS();   //声时登录窗体，进行调用
            FrmLogin.Tag = 1;   //将登录窗体的Tag属性设为1，表示调用的是登录窗体
            FrmLogin.ShowDialog();
            FrmLogin.Dispose();
            //当调用的是登录窗体时
            if (DataClassLS.MeansLS.Login_n == 1)
            {
                Preen_Main();   //自定义方法，通过权限对窗体进行初始化
                MyMenu.PactDay(1);  //MyModule类中的自定义方法，用于查找指定时间内，过生日的党员
                MyMenu.PactDay(2);  //MyModule类中的自定义方法，用于查找值班的党员
            }
            DataClassLS.MeansLS.Login_n = 3;  //将公共变量设为3，便于控制登录窗体的关闭
            Tool_Help.Enabled = true;
        }
        #endregion


        private void Main_Activated(object sender, EventArgs e)
        {
            if (DataClassLS.MeansLS.Login_n == 2) //当调用的是重新登录窗体时
                Preen_Main();   //自定义方法，通过权限对窗体进行初始化
            DataClassLS.MeansLS.Login_n = 3;
        }

        private void Button_ApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PMBasic_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void ClassData_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Find_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void DayWorkPad_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void AddressBook_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Notice_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void NoteBook_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Calculater_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Rota_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void BackupRestore_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void ReLogin_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void UserSet_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void ApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mprocess_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void BasicKonwledge_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void SumExperience_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Tool_Help_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Button_PMBasic_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Button_BasicKonwledge_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Button_AddressBook_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Button_DayWorkPad_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Trim() == "系统退出")   //如果当前节点的文本为“系统退出”
            {
                Application.Exit(); //关闭应用程序
            }
            MyMenu.TreeMenuF(menuStrip1, e);   //用MyModule公共类中的TreeMenuF()方法调用各窗体
        }

        private void BirthdayNotice_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void RotaNotice_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }
  
        private void Activist_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_PTitleSort_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_Grade_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_Folk_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_PartyBranch_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_Class_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_PadSort_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_PBJSort_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_MemberSort_Click_1(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu8_Click(object sender, EventArgs e)
        {

        }
    }
}
