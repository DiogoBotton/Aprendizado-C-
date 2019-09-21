using System;

namespace mediaFor {
    class Program {
        static void Main (string[] args) {
            double media = 0;
            double soma = 0;

                for (int i = 1; i < 5; i++) {
                    double nota = 0;

                    Console.Write ("Digite a " + i + "° nota do aluno: ");
                    nota = Convert.ToDouble (Console.ReadLine ());

                    soma += nota;
                }
            
            media = soma / 4;

            Console.WriteLine ("A média do aluno é: " + media);
        }
    }
}