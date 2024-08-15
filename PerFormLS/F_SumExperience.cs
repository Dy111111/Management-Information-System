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
    public partial class F_SumExperience : Form
    {
        public F_SumExperience()
        {
            InitializeComponent();
        }

        private void F_SumExperience_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = System.IO.File.ReadAllText("入党申请说明.txt");
        }
    }
}
