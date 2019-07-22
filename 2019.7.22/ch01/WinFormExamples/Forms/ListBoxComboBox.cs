using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExamples.Forms
{
    public partial class ListBoxComboBox : Form
    {
        public ListBoxComboBox()
        {
            InitializeComponent();
            listBox1.Items.Add("高等数学");
            listBox1.Items.Add("数据结构");
            listBox1.Items.Add("操作系统");
            comboBox1.Items.Add("C++");
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("Java");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("新项" + listBox1.Items.Count + 1);
            comboBox1.Items.Add("新项" + comboBox1.Items.Count + 1);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if(n != -1)
            {
                listBox1.Items.RemoveAt(n);
            }
            listBox1.SelectedIndex = -1;//-1表示不选择任何项
            n = comboBox1.SelectedIndex;
            if(n != -1)
            {
                comboBox1.Items.RemoveAt(n);
            }
            comboBox1.SelectedIndex = -1;
        }
    }
}
