using System;

namespace Tabuada {
    class Program {
        static void Main (string[] args) {
            //Criar aplicação que imprima impares inteiros de 0 a 100

            /*for (int num = 1; num < 100; num += 2)
            {
                Console.WriteLine(num);
            }
            
            pares:

            for (int num = 0; num < 100; num += 2)
            {
                Console.WriteLine("num");
            }
            
            */

            // À fazer:
            //Tabuada do 5 usando FOR

            int tabuada = 1;
            while ((tabuada >= 1) && (tabuada <= 10)) { //Redundância nesta estrutura while
                
                do {
                    Console.WriteLine ("Qual tabuada você deseja ver? Digite apenas o número (de 1 a 10).");
                    tabuada = Convert.ToInt32 (Console.ReadLine ());

                    if (tabuada == 1) {
                        Console.WriteLine ("Tabuada do 1:");
                        for (int num = 1; num <= 10; num++) {

                            Console.WriteLine ($" 1 * {num} = {num * 1}");
                        }
                    }

                    if (tabuada == 2) {
                        Console.WriteLine ("Tabuada do 2:");
                        for (int num = 1; num <= 10; num++) {

                            Console.WriteLine ($" 1 * {num} = {num * 2}");
                        }
                    }

                    if (tabuada == 3) {
                        Console.WriteLine ("Tabuada do 3:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"3 * {num} = {num * 3}");
                        }
                    }

                    if (tabuada == 4) {
                        Console.WriteLine ("Tabuada do 4:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"4 * {num} = {num * 4}");
                        }
                    }

                    if (tabuada == 5) {
                        Console.WriteLine ("Tabuada do 5:");
                        for (int num = 1; num <= 10; num++) {

                            Console.WriteLine ($" 5 * {num} = {num * 5}");
                        }
                    }

                    if (tabuada == 6) {
                        Console.WriteLine ("Tabuada do 6:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"6 * {num} = {num * 6}");
                        }
                    }

                    if (tabuada == 7) {
                        Console.WriteLine ("Tabuada do 7:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"7 * {num} = {num * 7}");
                        }
                    }

                    if (tabuada == 8) {
                        Console.WriteLine ("Tabuada do 8:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"8 * {num} = {num * 8}");
                        }
                    }

                    if (tabuada == 9) {
                        Console.WriteLine ("Tabuada do 9:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"9 * {num} = {num * 9}");
                        }
                    }

                    if (tabuada == 10) {
                        Console.WriteLine ("Tabuada do 10:");
                        for (int num = 1; num <= 10; num++) {
                            Console.WriteLine ($"10 * {num} = {num * 10}");
                        }
                    }
                } while ((tabuada < 1) || (tabuada > 10));
            }

            //Tabuada do 1 ao 10 usando FOR
        }
    }
}