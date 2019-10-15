using System;
//using System.Collections.Generic;
using System.IO;
using Senaizinho.Models;
namespace Senaizinho {
    class Program {
        static void Main (string[] args) {
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];

            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            bool querSair = true;

            //List<Aluno> alunosMatriculados = new List<Aluno>();
            //List<Sala> salasExistentes = new List<Sala>();
            string fileName = "ListaAlunosSalas.csv";
            string FilePath = ".\\" + fileName;

            string fileName2 = "ListaSalas.csv";
            string FilePath2 = ".\\" + fileName2;

            //AlunosMatriculados = InitList (FilePath, alunos);
            //PROBLEMA RESOLVIDO: Se o aluno não for alocado, erro de execução, pois numSala recebe string convertida para int, tenta ler string e não funciona.

            //Lista de Alunos:
            try {
                string[] lista = File.ReadAllLines (@FilePath);
                int count = 0;
                foreach (string linha in lista) {
                    string[] itens = linha.Split (",");
                    string nome = itens[0].Replace ("\"", "");
                    int numSala = Convert.ToInt32 (itens[1].Replace ("\"", ""));
                    DateTime data = DateTime.Parse (itens[2].Replace ("\"", ""));

                    alunos[count] = new Aluno (nome, data);
                    alunos[count].AlunoNumSala (numSala);
                    //alunosMatriculados.Add(alunos[count]);

                    count++;
                    alunosCadastrados++;
                }
            } catch (IOException erro) {
                System.Console.WriteLine ("Erro ao acessar arquivo.");
                System.Console.WriteLine (erro.Message);
            }

            //Lista de Salas:
            try {
                string[] lista = File.ReadAllLines (@FilePath2);
                int count = 0;
                foreach (string linha in lista) {
                    string[] itens = linha.Split (",");
                    int numSala = Convert.ToInt32 (itens[0].Replace ("\"", ""));
                    int capacidade = Convert.ToInt32 (itens[1].Replace ("\"", ""));

                    salas[count] = new Sala (numSala, capacidade);

                    string listaAlunosConcat = itens[2].Replace ("\"", "");
                    //PROBLEMA RESOLVIDO: alunosCount incrementava a cada item da listaAlunos, fazendo com que o próximo aluno da sala fosse alocado na sala seguinte consecutivamente.
                    if (listaAlunosConcat != "Sala vazia.") {
                        string[] listaAlunos = listaAlunosConcat.Split ("   ");
                        //int alunosCount = 0;
                        foreach (string item in listaAlunos) {
                            if (item != "") {
                                item.Replace ("   ", "");
                                if (salas[count] != null) {
                                    salas[count].AlocarAluno (item);
                                    //sala[alunosCount].AlocarAluno(item);
                                }
                            }
                            //alunosCount++;
                        }

                    }

                    int qtdAlunos = Convert.ToInt32 (itens[3].Replace ("\"", ""));

                    count++;
                    salasCadastradas++;
                }
            } catch (IOException erro) {
                System.Console.WriteLine ("Erro ao acessar arquivo.");
                System.Console.WriteLine (erro.Message);
            }

