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
    public partial class CheckBoxRadioButton : Form
    {
        public CheckBoxRadioButton()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            s += checkBox1.Checked ? checkBox1.Text + "、" : "";
            s += checkBox2.Checked ? checkBox2.Text + "、" : "";
            s += checkBox3.Checked ? checkBox3.Text + "、" : "";
            textBox1.Text = s.Trim('、');
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            if(r.Checked==true)
            {
                textBox1.Text = r.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxRadioButton_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
