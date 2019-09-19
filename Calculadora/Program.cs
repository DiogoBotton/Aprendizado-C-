using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            string operador;
            Console.WriteLine("Para percentual, primeiro digite a porcentagem e depois o número.");
            Console.WriteLine("Modelo: X% de X.");
            Console.WriteLine("Digite um número.");
            num1 = Convert.ToInt32 (Console.ReadLine()); //int.Parse (Converte automáticamente)

            Console.WriteLine("Digite outro número.");
            num2 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Digite o operador aritmético.");
            Console.WriteLine("Escolha entre: + , - , / , * , % .");
            operador = Console.ReadLine();

            /*Console.WriteLine($"{num1} + {num2} = {num1 + num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 - num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 / num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 * num2} ");
            Console.WriteLine($"{num1} + {num2} = {num1 % num2} ");*/
            
            double resultadoDiv, resultadoMult, resultadoSoma, resultadoSubt, resultadoPerc; //Por padrão o valor é 0 (ZERO)

            resultadoDiv = num1 / num2;
            resultadoMult = num1 * num2; 
            resultadoSoma = num1 + num2; 
            resultadoSubt = num1 - num2;
            resultadoPerc = (num1 / 100) * num2;

            if(operador == "+")
            {
                Console.WriteLine("O Resultado é: " + resultadoSoma);
            }
            else if (operador == "/")
            {
                Console.WriteLine("O Resultado é: " + resultadoDiv);
            }
            else if (operador == "*")
            {
                Console.WriteLine("O Resultado é: " + resultadoMult);
            }
            else if (operador == "-")
            {
                Console.WriteLine("O Resultado é: " + resultadoSubt);
            }
            else if (operador == "%")
            {
                Console.WriteLine("O Resultado é: " + resultadoPerc);
            }
            //trycatch
        }
    }
}
