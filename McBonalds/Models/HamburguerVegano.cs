namespace McBonalds.Models {
    public class HamburguerVegano : Hamburguer {
        private string _Nome;
        private double _Preco;
        public string Nome {
            get { return _Nome; }
        }
        public double Preco {
            get { return _Preco; }
        }

        public HamburguerVegano () {
            this._Nome = "Hamburguer Vegano";
            this._Preco = 10.90;
        }

        public override string MostrarProduto () {
            return this._Nome + "  R$ " + this._Preco;
        }
        public override double RetornarPreco(){
            return _Preco;
        }
        public override string RetornarNome(){
            return _Nome;
        }
    }
}