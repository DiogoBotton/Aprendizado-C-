using System.Collections.Generic;
namespace McBonalds.Models {
    public class Pedido {
        public Cliente Usuario;
        public List<Produto> produtos = new List<Produto> (); //cliente escolhe um produto, que FAZ PARTE DE um pedido.
        public double[] valorUnidades = new double[2]; //0 = hamburgueres, 1= shakes.
        public double totalPago;

        public void GerarPedido (List<Produto> prods) {
            //this.produtos.Add(prods);
            foreach (var pedido in prods) {
                foreach (Produto item in produtos) {//Para não adicionar objetos iguais na lista.
                    if (item != pedido) {
                        this.produtos.Add (pedido);
                    }
                    
                }
            }
        }
        public double CalcularPedido (Hamburguer hamburguer, double preco, int qtd) {
            preco = preco * qtd;

            this.totalPago += preco;
            valorUnidades[0] += preco;
            //Para saber quantas unidades comprou: DIVIDIR valorUnidades pelo preço da UNIDADE do produto.
            //PROBLEMA: Há produtos com preços diferentes.
            return this.totalPago;
        }
        public double CalcularPedido (Shake shake, double preco, int qtd) {
            preco = preco * qtd;

            this.totalPago += preco;
            valorUnidades[1] += preco;

            return this.totalPago;
        }
        public void FinalizarPedido(){
            this.produtos.Clear();
            this.valorUnidades[0] = 0;
            this.valorUnidades[1] = 0;
            this.totalPago = 0;
        }
        //TODO: cancelar pedido
        //TODO: finalizar pedido, que irá "limpar" a classe pedido, para um novo pedido futuro.
        //(zerar totalPago, zerar vetor de valorUnidades, Remover todos os itens de produtos)
    }
}