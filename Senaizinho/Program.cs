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
                        salasCadastradas = CadastrarSala (salas, salasCadastradas);
                        break;
                    case "3":
                        AlocarAluno (alunos, salas); //enviando informações por parametro.
                        break;
                    case "4":
                        break;
                    case "5":
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

        }
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
            }
        }
        public static int CadastrarSala (Sala[] salas, int salasCadastradas) {
            int limiteSalas = 10;
            int capacidade = 0;

            Console.Clear ();
            if (salasCadastradas < limiteSalas) {
                System.Console.Write ("Entre com o número da sala à ser aberta: ");
                int numSala = Convert.ToInt32 (Console.ReadLine ());
                System.Console.Write ("Entre com a capacidade máxima da sala: ");
                do {
                    capacidade = Convert.ToInt32 (Console.ReadLine ());

                    if (capacidade > 10) {
                        System.Console.WriteLine ("A capacidade máxima da sala é 10, digite um valor válido.");
                    }
                } while (capacidade > 10);

                Sala sala = new Sala (numSala, capacidade);

                salasCadastradas += 1;

                salas[salasCadastradas - 1] = sala;

            } else {
                System.Console.WriteLine ("Não é possível o cadastro de uma nova SALA, a escola atingiu sua capacidade máxima.");
            }
            return salasCadastradas;
        }
        public static void AlocarAluno (Aluno[] alunos, Sala[] salas) { //Chamando informações por parametro.
            Console.Clear ();
            //item.numeroSala == numeroSala
            bool alunoExiste = false;
            bool salaExiste = false;

            System.Console.Write ("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine ();

            foreach (Aluno item in alunos) {
                if (item != null) {
                    if (item.Nome == nomeAluno) {
                        alunoExiste = true;
                    }
                }
            }

            System.Console.WriteLine ("Digite o número da sala que o aluno será alocado: ");
            int numSala = Convert.ToInt32 (Console.ReadLine ());

            foreach (Sala item in salas) {
                if (item != null) {
                    if (item.numeroSala == numSala) {
                        salaExiste = true;
                        
                    }
                }
            }

            if (salaExiste && alunoExiste) {
                for (int i = 0; i < ; i++) {
                    if (salas[i] < ) {

                        salas[].Alunos[]
                    }

                }
            } else {
                System.Console.WriteLine ("Nome ou número de sala não existem, tente novamente.");
                Console.ReadLine ();
            }

        }
    }
}