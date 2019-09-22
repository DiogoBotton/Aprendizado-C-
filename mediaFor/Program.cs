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

            if ((media >= 7) && (media < 9)) //"Intervalo" entre 7 e 8,9.|| Se média for maior ou igual à 7 e (conjunção) media for menor que 9.
            {                                // Caso um deles for FALSO, a sentença inteira é FALSA. Se os dois forem verdadeiros, ou seja, o número estiver entre 7 e 8,9, essa sentença é verdadeira.
                Console.Write ("O aluno foi APROVADO.");
            } else if (media >= 9) {
                Console.WriteLine ("O aluno foi APROVADO, dê um chocolate à ele!");
            } else {
                Console.WriteLine ("O aluno foi REPROVADO.");
            }
        }
    }
}