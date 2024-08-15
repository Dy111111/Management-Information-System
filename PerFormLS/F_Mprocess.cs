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
    public partial class F_Mprocess : Form
    {
        public F_Mprocess()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Mprocess_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = System.IO.File.ReadAllText("入党申请.txt");
            richTextBox2.Text= System.IO.File.ReadAllText("入党流程.txt");
            richTextBox3.Text = System.IO.File.ReadAllText("积极分子.txt");
            richTextBox4.Text = System.IO.File.ReadAllText("确定发展对象.txt");
            richTextBox5.Text = System.IO.File.ReadAllText("预备党员.txt");
            richTextBox6.Text = System.IO.File.ReadAllText("转正.txt");
        }
    }
}
