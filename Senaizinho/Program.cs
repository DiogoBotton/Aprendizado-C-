using System;
using System.Collections.Generic;
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
                        CadastrarAluno (alunos, alunosCadastrados);
                        alunosCadastrados += 1;
                        break;
                    case "2":
                        CadastrarSala (ref salas, salasCadastradas);
                        salasCadastradas += 1;
                        break;
                    case "3":
                        AlocarAluno (alunos, salas); //enviando informações por parametro.
                        break;
                    case "4":

                        RemoverAluno (salas);
                        break;
                    case "5":
                        VerificarSalas (salas);
                        break;
                    case "6":
                        break;
                    case "0":
                        System.Console.WriteLine ("Finalizando programa.");
                        querSair = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando Inválido.");
                        break;
                }

            } while (querSair);

        } //PROBLEMAS com cadastro de aluno e sala //*(pode-se cadastrar o mesmo nome de aluno) e (pode-se cadastrar o mesmo número de sala, sobrescrevendo assim outras salas criadas com mesmo número.) resolvido
        public static void CadastrarAluno (Aluno[] alunos, int alunosCadastrados) {
            int limiteAlunos = 100;

            Console.Clear ();
            if (alunosCadastrados < limiteAlunos) {
                System.Console.Write ("Digite o nome do aluno: ");
                string nome = Console.ReadLine ();
                System.Console.WriteLine ("Digite a data de nascimento do aluno: (xx/xx/xxxx)");
                DateTime data = DateTime.Parse (Console.ReadLine ());

                Aluno aluno = new Aluno (nome, data);

                alunos[alunosCadastrados] = aluno;

            } else {
                System.Console.WriteLine ("Não é possível o cadastro de um novo ALUNO, a escola atingiu sua capacidade máxima.");
                Console.ReadLine ();
            }
        }
        public static Sala CadastrarSala (ref Sala[] salas, int salasCadastradas) {
            int limiteSalas = 10;
            int capacidade = 0;
            int numSala = 0;
            bool salaJaExiste = false;
            Console.Clear ();
            if (salasCadastradas < limiteSalas) {
                do {
                    System.Console.Write ("Entre com o número da sala à ser aberta: ");
                    do {
                        numSala = Convert.ToInt32 (Console.ReadLine ());
                        if (numSala < 1 || numSala > 10) {
                            System.Console.WriteLine ("Digite um número de 1 a 10.");
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

            } else {
                System.Console.WriteLine ("Não é possível o cadastro de uma nova SALA, a escola atingiu sua capacidade máxima.");
                Console.ReadLine ();
            }
            Sala sala = new Sala (numSala, capacidade);
            salas[numSala - 1] = sala;

            return sala;
        }
        public static void AlocarAluno (Aluno[] alunos, Sala[] salas) { //Chamando informações por parametro.
            Console.Clear ();
            //item.numeroSala == numeroSala
            bool alunoExiste = false;
            bool salaExiste = false;

            System.Console.Write ("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine ();

            int count = 0;
            int index = 0;
            foreach (Aluno item in alunos) { //Para strings não é preciso utilizar item != null.
                if (item != null) { //null pois cai o programa quando procura-se algo em lugar vazio.
                    if (item.Nome == nomeAluno) {
                        alunoExiste = true;
                        index = count;
                        break;
                    }
                }
                count++;
            }

            System.Console.WriteLine ("Digite o número da sala que o aluno será alocado: ");
            int numSala = Convert.ToInt32 (Console.ReadLine ());

            foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala == numSala) {
                        salaExiste = true;
                        break;
                    }
                }
            }

            if (salaExiste && alunoExiste) {
                string msg = "";
                for (int i = 0; i < salas.Length; i++) {
                    if (salas[i] != null) {
                        if (i == (numSala - 1)) {
                            //salas[i].Alunos[i] = nomeAluno;
                            alunos[index].numeroSala = numSala; //* ERRO: mesmo com a sala cheia, da o número da sala para a classe aluno.
                            msg = salas[i].AlocarAluno (nomeAluno);
                            break;
                        }
                    }
                }
                System.Console.WriteLine (msg);
                Console.ReadLine ();

            } else {
                System.Console.WriteLine ("Nome ou número de sala não existem, tente novamente.");
                Console.ReadLine ();
            }

        }

        public static void RemoverAluno (Sala[] salas) {
            string nome = "";
            string msg = "";

            System.Console.Write ("Digite o nome do aluno que será removido: ");
            nome = Console.ReadLine ();

            foreach (Sala item in salas) {
                if (item != null) {
                    msg = item.RemoverAluno (nome);
                }
            }
            System.Console.WriteLine (msg);
            Console.ReadLine ();

        }

        public static void VerificarSalas (Sala[] salas) {
            //TODO verificar salas, verificar alunos, remover alunos
            //Array estourando. Como dizer a qtd de alunos[] no vetor de salas.
            int count = 0;
            foreach (Sala item in salas) {
                System.Console.WriteLine ($"Sala {count +1}:");
                if (item != null) {
                    
                }
                count++;
            }

            /*for (int i = 0; i < salas.Length; i++) {
                if (salas[i] != null) {
                    System.Console.WriteLine ($"Sala {i + 1}: {salas.Length} alunos registrados na sala.");
                    for (int j = 0; i < salas.Length; j++) {
                        System.Console.WriteLine ($"Aluno{j + 1}: {salas[i].Alunos[j]} ");
                    }
                }
            }*/
        }
    }
}