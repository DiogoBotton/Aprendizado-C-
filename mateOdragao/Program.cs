using System;
using mateOdragao.Models;

namespace mateOdragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaodesistiu = true;
            do
            {
                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("         Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine("1 - Iniciar Jogo.");
                System.Console.WriteLine("0 - Sair do Jogo.");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Artemis";
                        guerreiro.Sobrenome = "Lire";
                        guerreiro.CidadeNatal = "Eryuell";
                        guerreiro.DataNascimento = DateTime.Parse("27/09/1445");
                        guerreiro.FerramentaProtecao = "Adaga";
                        guerreiro.FerramentaAtaque = "Arco e Flecha";
                        guerreiro.Forca = 1;
                        guerreiro.Destreza = 4;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*Inicio - Primeiro Diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, chegou sua hora, vim lhe derrotar!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humana tolinha, quem pensas que é? ");
                        System.Console.WriteLine();

                        System.Console.WriteLine("Aperte ENTER para prosseguir o diálogo.");
                        Console.ReadLine();
                        /*Fim - Primeiro Diálogo */

                        /*Inicio - Segundo Diálogo */
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética.");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... Fritar-te-ei e devorar-te-ei, primata insolente!");
                        System.Console.WriteLine("MESTRE: Tá na hora do Show!");
                        System.Console.WriteLine();

                        System.Console.WriteLine("Aperte ENTER para prosseguir o diálogo.");
                        Console.ReadLine();
                        /*Fim - Segundo Diálogo */

                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false; //ler como uma pergunta. Depois do (?) é a condição.

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;
                        

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Guerreiro ***");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine("1 - Atacar.");
                            System.Console.WriteLine("2 - Fugir.");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();   //Gerador de números aleatórios objeto Random()
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa MALDJEETA!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5); //5 é a força da arma.  || dragao.Vida -= (poderAtaqueGuerreiro + 5)

                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrou troxa!");
                                    }

                                    System.Console.WriteLine();

                                    System.Console.WriteLine("Aperte ENTER para prosseguir.");
                                    Console.ReadLine();


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu não sou pareo para seu poder! Estou indo embora.");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humana desprezível!");
                                    jogadorNaoCorreu = false;
                                    break;

                            }
                            
                        }

                        while ((guerreiro.Vida > 0) && (dragao.Vida > 0) && jogadorNaoCorreu)
                        {
                            //VEZ DO DRAGÃO
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            System.Console.WriteLine("O dragão tentou te atacar.");
                            

                            Random geradorNumeroAleatorio = new Random();   //Gerador de números aleatórios objeto Random()
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);


                            int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal)
                            {
                                System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Leva essa pra ficar esperta, humana...");
                                guerreiro.Vida -= dragao.Forca;

                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                            }
                            else
                            {
                                System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Dragãozinho cego! Você errou feio!");
                            }

                            System.Console.WriteLine();

                            System.Console.WriteLine("Aperte ENTER para prosseguir.");
                            Console.ReadLine();

                            Console.Clear();
                            
                            //VEZ DO GUERREIRO
                            System.Console.WriteLine("*** Turno do Guerreiro ***");
                            System.Console.WriteLine("Escolha uma ação:");
                            System.Console.WriteLine("1 - Atacar.");
                            System.Console.WriteLine("2 - Fugir.");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagartixa MALDJEETA!");
                                        dragao.Vida = dragao.Vida - (poderAtaqueGuerreiro + 5); //5 é a força da arma.  || dragao.Vida -= (poderAtaqueGuerreiro + 5)

                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrou troxa!");
                                    }

                                    System.Console.WriteLine();

                                    System.Console.WriteLine("Aperte ENTER para prosseguir.");
                                    Console.ReadLine();


                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu não sou pareo para seu poder! Estou indo embora.");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humana desprezível!");
                                    jogadorNaoCorreu = false;
                                    break;

                            }
                        }
                    break;

                    case "0":
                        jogadorNaodesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine("Comando Inválido.");
                        break;
                }
            } while (jogadorNaodesistiu);
        }
    }
}
