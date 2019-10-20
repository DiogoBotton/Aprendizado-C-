using System.Collections.Generic;
namespace McBonalds.Models
{
    public abstract class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string Nome, double Preco){
            this.Nome = Nome;
            this.Preco = Preco;
        }

    }
}