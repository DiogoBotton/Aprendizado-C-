namespace Senaizinho.Models {
    public class Sala {
        private int _CapacidadeAtual;
        private int _capacidadeTotal;
        private int _numeroSala;
        private string[] _Alunos;
        //Encapsulamento (escondendo os atributos com private)
        public int capacidadeTotal { get { return _capacidadeTotal; } }
        public int numeroSala { get { return _numeroSala; } }
        public string[] Alunos { get { return _Alunos; } }

        public Sala (int numeroSala, int capacidadeTotal) {
            this._numeroSala = numeroSala;
            this._capacidadeTotal = capacidadeTotal;
            this._Alunos = new string[capacidadeTotal];
            this._CapacidadeAtual = this._capacidadeTotal;
        }
        public string AlocarAluno (string nome) {
            int index = 0;
            string msg = "";
            bool AlunoNaoReplicado = true;
            if (this._CapacidadeAtual > 0) {
                //verifica se o aluno já existe na sala.
                foreach (string item in _Alunos) {
                    if (item == nome + "   ") {
                        AlunoNaoReplicado = false;
                        break;
                    }
                }
                if (AlunoNaoReplicado) {
                    foreach (string item in _Alunos) {
                        if (item == null) {
                            this._Alunos[index] = nome + "   ";
                            this._CapacidadeAtual--;

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
            if (this._CapacidadeAtual == this._capacidadeTotal) {
                msg = "A sala esta vazia.";
            } else {

                foreach (string item in this._Alunos) {
                    if (item == nome) {
                        this._Alunos[index] = "";
                        this._CapacidadeAtual++;
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

            if (this._CapacidadeAtual != this._capacidadeTotal) {
                foreach (string aluno in _Alunos) {
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