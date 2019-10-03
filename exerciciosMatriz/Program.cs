using System;

namespace exerciciosMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1°
            /*Console.WriteLine("Digite o tamanho do vetor.");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tamanho];

            for(int i = 0; i < tamanho; i++){

            System.Console.WriteLine($"Digite o {i + 1}° número.");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Console.WriteLine("Os números são: ");
            
            int cont = 1;
            foreach (int elemento in numeros){
                System.Console.WriteLine($"{cont}° número: " + elemento);
                cont++;
            }*/

            // 2°

            int[] sorteio = new int[10];
            int cont = 0;
            

            Random aleatorio = new Random();

            foreach(int elemento in sorteio){   
            sorteio[cont] = aleatorio.Next(0,50);
            cont++;
            }

            System.Console.Write("Números pares: ");
            for(int i = 0; i < sorteio.Length; i++){
                if ((sorteio[i] % 2) == 0){
                System.Console.Write(sorteio[i] + " ");
                }
            }
            System.Console.WriteLine();

            System.Console.Write("Números ímpares: ");
            for(int i = 0; i < sorteio.Length; i++){
                if ((sorteio[i] % 2) == 1){
                System.Console.Write(sorteio[i] + " ");
                }
            }




            

        }
    }
}
