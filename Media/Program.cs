using System;

namespace Media {
    class Program {
        static void Main (string[] args) {
            double num1 = -1;
            double num2 = -1;
            double num3 = -1;
            double num4 = -1;
            double media;
            
            while ((num1 < 0) || (num1 > 10)) { //Enquanto
            Console.Write ("Digite a 1° nota: ");
            num1 = double.Parse (Console.ReadLine ()); //ReadLine retorna STRING (texto)
                                                    //Forçar CONVERSÂO de STRING para o tipo de váriavel, no caso double.                                     
            }
            
            while ((num2 < 0) || (num2 > 10)) {

            Console.Write ("Digite a 2° nota: ");
            num2 = double.Parse (Console.ReadLine ());
            }
            
            while ((num3 < 0) || (num3 > 10)) {

            Console.Write ("Digite a 3° nota: ");
            num3 = double.Parse (Console.ReadLine ());
            }
            
            while ((num4 < 0) || (num4 > 10)) {

            Console.Write ("Digite a 4° nota: ");
            num4 = double.Parse (Console.ReadLine ());
            }         

            media = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine ("A média é: " + media);

            if ((media >= 7) && (media < 9)) //"Intervalo" entre 7 e 8,9.|| Se média for maior ou igual à 7 e (conjunção) media for menor que 9.
            { // Caso um deles for FALSO, a sentença inteira é FALSA. Se os dois forem verdadeiros, ou seja, o número estiver entre 7 e 8,9, essa sentença é verdadeira.
                Console.Write ("O aluno foi APROVADO.");
            } else if (media >= 9) {
                Console.WriteLine ("O aluno foi APROVADO, dê um chocolate à ele!");
            } else {
                Console.WriteLine ("O aluno foi REPROVADO.");
            }

            /*Console.WriteLine($"Calculo:{num1} + {num2} + {num3} + {num4} / 4 = {(num1 + num2 + num3 + num4) / 4} (Média)");*/

        }
    }
}