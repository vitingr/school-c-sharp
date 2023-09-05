using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var valor = float.Parse(textBox1.Text);
            var valor_descontado = 0f;
            if (radioButton1.Checked)
            {
                valor_descontado = valor;
            }
            if (radioButton2.Checked)
            {
                valor_descontado = ((valor / 100) * 95);
            }
            if (radioButton3.Checked)
            {
                valor_descontado = ((valor / 100) * 90);
            }
            MessageBox.Show($"Com os descontos, o valor da compra será de R${valor_descontado}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
