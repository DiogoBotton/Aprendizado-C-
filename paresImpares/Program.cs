using System;

namespace paresImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; //Número mudado para 1 para não fechar o programa logo na inicialização.
            while (num != 0)  //Enquanto num (número digitado) for DIFERENTE de 0 (ZERO) aplique isto \/, se for igual a zero, ignore a isntruçao (automaticamente encerra o programa)
            {

            Console.WriteLine("Digite um número INTEIRO ou zero para parar.");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0) {
                Console.WriteLine("O número é PAR.");
            }
            else {
                Console.WriteLine("O número é ÍMPAR.");
            }
            }

        }
    }
}
