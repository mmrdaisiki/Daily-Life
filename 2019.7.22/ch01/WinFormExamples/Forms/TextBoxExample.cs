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
    public partial class TextBoxExample : Form
    {
        public TextBoxExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            this.Close();
        }

        private void textBoxPwdInfo_TextChanged(object sender, EventArgs e)
        {
            textBoxPwdInfo.Text = textBoxPwd.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
