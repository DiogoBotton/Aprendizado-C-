using System.Collections.Generic;
namespace McBonalds.Models {
    public class Pedido {
        public Cliente Usuario;
        public List<Produto> produtos = new List<Produto> (); //cliente escolhe um produto, que FAZ PARTE DE um pedido.
        public double[] valorUnidades = new double[2]; //0 = hamburgueres, 1= shakes.
        public double totalPago;

        Dictionary<Produto, int> lista = new Dictionary<Produto, int> ();

        public Pedido (Cliente Usuario) {
            this.Usuario = Usuario;
            this.totalPago = 0;
        }

        public void AdicionarProduto (Produto produto, int qtd) {
            var pdt = produto.GetType ().Name;

                if (produto.Equals (typeof (HamburguerBacon))) {
                    HamburguerBacon HB = (HamburguerBacon) produto;
                    HB.AdcQtd (qtd);
                    this.produtos.Add (produto);
                } else if (produto.Equals (typeof (HamburguerFurioso))) {
                    HamburguerFurioso HF = (HamburguerFurioso) produto;
                    HF.AdcQtd (qtd);
                    this.produtos.Add (produto);
                } else if (produto.Equals (typeof (HamburguerVegano))) {
                    HamburguerVegano HV = (HamburguerVegano) produto;
                    HV.AdcQtd (qtd);
                    this.produtos.Add (produto);
                } else if (produto.Equals (typeof (ShakeChocolate))) {
                    ShakeChocolate SC = (ShakeChocolate) produto;
                    SC.AdcQtd (qtd);
                    this.produtos.Add (produto);
                } else if (produto.Equals (typeof (ShakeMorango))) {
                    ShakeMorango SM = (ShakeMorango) produto;
                    SM.AdcQtd (qtd);
                    this.produtos.Add (produto);
                } else if (produto.Equals (typeof (ShakeNutella))) {
                    ShakeNutella SN = (ShakeNutella) produto;
                    SN.AdcQtd (qtd);
                    this.produtos.Add (produto);
                }
                    
                
                    //Como atualizar a QTD de um produto da lista caso forem iguais
                
            

        }
        public double CalcularPedido () {
            foreach (Produto item in produtos) {
                var produtoLista = item.GetType ().Name;

                if (item.Equals (typeof (HamburguerBacon))) {
                    HamburguerBacon HB = (HamburguerBacon) item;
                    this.totalPago += HB.Qtd * HB.Preco;
                } else if (item.Equals (typeof (HamburguerFurioso))) {
                    HamburguerFurioso HF = (HamburguerFurioso) item;
                    this.totalPago += HF.Qtd * HF.Preco;
                } else if (item.Equals (typeof (HamburguerVegano))) {
                    HamburguerVegano HV = (HamburguerVegano) item;
                    this.totalPago += HV.Qtd * HV.Preco;
                } else if (item.Equals (typeof (ShakeChocolate))) {
                    ShakeChocolate SC = (ShakeChocolate) item;
                    this.totalPago += SC.Qtd * SC.Preco;
                } else if (item.Equals (typeof (ShakeMorango))) {
                    ShakeMorango SM = (ShakeMorango) item;
                    this.totalPago += SM.Qtd * SM.Preco;
                } else if (item.Equals (typeof (ShakeNutella))) {
                    ShakeNutella SN = (ShakeNutella) item;
                    this.totalPago += SN.Qtd * SN.Preco;
                }
            }
            return this.totalPago;
        }
        public void FinalizarPedido () {
            this.produtos.Clear ();
            this.totalPago = 0;
        }
        //TODO: cancelar pedido
        //TODO: finalizar pedido, que irá "limpar" a classe pedido, para um novo pedido futuro.
        //(zerar totalPago, zerar vetor de valorUnidades, Remover todos os itens de produtos)
    }
}