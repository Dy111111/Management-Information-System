using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 党建信息管理系统LS
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
        private void CreateDataBase(string strSql,string DataName,string strMdf,string strLdf,string path)
        {
            SqlConnection myConn = new SqlConnection(strSql);
            string str = null;
            try
            {
                str= "EXEC sp_attach_db @dbname='" + DataName + "',@filename1='" + strMdf + "',@filename2='" + strLdf + "'";
                SqlCommand myCommand = new SqlCommand(str, myConn);
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("数据库安装成功！点击确定继续","安装提示",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
            }
            catch(Exception e)
            {
                MessageBox.Show("数据库安装失败！"+e.Message+"\n\n"+"您可以手动附加数据库");
                System.Diagnostics.Process.Start(path);//打开安装目录
            }
            finally
            {
                myConn.Close();
            }
        }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
           //string server = this.Context.Parameters["server"];//服务器名称
            //string uid = this.Context.Parameters["user"];//SQLserver 用户名
            //string pwd= this.Context.Parameters["pwd"];//密码
            string path= this.Context.Parameters["targetdir"];//安装目录
            string strSql = @"Data Source=(local);uid=sa;pwd=123;database=master;";//"server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=master";//连接数据库字符串
            string DataName = "党建信息数据库";//数据库名
            string strMdf = path + @"党建信息数据库.mdf";
            string strLdf = path + @"党建信息数据库_log.ldf";
            base.Install(stateSaver);
            this.CreateDataBase(strSql, DataName, strMdf, strLdf, path);//开始创建数据库
        }
    }
}
