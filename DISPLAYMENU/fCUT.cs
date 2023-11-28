using CLIPBOARD_CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fCUT
{
    public partial class fCUT : Form
    {
        public fCUT()
        {
            InitializeComponent();
        }

        CLIPBOARDRB.ClipboardRB<object> cb = new CLIPBOARDRB.ClipboardRB<object>();

        private void button1_Click(object sender, EventArgs e)
        {
            cb.Add(textBox1.Text, textBox1.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = cb.Paste(textBox2.Text);
            if (textBox1.SelectedText == cb.ClearInput(textBox1.SelectedText))
            {
                textBox1.Text = cb.ClearInput(textBox1.Text);
            }
            textBox1.SelectedText = cb.ClearInput(textBox1.SelectedText);
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = cb.ClearInput(textBox1.Text);
            textBox2.Text = cb.ClearInput(textBox2.Text);
            cb.ClearStack();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fCUT_Load(object sender, EventArgs e)
        {

        }
    }
}
