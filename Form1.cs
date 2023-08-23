using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string texto = nameInput.Text;
            label3.Text = "O seu nome completo é " + texto;

            int.Parse(number1.Text);

            float n1 = float.Parse(number1.Text);
            float n2 = float.Parse(number2.Text);

            var opcao = listBox1.SelectedItem;

            switch (opcao)
            {
                case "Soma":
                    {
                        float result = Soma(n1, n2);
                        resultado.Text = "O resultado da soma entre " + n1 + " e " + n2 + " equivale a " + result;
                        break;
                    }
                case "Subtracao":
                    {
                        float result = Subtracao(n1, n2);
                        resultado.Text = "O resultado da subtração entre " + n1 + " e " + n2 + " equivale a " + result;
                        break;
                    }
                case "Multiplicacao":
                    {
                        float result = Multiplicacao(n1, n2);
                        resultado.Text = "O resultado da multiplicação entre " + n1 + " e " + n2 + " equivale a " + result;
                        break;
                    }
                case "Divisao":
                    {
                        float result = Divisao(n1, n2);
                        resultado.Text = "O resultado da divisão entre " + n1 + " e " + n2 + " equivale a " + result;
                        break;
                    }
                default:
                    {
                        resultado.Text = "Erro! Selecione uma opção válida de cálculo";
                        break;
                    }
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static float Soma(float valor1, float valor2)
        {
            float valor = valor1 + valor2;
            return valor;
        }

        public static float Subtracao(float valor1, float valor2)
        {
            float valor = valor1 - valor2;
            return valor;
        }

        public static float Multiplicacao(float valor1, float valor2)
        {
            float valor = valor1 * valor2;
            return valor;
        }

        public static float Divisao(float valor1, float valor2)
        {
            float valor = valor1 / valor2;
            return valor;
        }
    }
}
