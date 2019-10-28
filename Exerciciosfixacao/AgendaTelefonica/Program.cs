using System;
using System.Collections.Generic;
using AgendaTelefonica.Models;

namespace AgendaTelefonica {
    class Program {
        static void Main (string[] args) {
            List<Registro> listRegistros = new List<Registro> ();

            bool querSair = false;

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

            string tel = "";
            //string tel = Console.ReadLine ();

            System.Console.Write ("Entre com o telefone da pessoa: ");
            tel = ValidacaoKeyTel (tel);

            System.Console.WriteLine ();

            string data = "";
            System.Console.Write ("Entre com a data de nascimento: ");
            data = ValidacaoKeyData (data);

            Registro registro = new Registro (nome, tel, data);

            listRegistros.Add (registro);

            System.Console.WriteLine ();

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

        } //VSauce
        public static void BuscaEspecifica (List<Registro> listRegistros) {
            Console.Clear ();
            System.Console.Write ("Digite o nome ou a data de nascimento da pessoa: ");
            string nomeOUdata = Console.ReadLine ();

            bool nomeExiste = false;
            if (listRegistros.Count != 0) {
                int index = 0;
                foreach (Registro item in listRegistros) {
                    if (item.Nome == nomeOUdata || item.Aniversario == nomeOUdata) {
                        nomeExiste = true;

                        break;
                    } else {
                        nomeExiste = false;
                    }
                    index++;
                }

                if (nomeExiste) {
                    var registro = listRegistros[index];
                    System.Console.WriteLine ($"Nome: {registro.Nome}");
                    System.Console.WriteLine ($"Data de nascimento: {registro.Aniversario}");
                    System.Console.WriteLine ($"Telefone: {registro.Telefone}");
                    Console.ReadLine ();
                } else {
                    System.Console.WriteLine ("Este nome não consta nos registros.");
                    Console.ReadLine ();
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
                    System.Console.WriteLine ($"Registro ID {count}: {item.Nome}");
                    System.Console.WriteLine ($"    Nascimento: {item.Aniversario}");
                    System.Console.WriteLine ($"    Telefone: {item.Telefone}");
                    count++;
                }
                Console.ReadLine();
                
            } else {
                System.Console.WriteLine ("Não há registros na Agenda.");
                Console.ReadLine ();

            }
        }
        public static string ValidacaoKeyTel (string tel) {
            bool telEnterFinish = false;
            do {
                var key = Console.ReadKey (true).Key;

                switch (key) {
                    case ConsoleKey.D0:
                        Console.Clear ();

                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "0";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);
                        break;

                    case ConsoleKey.D1:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "1";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D2:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "2";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D3:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "3";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D4:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "4";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D5:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "5";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D6:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "6";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D7:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "7";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D8:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "8";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;

                    case ConsoleKey.D9:
                        Console.Clear ();
                        if (tel.Length == 4) {
                            tel += "-";
                        }
                        if (tel.Length == 9) {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                            continue;
                        }
                        tel += "9";
                        System.Console.Write ("Entre com o telefone da pessoa: " + tel);;
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear ();
                        if (tel.Length > 0) {

                            tel = tel.Remove (tel.Length - 1);
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);
                        } else {
                            System.Console.Write ("Entre com o telefone da pessoa: " + tel);
                        }
                        break;
                    case ConsoleKey.Enter:
                        telEnterFinish = true;
                        break;
                }

            } while (!telEnterFinish);

            return tel;
        }
        public static string ValidacaoKeyData (string data) {
            bool dataEnterFinish = false;
            do {
                var key = Console.ReadKey (true).Key;
                switch (key) {
                    case ConsoleKey.D0:
                        Console.Clear ();

                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "0";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D1:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "1";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "2";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "3";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D4:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "4";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D5:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "5";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D6:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "6";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D7:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "7";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D8:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "8";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;

                    case ConsoleKey.D9:
                        Console.Clear ();
                        if (data.Length == 2) {
                            data += "/";
                        }
                        if (data.Length == 5) {
                            data += "/";
                        }
                        if (data.Length == 10) {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                            continue;
                        }
                        data += "9";
                        System.Console.Write ("Entre com a data de nascimento: " + data);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear ();
                        if (data.Length > 0) {

                            data = data.Remove (data.Length - 1);
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                        } else {
                            System.Console.Write ("Entre com a data de nascimento: " + data);
                        }
                        break;
                    case ConsoleKey.Enter:
                        dataEnterFinish = true;
                        break;

                }
            } while (!dataEnterFinish);
            return data;
        }
    }
}