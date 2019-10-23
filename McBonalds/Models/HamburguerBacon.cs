namespace McBonalds.Models
{
    public class HamburguerBacon : Hamburguer
    {
        private string _Nome;
        private double _Preco;
        public int Qtd;
        public string Nome{
            get {return _Nome;}
        }
        public double Preco{
            get{return _Preco;}
        }

        public HamburguerBacon(){
            this._Nome = "Hamburguer Bacon";
            this._Preco = 12.90;
        }

        public override string MostrarProduto(){
            return _Nome + "  R$ " + _Preco;
        }
        public override double RetornarPreco(){
            return _Preco;
        }
        public override string RetornarNome(){
            return _Nome;
        }
    }
}