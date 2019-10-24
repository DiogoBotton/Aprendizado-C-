using System;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
            Console.Write("Digite um número (3x): ");
            num[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
            System.Console.WriteLine(num[i]);
            }

        }
    }
}
