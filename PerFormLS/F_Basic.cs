using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 党建信息管理系统LS.PerFormLS
{
    public partial class F_Basic : Form
    {
        public F_Basic()
        {
            InitializeComponent();
        }
        DataClassLS.MeansLS MyDClass = new DataClassLS.MeansLS();
        public static string reField = "";  //记录要修改的字段
        public static int indvar = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            bool t = false;
            string temField = "";
            if (textBox1.Text != "")
            {
                temField = textBox1.Text.Trim();
                SqlDataReader temDR = MyDClass.getcom("select * from " + DataClassLS.MeansLS.Mean_Table.Trim() + " where " + DataClassLS.MeansLS.Mean_Field.Trim() + "='" + temField + "'");
                t = temDR.Read();
                if (t == false)
                {
                    MyDClass.getsqlcom("insert into " + DataClassLS.MeansLS.Mean_Table.Trim() + "(" + DataClassLS.MeansLS.Mean_Field.Trim() + ") values(" + "'" + temField + "'" + ")");
                    listBox1.Items.Add(textBox1.Text.Trim());
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool t = false;
            string temField = "";
            if (textBox1.Text != "")
            {
                temField = textBox1.Text.Trim();
                SqlDataReader temDR = MyDClass.getcom("select * from " + DataClassLS.MeansLS.Mean_Table.Trim() + " where " + DataClassLS.MeansLS.Mean_Field.Trim() + "='" + reField + "'");
                t = temDR.Read();
                if (t == true)
                {
                    temField = temDR[0].ToString();
                    MyDClass.getsqlcom("update " + DataClassLS.MeansLS.Mean_Table.Trim() + " set " + DataClassLS.MeansLS.Mean_Field.Trim() + "='" + textBox1.Text.Trim() + "' where ID='" + temField + "'");
                    if (indvar >= 0)
                        listBox1.Items[indvar] = (textBox1.Text.Trim());
                    textBox1.Text = "";
                }
            }
            button4_Click(sender, e);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                reField = listBox1.SelectedItem.ToString();
                indvar = listBox1.SelectedIndex;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reField != "" & indvar >= 0)
            {
                MyDClass.getsqlcom("delete from " + DataClassLS.MeansLS.Mean_Table.Trim() + " where " + DataClassLS.MeansLS.Mean_Field.Trim() + "='" + reField + "'");
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.SelectedIndex = -1;
            }
            button4_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void F_Basic_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DataSet My_Set = MyDClass.getDataSet(DataClassLS.MeansLS.Mean_SQL, DataClassLS.MeansLS.Mean_Table);
            if (My_Set.Tables[0].Rows.Count > 0)
                for (int i = 0; i < My_Set.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(My_Set.Tables[0].Rows[i][1].ToString());
                }
        }
    }
}
