using System.Collections.Generic;
namespace McBonalds.Models {
    public abstract class Shake : Produto {
        public abstract string MostrarProduto ();
        public abstract double RetornarPreco();
        public abstract string RetornarNome();
    }
}