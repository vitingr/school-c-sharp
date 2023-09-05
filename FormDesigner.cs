using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var value1 = int.Parse(textBox1.Text);
            var value2 = int.Parse(textBox2.Text);
            var value3 = int.Parse(textBox3.Text);

            var dias = ((value1 * 365) + (value2 * 30) + (value3));
            MessageBox.Show($"A sua idade em dias, atualmente corresponde a {dias} dias de idade");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
