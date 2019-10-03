using System;
namespace mateOdragao.Models {
    public class Guerreiro {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CidadeNatal { get; set; }
        public DateTime DataNascimento { get; set; }
        public string FerramentaProtecao { get; set; }
        public string FerramentaAtaque { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        /*public Guerreiro (string Nome, string Sobrenome, string CidadeNatal, DateTime DataNascimento, string FerramentaProtecao, string FerramentaAtaque, int Forca, int Destreza, int Inteligencia, int Vida) {
            this.Nome= Nome; 
            this.Sobrenome= Sobrenome;
            this.CidadeNatal= CidadeNatal; 
            this.DataNascimento= DataNascimento; 
            this.FerramentaProtecao= FerramentaProtecao;
            this.FerramentaAtaque= FerramentaAtaque;
            this.Forca= Forca;
            this.Destreza= Destreza;
            this.Inteligencia= Inteligencia;
            this.Vida= Vida;
        }*/

    }
}