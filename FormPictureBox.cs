using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CheckItem()
        {
            if (radioButton1.Checked) {
                pictureBox1.Image = Properties.Resources.foto;
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.foto2;
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Image = null;
            }
            if (radioButton4.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
            if (radioButton5.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            if (radioButton6.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
            return 1;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            } else
            {
                pictureBox1.Visible = true;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            CheckItem();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
