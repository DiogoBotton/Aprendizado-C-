using System;
using System.Collections.Generic;
using BandaRock.Interfaces;
using BandaRock.Models;

namespace BandaRock {
    enum FormacaoEnum : int {
        TRIO = 3,
        QUARTETO
        //QUINTETO
    }
    enum InstrumentosEnum : int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    }
    enum CategoriaEnum : int {
        HARMONIA,
        MELODIA,
        PERCURSSAO
    }
    class Program {
        static void Main (string[] args) {
            string[] ItensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));
            string[] ItensMenuCategoria = Enum.GetNames (typeof (CategoriaEnum));

            int opcaoFormacaoSelecionada = 0;
            var opcoesFormacao = new List<string> () {
                "   -0                  ",
                "   -1             "
                //"   -2             "
            };

            bool querSair = false;
            do {
                //bool formacaoEscolhida = false;
                Console.Clear ();
                System.Console.WriteLine ("|____Banda de Rock____|");
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine (" Escolha uma formação");
                Console.ResetColor ();
                System.Console.WriteLine ("|_____________________|");

                for (int i = 0; i < opcoesFormacao.Count; i++) {
                    string titulo = ItensMenuPrincipal[i];
                    if (opcaoFormacaoSelecionada == i) {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        System.Console.WriteLine (opcoesFormacao[opcaoFormacaoSelecionada].Replace ("-", ">").Replace (i.ToString (), titulo));
                        Console.ResetColor ();
                    } else {
                        System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                    }
                }

                var key = Console.ReadKey(true).Key; // VAR deduz o tipo da variável automaticamente, pela informação que é passada para ela (key).
                //Readkey (TRUE) fica monitorando o teclado 
                switch (key) {
                    case ConsoleKey.UpArrow:
                        opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada = opcoesFormacao.Count -1 : --opcaoFormacaoSelecionada;
                        break;
                    case ConsoleKey.DownArrow:
                        opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada = 0 : ++opcaoFormacaoSelecionada;
                        break;
                    case ConsoleKey.Enter:
                        //formacaoEscolhida = true;
                        break;
                }

            } while (!querSair);
        }
    }
}