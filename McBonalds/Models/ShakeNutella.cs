namespace McBonalds.Models {
    public class ShakeNutella : Shake {
        private string _Nome;
        private double _Preco;
        
        public string Nome {
            get { return _Nome; }
        }
        public double Preco {
            get { return _Preco; }
        }

        public ShakeNutella () {
            this._Nome = "Shake de Nutella";
            this._Preco = 9.90;
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