using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int value = 0;

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                value += 300;
            }
            else
            {
                value -= 300;
            }
            label2.Text = $"R$ {value}";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                value += 500;
            }
            else
            {
                value -= 500;
            }
            label2.Text = $"R$ {value}";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                value += 1000;
            }
            else
            {
                value -= 1000;
            }
            label2.Text = $"R$ {value}";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                value += 5000;
            }
            else
            {
                value -= 5000;
            }
            label2.Text = $"R$ {value}";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                value += 350;
            } else
            {
                value -= 350;
            }
            label2.Text = $"R$ {value}";
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                value += 2000;
            }
            else
            {
                value -= 2000;
            }
            label2.Text = $"R$ {value}";
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                value += 2500;
            }
            else
            {
                value -= 2500;
            }
            label2.Text = $"R$ {value}";
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                value += 700;
            }
            else
            {
                value -= 700;
            }
            label2.Text = $"R$ {value}";
        }
    }
}
