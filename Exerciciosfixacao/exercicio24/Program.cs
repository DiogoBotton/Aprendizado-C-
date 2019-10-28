using System;

namespace exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[] {0,9,8,7,6,5,4,3,2,1};
            int[] vetor2 = new int[] {1,2,3,4,5,6,7,8,9,0};

            int[] vetorSoma = new int[vetor1.Length];

            for (int i = 0; i < 10; i++){
                vetorSoma[i] = vetor1[i] + vetor2[i];
            }
            
            foreach (int item in vetorSoma)
            {
                System.Console.Write("Soma: " + item + " ");
            }
        }
    }
}
