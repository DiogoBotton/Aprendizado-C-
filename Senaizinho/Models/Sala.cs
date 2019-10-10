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
            this.CapacidadeAtual = 0;
            //this.CapacidadeAtual = capacidadeTotal - Alunos.Length; 
        }
        public string AlocarAluno (string nome) {
            int vagas = capacidadeTotal - CapacidadeAtual;
            int index = 0;
            string msg = "";

            if (vagas > 0) {
                foreach (string item in Alunos) {
                    if (item == null) {
                        this.Alunos[index] = nome;
                        this.CapacidadeAtual++;
                        break;
                    }
                    index++;
                }
                msg = "O aluno foi cadastrado com sucesso nesta sala.";
                return msg;
            } else {
                msg = "Esta sala esta cheia, não foi possível alocar o aluno nesta sala.";
                return msg;
            }
        }

        public string RemoverAluno(string nome) {
            int index = 0;
            string msg = "";

            foreach (string item in this.Alunos) {
                //TODO SALA VAZIA
                    if (item == nome) {
                        this.Alunos[index] = null;
                        msg = "O aluno foi removido da sala com sucesso.";
                    }
                    else {
                        msg = "Este aluno não existe nesta sala.";
                    }
                
                index++;
            }
            return msg;
        }
        public string MostrarAluno() {
            string listaAlunos = "";
            foreach (string aluno in Alunos)
            {
                if (aluno != null){
                    listaAlunos += aluno + " ";
                }
            }
            return listaAlunos;
        }

    }
}