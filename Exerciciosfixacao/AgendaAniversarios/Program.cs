using System;
using System.Collections.Generic;

namespace AgendaAniversarios {
    class Program {
        static void Main (string[] args) {
            bool querSair = false;

            Dictionary<string, DateTime> agenda = new Dictionary<string, DateTime> ();
            do {
                Console.Clear ();

                string opcao = "";

                System.Console.WriteLine ("|____Agenda de Aniversários:____|");
                System.Console.WriteLine ("    Digite uma opção abaixo:     ");
                System.Console.WriteLine ("1 - Cadastrar aniversário.");
                System.Console.WriteLine ("2 - Remover cadastro.");
                System.Console.WriteLine ("3 - Data de aniversario específica.");
                System.Console.WriteLine ("4 - Listar aniversários.");
                System.Console.WriteLine ("0 - Sair do programa.");
                System.Console.WriteLine ("_________________________________");
                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        Cadastrar(agenda);
                        break;

                    case "2":
                        RemoverCadastro(agenda);
                        break;

                    case "3":
                        ProcurarNoDicionario(agenda);
                        break;
                    case "4":
                        ListarAniversarios(agenda);
                        break;  

                    case "0":
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Inválido.");
                        break;
                }

            } while (!querSair);
        }
        public static void Cadastrar (Dictionary<string, DateTime> agenda) {
            Console.Clear ();

            System.Console.Write ("Entre com o nome do aniversariante: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("Entre com a data de aniversário: ");
            DateTime niver = Convert.ToDateTime (Console.ReadLine ());

            agenda.Add (nome, niver);

            System.Console.WriteLine ("Cadastrado com sucesso.");
        }
        public static void RemoverCadastro (Dictionary<string, DateTime>  agenda) {
            Console.Clear ();

            System.Console.WriteLine ("Digite o nome da pessoa que deseja remover.");
            string nomeRemove = Console.ReadLine ();

            if (agenda.Remove (nomeRemove)) {
                System.Console.WriteLine ("Cadastro removido.");
                Console.ReadLine ();

            } else {
                System.Console.WriteLine ("Cadastro não encontrado.");
                Console.ReadLine ();

            }
        }
        public static void ProcurarNoDicionario (Dictionary<string, DateTime>  agenda) {
            Console.Clear ();

            System.Console.Write ("Digite o nome do aniversariante: ");
            string nomeData = Console.ReadLine ();

            if (agenda.ContainsKey (nomeData)) {

                DateTime listarData = agenda[nomeData];
                System.Console.WriteLine ($"Nome: {nomeData}    Data: {listarData}.");
                Console.ReadLine ();

            } else {
                System.Console.WriteLine ("Cadastro não encontrado.");
                Console.ReadLine ();

            }
        }
        public static void ListarAniversarios (Dictionary<string, DateTime>  agenda) {
            Console.Clear ();

            foreach (string item in agenda.Keys) {
                System.Console.Write ("Nome: " + item);
                DateTime data = agenda[item];
                System.Console.WriteLine ("       Data: " + data);
            }

            Console.ReadLine ();
        }
    }
}