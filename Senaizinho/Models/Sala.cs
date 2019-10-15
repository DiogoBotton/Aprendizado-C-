namespace Senaizinho.Models {
    public class Sala {
        public int CapacidadeAtual { get; set; }
        public int capacidadeTotal { get; set; }
        public int numeroSala { get; set; }
        public string[] Alunos { get; set; }

        public Sala (int numeroSala, int capacidadeTotal) {
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
            this.Alunos = new string[capacidadeTotal];
            this.CapacidadeAtual = this.capacidadeTotal;
        }
        public string AlocarAluno (string nome) {
            int index = 0;
            string msg = "";
            bool AlunoNaoReplicado = true;
            //verifica se o aluno já esta na sala.
            if (this.CapacidadeAtual > 0) {
                foreach (string item in Alunos) {
                    if (item == nome + "   ") {
                        AlunoNaoReplicado = false;
                        break;
                    }
                }
                if (AlunoNaoReplicado) {
                    foreach (string item in Alunos) {
                        if (item == null) {
                            this.Alunos[index] = nome + "   ";
                            this.CapacidadeAtual--;

                            msg = "O aluno foi cadastrado com sucesso nesta sala.";
                            break;
                        }
                        index++;
                    }
                } else {
                    msg = "Este aluno já existe nesta sala.";
                }
            } else {
                msg = "Esta sala esta cheia, não foi possível alocar o aluno nesta sala.";
            }
            return msg;
        }

        public string RemoverAluno (string nome) {
            int index = 0;
            string msg = "Este aluno não existe nesta sala.";

            nome = nome + "   ";

            //TODO SALA VAZIA
            if (this.CapacidadeAtual == this.capacidadeTotal) {
                msg = "A sala esta vazia.";
            } else {

                foreach (string item in this.Alunos) {
                    if (item == nome) {
                        this.Alunos[index] = "";
                        this.CapacidadeAtual++;
                        msg = "O aluno foi removido da sala com sucesso.";
                        break;
                    }
                    index++;
                }
            }
            return msg;
        }
        public string MostrarAluno () {
            string listaAlunos = "";

            //int numAlunos = this.capacidadeTotal - this.CapacidadeAtual;
            //System.Console.WriteLine ($"  Qtd de alunos: {numAlunos}");

            if (this.CapacidadeAtual != this.capacidadeTotal) {
                foreach (string aluno in Alunos) {
                    if (aluno != null) {
                        listaAlunos += aluno;
                    }
                }
                return listaAlunos;
            } else {
                listaAlunos = "Sala vazia.";
                return listaAlunos;
            }
        }

    }
}