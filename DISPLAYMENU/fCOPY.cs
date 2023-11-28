using CLIPBOARD_CLASS;
using DISPLAYMENU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fCOPY
{
    public partial class fCOPY : Form
    {
        public fCOPY()
        {
            InitializeComponent();
        }

        CLIPBOARDRB.ClipboardRB<object> cb = new CLIPBOARDRB.ClipboardRB<object>();

        private void fCOPY_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void fCOPY_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cb.ClearStack();
            cb.Add(textBox1.Text, textBox1.SelectedText);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = cb.Paste(textBox2.Text);
            cb.Add(textBox1.Text, textBox1.SelectedText);
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            cb.ClearStack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
