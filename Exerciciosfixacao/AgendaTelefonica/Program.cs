using System;
using System.Collections.Generic;
using AgendaTelefonica.Models;

namespace AgendaTelefonica {
    class Program {
        static void Main (string[] args) {
            List<Registro> listRegistros = new List<Registro> ();

            bool querSair = false;
            //endswith
            do {
                Console.Clear ();

                string opcao = "";
                
                System.Console.WriteLine ("|______Agenda Telefonica:______|");
                System.Console.WriteLine ("    Digite uma opção abaixo:     ");
                System.Console.WriteLine ("1 - Cadastrar.");
                System.Console.WriteLine ("2 - Remover cadastro.");
                System.Console.WriteLine ("3 - Busca específica.");
                System.Console.WriteLine ("4 - Listar registros.");
                System.Console.WriteLine ("0 - Sair do programa.");
                System.Console.WriteLine ("_________________________________");
                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        //TODO: Fazer validação de digitação com ConsoleKey.
                        Cadastro (listRegistros);

                        break;

                    case "2":
                        RemoverCadastro (listRegistros);
                        break;

                    case "3":
                        BuscaEspecifica (listRegistros);
                        break;

                    case "4":
                        ListarRegistros (listRegistros);
                        break;

                    case "0":
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Inválido.");
                        Console.ReadLine ();

                        break;
                }

            } while (!querSair);
        }
        public static void Cadastro (List<Registro> listRegistros) {
            Console.Clear ();
            bool nomeJaExiste = false;
            string nome = "";
            do {
                System.Console.Write ("Entre com o nome da pessoa: ");
                nome = Console.ReadLine ();

                if (listRegistros.Count != 0) {
                    foreach (Registro item in listRegistros) {
                        if (item.Nome == nome) {
                            nomeJaExiste = true;
                            System.Console.WriteLine ("Este nome já existe, tente novamente.");
                            Console.ReadLine ();

                            break;
                        } else {
                            nomeJaExiste = false;
                        }

                    }
                }
            } while (nomeJaExiste);

            System.Console.Write ("Entre com o telefone da pessoa: ");
            string tel = Console.ReadLine ();
            System.Console.Write ("Entre com a data de nascimento: ");
            string data = Console.ReadLine ();

            Registro registro = new Registro (nome, tel, data);

            listRegistros.Add (registro);

            System.Console.WriteLine ("Cadastrado com sucesso!");
            Console.ReadLine ();

        }
        public static void RemoverCadastro (List<Registro> listRegistros) {
            Console.Clear ();

            System.Console.WriteLine ("Digite o NOME da pessoa que deseja remover: ");
            string nome = Console.ReadLine ();
            if (listRegistros.Count != 0) {
                foreach (Registro item in listRegistros) {
                    if (item.Nome == nome) {

                        listRegistros.Remove (item);
                        System.Console.WriteLine ($"Registro com identificação [{nome}] foi removido.");
                        Console.ReadLine ();
                        break;
                    } else {
                        System.Console.WriteLine ("Este nome não existe no registro.");
                        Console.ReadLine ();
                    }
                }
            } else {
                System.Console.WriteLine ("Não há registros na Agenda.");
                Console.ReadLine ();

            }

        }
        public static void BuscaEspecifica (List<Registro> listRegistros) {
            Console.Clear ();
            System.Console.Write ("Digite o nome ou a data de nascimento da pessoa: ");
            string nomeOUdata = Console.ReadLine ();
            if (listRegistros.Count != 0) {
                foreach (Registro item in listRegistros) {
                    if (item.Nome == nomeOUdata || item.Aniversario == nomeOUdata) {

                        System.Console.WriteLine ($"Nome: {item.Nome}");
                        System.Console.WriteLine ($"Data de nascimento: {item.Aniversario}");
                        System.Console.WriteLine ($"Telefone: {item.Telefone}");
                        Console.ReadLine ();
                        break;
                    } else {
                        System.Console.WriteLine ("Este nome não consta nos registros.");
                        Console.ReadLine ();
                    }
                }
            } else {
                System.Console.WriteLine ("Não há registros na Agenda.");
                Console.ReadLine ();

            }
        }
        public static void ListarRegistros (List<Registro> listRegistros) {
            Console.Clear ();
            int count = 0;
            
            if (listRegistros.Count != 0) {

                foreach (Registro item in listRegistros) {
                    System.Console.WriteLine ($"Registro ID: {count}: {item.Nome}");
                    System.Console.WriteLine ($"    Nascimento: {item.Aniversario}");
                    System.Console.WriteLine ($"    Telefone: {item.Telefone}");
                    Console.ReadLine ();

                    count++;
                }
            } else {
                System.Console.WriteLine ("Não há registros na Agenda.");
                Console.ReadLine ();

            }
        }
    }
}