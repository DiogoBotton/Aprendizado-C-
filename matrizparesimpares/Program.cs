using System;

namespace matrizparesimpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_armazenados = new int[6];

            int par = 0;
            int impar = 0;

            //APENAS FOR
            /*
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine("Digite um numero");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num % 2) == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1; 
                }
            }
            */

            //COM MATRIZES / VETORES

            /*
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine("Digite um numero");
                numeros_armazenados[i] = Convert.ToInt32(Console.ReadLine());

                if ((numeros_armazenados[i] % 2) == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }
            Console.WriteLine($"Números pares: {par} || Números ímpares: {impar}");
            */

            //À FAZER: 

            int[] media_temperaturas = new int[12];
            int calculo = 0;
            int maior = 0;
            int menor = 0;

            for (int j = 0; j < 12; j++)
            {
                
                for (int i = 0; i < 12; i++)
                {

                    Console.WriteLine($"Digite a média da temperatura do mês {i + 1}:");
                    media_temperaturas[i] = Convert.ToInt32(Console.ReadLine());

                }
                if (media_temperaturas[] > media_temperaturas[j]){
                    maior = ;
                    Console.WriteLine();
                }

            }
            Console.WriteLine($"A maior média é: {maior} || A menor média é: {menor}");






        }
    }
}
