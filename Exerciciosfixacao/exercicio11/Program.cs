using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2];

            for (int i = 0; i < 2; i++)
            {
                System.Console.Write("Digite um nome (2x): ");
                nomes[i] = Console.ReadLine();
            }

            Array.Sort(nomes);
            
            for (int i = 0; i < nomes.Length; i++)
            {
            System.Console.WriteLine("Nomes: " + nomes[i]);
            }
        }
    }
}
