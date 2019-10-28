using System;

namespace exercicio25 {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("tamanho vetor1: ");
            int tamanho1 = Convert.ToInt32 (Console.ReadLine ());
            System.Console.WriteLine ("tamanho vetor2: ");
            int tamanho2 = int.Parse (Console.ReadLine ());

            int[] vetor1 = new int[tamanho1];
            int[] vetor2 = new int[tamanho2];

            Random random = new Random ();

            for (int i = 0; i < vetor1.Length; i++) {
                vetor1[i] = random.Next (0, 100);
            }
            for (int i = 0; i < vetor2.Length; i++) {
                vetor2[i] = random.Next (0, 100);
            }

            int[] vetorUniao = new int[tamanho1+tamanho2];

            int count = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetorUniao[i] = vetor1[i];
                count = i;
            }
            count += 1;
            for (int i = 0; i < vetor2.Length; i++)
            {
                vetorUniao[count] = vetor2[i];
                count++;
            }
            Console.Clear();
            
            System.Console.WriteLine("Vetor 1: ");
            
            foreach (int item in vetor1)
            {
                System.Console.Write(item + " ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Vetor 2: ");
            
            foreach (int item in vetor2)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Vetor União: ");

            foreach (int item in vetorUniao)
            {
                System.Console.Write(item + " ");
            }


        }
    }
}