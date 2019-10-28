using System;

namespace exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(0,100);
                System.Console.WriteLine(numeros[i]);
            }
            System.Console.WriteLine();
            
            int maior = numeros[0];
            int menor = numeros[0];
            
            for(int i = 0; i < numeros.Length; i++){
                if(numeros[i] > maior){
                    maior = numeros[i];
                }
                else if (numeros[i] < menor){
                    menor = numeros[i];
                }
            }

            System.Console.WriteLine("Maior: " + maior + ", Menor: " + menor);
        }
    }
}
