using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string nomeAluno = nome.Text;

            float n1 = float.Parse(nota1.Text);
            float n2 = float.Parse(textBox1.Text);
            float n3 = float.Parse(textBox2.Text);
            float n4 = float.Parse(textBox3.Text);

            float media = (n1 + n2 + n3 + n4) / 4;

            var opcao = listBox1.SelectedItem;
            var resultado = label5;

            switch (opcao)
            {
                case "Soma":
                    {
                        float result = Soma(n1, n2, n3, n4);
                        resultado.Text = "O resultado da soma entre os números equivale a " + result;
                        break;
                    }
                case "Subtracao":
                    {
                        float result = Subtracao(n1, n2, n3, n4);
                        resultado.Text = "O resultado da soma entre os números equivale a " + result;
                        break;
                    }
                case "Multiplicacao":
                    {
                        float result = Multiplicacao(n1, n2, n3, n4);
                        resultado.Text = "O resultado da soma entre os números equivale a " + result;
                        break;
                    }
                case "Divisao":
                    {
                        float result = Divisao(n1, n2, n3, n4);
                        resultado.Text = "O resultado da soma entre os números equivale a " + result;
                        break;
                    }
                default:
                    {
                        resultado.Text = "Erro! Selecione uma opção válida de cálculo";
                        break;
                    }
            }


        }

        private void Nota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void RespNome_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }
        public static float Soma(float valor1, float valor2, float valor3, float valor4)
        {
            float valor = valor1 + valor2 + valor3 + valor4;
            return valor;
        }

        public static float Subtracao(float valor1, float valor2, float valor3, float valor4)
        {
            float valor = valor1 - valor2 - valor3 - valor4;
            return valor;
        }

        public static float Multiplicacao(float valor1, float valor2, float valor3, float valor4)
        {
            float valor = valor1 * valor2 * valor3 * valor4;
            return valor;
        }

        public static float Divisao(float valor1, float valor2, float valor3, float valor4)
        {
            float valor = valor1 / valor2 / valor3 / valor4;
            return valor;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
