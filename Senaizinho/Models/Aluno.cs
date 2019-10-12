using System;
namespace Senaizinho.Models {
    public class Aluno {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
        public int numeroSala { get; set; }

        public Aluno (string Nome, DateTime DataNascimento) {
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
        }
        public void AlunoNumSala(int numeroSala){
            this.numeroSala = numeroSala;
        }
    }
}