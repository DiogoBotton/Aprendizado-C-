using System;

namespace Loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_loteria = new int[6];
            int[] loteria_sorteio = new int[6];

            Console.Clear();
            System.Console.WriteLine("Bem Vindo ao sisteminha de loteria do Diogão!");

            for (int i = 0; i < 6; i++){
            
            System.Console.WriteLine($"Escolha o {i + 1}° número de 0 à 20.");
            numeros_loteria[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            System.Console.WriteLine("Aperte ENTER para sortear os números.");
            Console.ReadLine();
            Console.Clear();
            
            Random sorteio = new Random();
            System.Console.Write("Os números sorteados foram: ");
            for (int i = 0; i < 6; i++){
                loteria_sorteio[i] = sorteio.Next(0,20);
                System.Console.Write(loteria_sorteio[i] + " ");
            }

            System.Console.WriteLine();

            System.Console.Write("Número(s) coincidente(s): ");
            int acertos = 0;
            for (int i = 0; i < 6; i++){
                for (int j = 0; j < 6; j++){
                    if (loteria_sorteio[i] == numeros_loteria[j]){
                        acertos += 1;
                        System.Console.Write(numeros_loteria[j] + " ");
                    }
                }
            }
            System.Console.WriteLine();

            System.Console.WriteLine($"Você acertou {acertos} de 6 números.");


           
            
        }
    }
}
