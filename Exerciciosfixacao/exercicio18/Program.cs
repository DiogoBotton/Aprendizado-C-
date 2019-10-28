using System;

namespace exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            for (int i = limite; i >= 0 ; i--)
            {
                if((i % 2) == 1){
                    System.Console.Write(i + " ");
                }
            }

        }
    }
}
