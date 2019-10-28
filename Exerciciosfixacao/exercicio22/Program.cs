using System;

namespace exercicio22 {
    class Program {
        static void Main (string[] args) {
            Random random = new Random ();

            int[, ] numeros = new int[3, 3];
            int num = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    numeros[i, j] = random.Next (0, 50);
                    num = numeros[i,j];
                    System.Console.WriteLine($"linha: {i+1}, coluna {j+1}: {num}");
                }
                System.Console.WriteLine();
            }

            int soma = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    soma += numeros[i, j];
                }
            }
            System.Console.WriteLine("Soma total: " + soma);
        }
    }
}