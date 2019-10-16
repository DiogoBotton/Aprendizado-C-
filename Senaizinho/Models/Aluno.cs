using System;
namespace Senaizinho.Models {
    public class Aluno {
        private string _Nome;
        private DateTime _DataNascimento;
        private string _Curso;
        private int _numeroSala;
        //Encapsulamento (escondendo os atributos com private)
        public string Nome { get { return _Nome; } }
        public DateTime DataNascimento { get { return _DataNascimento; } }
        public int numeroSala { get { return _numeroSala; }}

        public Aluno (string Nome, DateTime DataNascimento) {
            this._Nome = Nome;
            this._DataNascimento = DataNascimento;
        }
        public void AlunoNumSala(int numSala){
            this._numeroSala = numSala;
        }
    }
}