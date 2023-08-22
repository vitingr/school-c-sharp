using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual operação você deseja realizar agora? \n");
            Console.WriteLine("Adição");
            Console.WriteLine("Subtração");
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Divisão");

            Console.Write("\nOpção: ");
            int operacao = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = 0.0f;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = adicao(n1, n2);
                        break;
                    }
                case 2:
                    {
                        resultado = subtracao(n1, n2);
                        break;
                    }
                case 3:
                    {
                        resultado = multiplicacao(n1, n2);
                        break;
                    }
                case 4:
                    {
                        resultado = divisao(n1, n2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Erro digite um valor válido");
                        break;
                    }

            }

            Console.WriteLine("O resultado da operação entre os valores {0} e {1} equivale a {2}", n1, n2, resultado);

            Console.ReadLine();

        }

        public static float adicao(float n1, float n2) 
        {
            float result = n1 + n2;
            return result;
        }

        public static float subtracao(float n1, float n2)
        {
            float result = n1 - n2;
            return result;
        }

        public static float multiplicacao(float n1, float n2)
        {
            float result = n1 * n2;
            return result;
        }

        public static float divisao(float n1, float n2)
        {
            float result = n1 / n2;
            return result;
        }
    }
}
