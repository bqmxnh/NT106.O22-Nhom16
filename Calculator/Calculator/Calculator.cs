using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private int flag = 0;
        private void button_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                richTextBox1.Text = "";
                flag = 0;
            }
            richTextBox1.Text += (sender as Button).Text;
        }

        private void button_clear(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button_clearentry(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
            }
        }

        private void button_equal(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = new DataTable().Compute(richTextBox1.Text, null).ToString();
                flag = 1;
            }
            catch (Exception)
            {
                richTextBox1.Text = "Error";
                flag = 1;
            }
        }

        private void richTextBox1_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    richTextBox1.Text = new DataTable().Compute(richTextBox1.Text, null).ToString();
                    flag = 1;
                }
                catch (Exception)
                {
                    richTextBox1.Text = "Error";
                    flag = 1;
                }
            }
        }
    }
}
