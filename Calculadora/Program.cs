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

            /*Console.WriteLine($"{num1} + {num2} = {num1 + num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 - num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 / num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 * num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 % num2} ");*/
            
            float resultadoDiv, resultadoMult, resultadoSoma, resultadoSubt; //Por padrão o valor é 0 (ZERO)

            resultadoDiv = num1 / num2;
            resultadoMult = num1 * num2; 
            resultadoSoma = num1 + num2; 
            resultadoSubt = num1 - num2;

            if (operador == "soma")
            {
                Console.WriteLine("O Resultado é: " + resultadoSoma);
            }
            else if(operador == "divisao")
            {
                Console.WriteLine("O Resultado é: " + resultadoDiv);
            }
            else if (operador == "multiplicacao")
            {
                Console.WriteLine("O Resultado é: " + resultadoMult);
            }
            else if (operador == "subtracao")
            {
                Console.WriteLine("O Resultado é: " + resultadoSubt);
            }
        }
    }
}
