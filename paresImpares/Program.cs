using System;

namespace paresImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1; //Número mudado para 1 para não fechar o programa logo na inicialização.
            while (num != 0) //Fecha o programa.
            {
                Console.WriteLine("Digite um número ou zero para parar.");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num % 2) == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }
            }
        }
    }
}
