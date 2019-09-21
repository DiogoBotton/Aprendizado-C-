using System;

namespace paresImpares {
    class Program {
        static void Main (string[] args) {
            /*int num = 1; //Número mudado para 1 para não fechar o programa logo na inicialização.
            while (num != 0)  //Enquanto num (número digitado) for DIFERENTE de 0 (ZERO) aplique isto \/, se for igual a zero, ignore a isntruçao (automaticamente encerra o programa)
            {

            Console.WriteLine("Digite um número INTEIRO ou zero para parar.");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0) {
                Console.WriteLine("O número é PAR.");
            }
            else {
                Console.WriteLine("O número é ÍMPAR.");
            }
            }*/

            //Números ìmpares de 0 a 100

            string escolherPrograma = "";

            while (escolherPrograma != "0") {
                Console.WriteLine(" ");
                Console.WriteLine("Seja Bem Vindo(a) ao programinha de matemática do Diogão!!");
                Console.WriteLine(" ");
                Console.WriteLine("Você esta no MENU do programa. Siga as instruções abaixo para utiliza-lo.");
                Console.WriteLine(" ");
                Console.WriteLine ("1. Programa: Digite paresOUimpares para ver sequencias de números ìmpares e pares de 0 à 100. ");
                Console.WriteLine ("2. Programa: Digite numeros e siga as instruções. Sobre a representação de cada número digitado no console (se é ímpar ou par).");
                Console.WriteLine ("3. Programa: Digite tabuada para ver a tabuada do 1 ao 10.");
                Console.WriteLine ("5. Opção: OU digite 0 para fechar o programa.");
                escolherPrograma = Console.ReadLine ();

                //Aqui abre um bloco de instruções. (paresOUimpares)---------------------------------------
                if (escolherPrograma == "paresOUimpares") {

                        int parImpar = 5;

                        while ((parImpar != 0)) {
                        Console.WriteLine ("1. Opção: Digite 1 para ver os números ÍMPARES de 0 a 100.");
                        Console.WriteLine ("2. Opção: Digite 2 para ver os números PARES de 0 a 100.");
                        Console.WriteLine ("5. Opção: OU digite 0 para VOLTAR ao menu.");
                        parImpar = Convert.ToInt32(Console.ReadLine());

                        if (parImpar == 1) {

                            Console.WriteLine ("Números Ímpares:");
                            for (int num = 1; num < 100; num += 2) {
                                Console.WriteLine (num);
                            }
                        } 
                        else if (parImpar == 2) {     
                            Console.WriteLine ("Números Pares");
                            for (int num = 0; num <= 100; num += 2) {
                                Console.WriteLine (num);
                            }
                        }
                    }
                }
                
                //Aqui abre outro bloco de instruções. (numeros)---------------------------------------------
                else if (escolherPrograma == "numeros") {
                    int num = 1;
                    while ((num != 0)) {

                        Console.WriteLine ("1. Opção: Digite um número DIFERENTE de 0.");
                        Console.WriteLine ("2: Opção: OU digite 0 para VOLTAR ao menu.");
                        num = Convert.ToInt32 (Console.ReadLine ());

                        if ((num % 2) == 0) {
                            Console.WriteLine ("O número é PAR.");
                        } else {        
                            Console.WriteLine ("O número é ÍMPAR.");
                        }
                    }
                }

                //Aqui abre outro bloco de instruções. (tabuada)---------------------------------------------
                else if (escolherPrograma == "tabuada") {

                    int tabuada = 1;
                    while ((tabuada != 0)) {
                        
                        
                            Console.WriteLine ("Qual tabuada você deseja ver? Digite apenas um número de 1 a 10.");
                            Console.WriteLine ("2. Opção: OU digite 0 para VOLTAR ao menu.");
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
                        
                    }
                }







            }//Estrutura de repetição para o programa





        }//Main
    }// Class Program
}//Namespace