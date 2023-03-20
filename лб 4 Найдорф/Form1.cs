using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лб_4_Найдорф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 1: Порожньо\n");
            else
                richTextBox1.AppendText("Eлeмент 1: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 2: Порожньо\n");
            else
                richTextBox1.AppendText("Eлeмент 2: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 3: Порожньо\n");
            else
                richTextBox1.AppendText("Eлeмент 3: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 4: Порожньо\n");
            else
                richTextBox1.AppendText("Eлeмент 4: " + textBox2.Text + '\n');
            if (string.IsNullOrEmpty(textBox2.Text))
                richTextBox1.AppendText("Елемент 5: Порожньо\n");
            else
                richTextBox1.AppendText("Eлeмент 5: " + textBox2.Text + '\n');
        }
    }
}
