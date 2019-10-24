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
        }

        public void GerarPedido (List<Produto> prods) {
            //this.produtos.Add(prods);
            var pdt = prods.GetType ().Name;
            foreach (Produto item in produtos) { //Para não adicionar objetos iguais na lista.
                var produtoLista = item.GetType ().Name;
                if (produtoLista != pdt) {

                    foreach (Produto produto in prods) {
                        this.produtos.Add (produto);
                    }
                }

            }

        }
        public double CalcularPedido (double preco, int qtd) {
            preco = preco * qtd;

            this.totalPago += preco;
            return this.totalPago;

            //valorUnidades[0] += preco;
            //Para saber quantas unidades comprou: DIVIDIR valorUnidades pelo preço da UNIDADE do produto.
            //PROBLEMA: Há produtos com preços diferentes.
        }
        public void FinalizarPedido () {
            this.produtos.Clear ();
            this.valorUnidades[0] = 0;
            this.valorUnidades[1] = 0;
            this.totalPago = 0;
        }
        //TODO: cancelar pedido
        //TODO: finalizar pedido, que irá "limpar" a classe pedido, para um novo pedido futuro.
        //(zerar totalPago, zerar vetor de valorUnidades, Remover todos os itens de produtos)
    }
}