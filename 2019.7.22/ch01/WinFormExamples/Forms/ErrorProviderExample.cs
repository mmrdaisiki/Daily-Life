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
    public partial class ErrorProviderExample : Form
    {
        public ErrorProviderExample()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text,out n)==false)
            {
                errorProvider1.SetError(textBox1,"无法将字符串转换为整数");
                return;
            }
            if (n < 1 || n > 10)
            {
                errorProvider1.SetError(textBox1, "整数不在1~10范围内");
                return;
            }
            errorProvider1.SetError(textBox1, null);
            MessageBox.Show("OK");
        }
    }
}