            do {
                Console.Clear ();

                System.Console.WriteLine ("|__Sistema de cadastro de alunos Senaizinho__|");
                System.Console.WriteLine ("Digite alguma opção abaixo:");
                System.Console.WriteLine ("1 - Cadastrar Aluno;");
                System.Console.WriteLine ("2 - Cadastrar Sala;");
                System.Console.WriteLine ("3 - Alocar Aluno;");
                System.Console.WriteLine ("4 - Remover Aluno;");
                System.Console.WriteLine ("5 - Verificar Salas;");
                System.Console.WriteLine ("6 - Verificar Alunos;");
                System.Console.WriteLine ("0 - Sair");
                string opcao = Console.ReadLine ();
                switch (opcao) {
                    case "1":
                        alunosCadastrados = CadastrarAluno (alunos, alunosCadastrados);
                        break;
                    case "2":
                        salasCadastradas = CadastrarSala (salas, salasCadastradas);
                        break;
                    case "3":
                        AlocarAluno (alunos, salas); //enviando informações por parametro.
                        break;
                    case "4":

                        RemoverAluno (salas, alunos);
                        break;
                    case "5":
                        VerificarSalas (salas);
                        break;
                    case "6":
                        VerificarAlunos (alunos);
                        break;
                    case "0":
                        System.Console.WriteLine ("Finalizando programa.");
                        Salvar (alunos, salas);
                        querSair = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando Inválido.");
                        break;
                }

            } while (querSair);

        } //PROBLEMAS com cadastro de aluno e sala 
        //* RESOLVIDO: (pode-se cadastrar o mesmo número de sala, sobrescrevendo assim outras salas criadas com mesmo número).
        //* RESOLVIDO: (pode-se cadastrar o mesmo nome de aluno)
        public static int CadastrarAluno (Aluno[] alunos, int alunosCadastrados) {
            int limiteAlunos = 100;

            Console.Clear ();
            if (alunosCadastrados < limiteAlunos) {
                string nome = "";
                bool alunoJaExiste = false;
                do {
                    System.Console.Write ("Digite o nome do aluno: ");
                    nome = Console.ReadLine ();
                    foreach (Aluno item in alunos) {
                        if (item != null) {
                            if (item.Nome != nome) {
                                alunoJaExiste = false;
                            } else {
                                System.Console.WriteLine ("Este nome já esta em uso.");
                                Console.ReadLine ();
                                alunoJaExiste = true;
                                break;
                            }
                        }
                    }
                } while (alunoJaExiste);
                System.Console.WriteLine ("Digite a data de nascimento do aluno: (xx/xx/xxxx)");
                DateTime data = DateTime.Parse (Console.ReadLine ());

                Aluno aluno = new Aluno (nome, data);
                int count = 0;
                foreach (Aluno item in alunos) {
                    if (item == null) {
                        alunos[count] = aluno;
                        break;
                    }
                    count++;
                }
                alunosCadastrados++;
            } else {
                System.Console.WriteLine ("Não é possível o cadastro de um novo ALUNO, a escola atingiu sua capacidade máxima.");
                Console.ReadLine ();
            }
            return alunosCadastrados;
        }
        public static int CadastrarSala (Sala[] salas, int salasCadastradas) {
            int limiteSalas = 10;
            int capacidade = 0;
            int numSala = 0;
            bool salaJaExiste = false;
            Console.Clear ();

            if (salasCadastradas < limiteSalas) {
                do {
                    do {
                        System.Console.Write ("Entre com o número da sala à ser aberta: ");
                        numSala = Convert.ToInt32 (Console.ReadLine ());
                        if (numSala < 1 || numSala > 10) {
                            System.Console.WriteLine ("Digite um número de 1 a 10.");
                            Console.ReadLine ();
                        }
                    } while (numSala < 1 || numSala > 10);
                    if (salas[numSala - 1] == null) {
                        salasCadastradas += 1;
                        salaJaExiste = false;

                    } else {
                        System.Console.WriteLine ("Esta sala já existe.");
                        salaJaExiste = true;
                        Console.ReadLine ();
                    }
                } while (salaJaExiste);

                System.Console.Write ("Entre com a capacidade máxima da sala: ");
                do {
                    capacidade = Convert.ToInt32 (Console.ReadLine ());

                    if (capacidade < 0 || capacidade > 10) {
                        System.Console.WriteLine ("A capacidade máxima da sala é 10, digite um valor válido.");
                    }
                } while (capacidade < 0 || capacidade > 10);

                Sala sala = new Sala (numSala, capacidade);
                salas[numSala - 1] = sala;
            } else {
                System.Console.WriteLine ("Não é possível o cadastro de uma nova SALA, a escola atingiu sua capacidade máxima.");
                Console.ReadLine ();
            }

            return salasCadastradas;
        }
        public static void AlocarAluno (Aluno[] alunos, Sala[] salas) { //Chamando informações por parametro.
            //PROBLEMA RESOLVIDO: É possível cadastrar o mesmo aluno em várias salas, como também na mesma sala.
            Console.Clear ();

            bool alunoExiste = false;
            bool salaExiste = false;
            bool alunoNaoReplicado = true;

            System.Console.Write ("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine ();

            //verifica se o aluno existe.
            int index = 0;
            foreach (Aluno item in alunos) { //Para strings não é preciso utilizar item != null.
                if (item != null) { //null pois cai o programa quando procura-se algo em lugar vazio.
                    if (item.Nome == nomeAluno) {
                        alunoExiste = true;
                        break;
                    }
                }
                index++; //indice para ser usado na alocação da sala na classe Aluno.
            }

            System.Console.WriteLine ("Digite o número da sala que o aluno será alocado: ");
            int numSala = Convert.ToInt32 (Console.ReadLine ());

            //verifica se a sala existe.
            foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala == numSala) {
                        salaExiste = true;
                        break;
                    }
                }
            }

            //verifica se há algum aluno com mesmo nome em OUTRAS salas.
            foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala != numSala) { //Cedendo a função de verificar se há o mesmo na sala específica para apenas a classe Sala.
                        for (int i = 0; i < item.Alunos.Length; i++) {
                            if (item.Alunos[i] == nomeAluno + "   ") {
                                alunoNaoReplicado = false;
                                break;
                            }
                        }
                    }

                }
            }
            string msg = "";
            if (salaExiste && alunoExiste) {
                if (alunoNaoReplicado) {

                    for (int i = 0; i < salas.Length; i++) {
                        if (salas[i] != null) {
                            if (i == (numSala - 1)) {
                                msg = salas[i].AlocarAluno (nomeAluno);
                                //Adiciona na classe aluno, o número da sala em que foi alocado.
                                if (msg == "O aluno foi cadastrado com sucesso nesta sala.") {
                                    alunos[index].numeroSala = numSala;
                                }
                                System.Console.WriteLine (msg);
                                Console.ReadLine ();
                                break;

                            }
                        }
                    }

                } else {
                    System.Console.WriteLine ("Este aluno já esta alocado em outra sala, remova-o da sala antes de realoca-lo.");
                    Console.ReadLine ();
                }
            } else {
                System.Console.WriteLine ("Nome ou número de sala não existem, tente novamente.");
                Console.ReadLine ();
            }

        }

        public static void RemoverAluno (Sala[] salas, Aluno[] alunos) {
            string nome = "";
            int numSala = 0;
            string msg = "";
            bool salaExiste = false;

            System.Console.Write ("Digite o nome do aluno que será removido: ");
            nome = Console.ReadLine ();
            System.Console.Write ("Digite o número da sala que o aluno esta alocado: ");
            numSala = Convert.ToInt32 (Console.ReadLine ());

            foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala == numSala) {
                        salaExiste = true;
                        break;
                    }
                }
            }
            if (salaExiste) {
                msg = salas[numSala - 1].RemoverAluno (nome);

                //Remove da classe aluno, o número da sala em que estava alocado.
                foreach (Aluno item in alunos) {
                    if (item != null) {
                        if (item.Nome == nome) {
                            item.numeroSala = 0;
                        }
                    }
                }

            } else {
                System.Console.WriteLine ("Esta sala não existe.");
            }

            System.Console.WriteLine (msg);
            Console.ReadLine ();


            /*foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala == numSala) {
                        msg = item.RemoverAluno (nome);
                        break;
                    }
                }
            }*/

        }

        public static void VerificarSalas (Sala[] salas) {
            foreach (Sala item in salas) {
                if (item != null) {
                    System.Console.WriteLine ($"Sala {item.numeroSala}:");
                    string alunos = item.MostrarAluno ();
                    System.Console.WriteLine ($"  Alunos: {alunos}");

                    //Contar espaços em branco de cada nome com Split e separa-los numa array de strings, usar Lenght para determinar qts alunos na sala.
                    //PROBLEMA RESOLVIDO: QUANDO REMOVE, A QTD DE ALUNOS CONTINUA O MESMO, NÃO DIMINUI.//* O ESPAÇO NÃO É REMOVIDO.

                    if (alunos != "Sala vazia.") {
                        string[] itens = alunos.Split ("   ");
                        System.Console.WriteLine ($"  Qtd de alunos: {itens.Length -1}"); //Perguntar o por quê do -1||Pois sempre irá contar o espaço do último nome.
                    } else {
                        System.Console.WriteLine ($"  Qtd de alunos: 0");
                    }

                }
            }
            Console.ReadLine ();
        }
        public static void VerificarAlunos (Aluno[] alunos) {
            // RESOLVIDO: Verificar se o número da sala (da classe aluno) bate com o n° da sala em que esta alocado. CERTO!
            string[] listaAlunos = new string[100];
            int count = 0;
            foreach (Aluno item in alunos) {
                if (item != null) {
                    listaAlunos[count] = $"Aluno {count+1}: {item.Nome} | Sala: {item.numeroSala}";
                    if (item.numeroSala == 0) {
                        listaAlunos[count] = $"Aluno {count+1}: {item.Nome} | Sala: Aluno ainda não alocado.";
                    }
                }
                count++;
            }
            count = 0;
            foreach (Aluno item in alunos) {
                if (item != null) {
                    System.Console.WriteLine (listaAlunos[count]);
                }
                count++;
            }
            Console.ReadLine ();

        }
        public static void Salvar (Aluno[] alunos, Sala[] salas) {
            //* PROBLEMA: ESCREVE NO ARQUIVO MAS NÃO LÊ E NÃO MANTEM O CONTEÚDO ANTERIOR, SEMPRE SOBRESCREVE.
            try {
                StreamWriter writer = new StreamWriter ("ListaAlunosSalas.csv");

                int count = 0;
                foreach (Aluno item in alunos) {
                    if (item != null) {

                        string listaAlunos = "\"" + item.Nome + "\"" + "," + "\"" + item.numeroSala + "\"" + "," + "\"" + item.DataNascimento + "\"";

                        //listaAlunos += "\"" + item.Nome + "\"" + "," + "\"" + "Aluno ainda não alocado." + "\"" + "," + "\"" + item.DataNascimento + "\"";

                        writer.WriteLine (listaAlunos);
                    }
                    count++;
                }
                writer.Close ();
            } catch (IOException erro) {
                System.Console.WriteLine ("Erro ao acessar arquivo.");
                System.Console.WriteLine (erro.Message);
            }

            try {
                StreamWriter writer = new StreamWriter ("ListaSalas.csv");

                int count = 0;
                foreach (Sala item in salas) {
                    int qtdAlunos = 0;

                    if (item != null) {
                        string listaAlunos = item.MostrarAluno ();
                        foreach (Aluno item2 in alunos) {
                            if (item2 != null) {
                                if (listaAlunos != "Sala vazia.") {
                                    string[] itens = listaAlunos.Split ("   ");
                                    qtdAlunos = itens.Length - 1;
                                } else {
                                    qtdAlunos = 0;
                                }
                            }
                        }
                        string listaSalas = "\"" + (count + 1) + "\"" + "," + "\"" + item.capacidadeTotal + "\"" + "," + "\"" + listaAlunos + "\"" + "," + "\"" + qtdAlunos + "\"";

                        writer.WriteLine (listaSalas);
                    }
                    count++;
                }
                writer.Close ();
            } catch (IOException erro) {
                System.Console.WriteLine ("Erro ao acessar arquivo.");
                System.Console.WriteLine (erro.Message);
            }

        }
    }
}