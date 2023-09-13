using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox2.SelectedIndex;
            var text = comboBox2.SelectedItem;
            var count = comboBox2.Items.Count;

            label6.Text = $"Item na posição {index}°";
            label7.Text = $"A descrição é {text}";
            label8.Text = $"posusi {count} estados";
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(textBox1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
