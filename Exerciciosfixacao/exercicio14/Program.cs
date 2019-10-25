using System;

namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Entre com um verbo no infinitivo: ");
            string verbo = Console.ReadLine();
            
            if(verbo.EndsWith("ar") || verbo.EndsWith("er") || verbo.EndsWith("ir")){
                if(verbo.EndsWith("ar")){
                    System.Console.WriteLine(verbo + " é um verbo da 1º conjugação terminado em ar.");
                }
                else if(verbo.EndsWith("er")){
                    System.Console.WriteLine(verbo + " é um verbo da 2º conjugação terminado em er.");
                }
                else if(verbo.EndsWith("ir")){
                    System.Console.WriteLine(verbo + " é um verbo da 3º conjugação terminado em ir.");
                }
            }
            else{
                System.Console.WriteLine("O verbo não esta no infinitivo.");
            }

        }
    }
}
