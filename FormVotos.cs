using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int total_votos = int.Parse(textBox1.Text);

            var brancos = ((float.Parse(textBox2.Text)) / 100) * 10;
            var nulos = ((float.Parse(textBox3.Text)) / 100) * 10;
            var validos = ((float.Parse(textBox4.Text)) / 100) * 10;

            label5.Text = $"{brancos}%";
            label6.Text = $"{nulos}%";
            label7.Text = $"{validos}%";
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;


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

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
