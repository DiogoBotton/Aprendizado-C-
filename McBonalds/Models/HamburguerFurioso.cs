namespace McBonalds.Models
{
    public class HamburguerFurioso : Hamburguer
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

        public HamburguerFurioso(){
            this._Nome = "Hamburguer FURIOSO";
            this._Preco = 9.90;
        }

        public override string MostrarProduto(){
            return this._Nome + "  R$ " + this._Preco;
        }
        public override double RetornarPreco(){
            return _Preco;
        }
        public override string RetornarNome(){
            return _Nome;
        }
        public override void AdcQtd(int qtd){
            this.Qtd += qtd;
        }
    } 
}