using System;

namespace exercicio13 {
    class Program {
        static void Main (string[] args) {
            //equilatero = 3 iguais
            //isosceles = 2 iguais
            //escaleno = todos diferentes.

            System.Console.WriteLine ("Digite o 1° lado de um triângulo: ");
            double lado1 = Convert.ToDouble (Console.ReadLine ());

            System.Console.WriteLine ("Digite o 2° lado de um triângulo: ");
            double lado2 = Convert.ToDouble (Console.ReadLine ());

            System.Console.WriteLine ("Digite o 3° lado de um triângulo: ");
            double lado3 = Convert.ToDouble (Console.ReadLine ());

            if(lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado1 + lado2)){

                if(lado1 == lado2 && lado1 == lado3 || lado2 == lado1 && lado2 == lado3 || lado3 == lado1 && lado3 == lado2){
                    System.Console.WriteLine("Seu triângulo é um equilatero (3 lados iguais).");
                }       
                else if(lado1 != lado2 && lado1 != lado3 || lado2 != lado1 && lado2 != lado3 || lado3 != lado1 && lado3 != lado2){
                    System.Console.WriteLine("Seu triângulo é um escaleno (todos os lados são diferentes).");
                }
                else if(lado1 == lado2 && lado1 != lado3 || lado2 == lado1 && lado2 != lado3 || lado3 == lado1 && lado3 != lado2){
                    System.Console.WriteLine("Seu triângulo é um isosceles (2 lados iguais).");
                }
            }
            else{
                System.Console.WriteLine("Algum dos lados não fazem parte de um triangulo.");
            }

        }
    }
}