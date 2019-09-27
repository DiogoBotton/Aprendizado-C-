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

            //COM MATRIZES / VETORES (quantos numeros pares e impares digitados pelo usuário)

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
            

            //Temperaturas (mostrar a maior e menor média)

            double[] media_temperaturas = new double[12];
            double maior = 0;
            double menor = 0; 

            

            for (int i = 0; i < 12; i++)
            {

                Console.WriteLine($"Digite a média da temperatura do mês {i + 1}:");
                media_temperaturas[i] = Convert.ToDouble(Console.ReadLine());

            }

            maior = media_temperaturas[0]; //Dizendo que as variaveis maior e menor recebem o primeiro índice da matriz.
            menor = media_temperaturas[0];

            for (int i = 0; i < 12; i++)
            {

                if (media_temperaturas[i] > maior)  //Na primeira repetição: Compara o primeiro número da matriz (índice 0) com a varivael MAIOR (que contem o valor do indice 0), falso pois os dois são iguais. 
                {                                   //Na segunda repetição e assim por diante: Compara o índice 1 (se maior) com a variavel MAIOR (que contem o valor do indice 0), se verdadeiro, o valor da variavel[...] 
                    maior = media_temperaturas[i];  //[...]é substituido pelo valor do indice 1, e assim por diante.
                }
                
                else if (media_temperaturas[i] < menor)
                {
                    menor = media_temperaturas[i];
                }
            }

            Console.WriteLine($"A maior média é: {maior} || A menor média é: {menor}");

        }
    }
}