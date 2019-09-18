using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;

            string operador;

            Console.WriteLine("Digite um número.");
            num1 = Convert.ToInt32 (Console.ReadLine()); //int.Parse (Converte automáticamente)

            Console.WriteLine("Digite outro número.");
            num2 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Digite o operador aritmético.");
            Console.WriteLine("Escreva exatamente desta forma: divisao, multiplicacao, soma, subtracao");
            operador = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} = {num1 + num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 - num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 / num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 * num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 % num2} ");
            
            /*string divisao;
            string multiplicacao;
            string soma;
            string subtracao;

            if (operador == soma)
            {
                Console.WriteLine("O Resultado é: " + num1 + num2)
            }*/

            


        }
    }
}
