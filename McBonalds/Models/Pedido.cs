using System.Collections.Generic;
namespace McBonalds.Models
{
    public class Pedido
    {
        public Cliente Usuario;
        public List<Produto> produtos; //cliente escolhe um produto, que FAZ PARTE DE um pedido.
        public double totalPago;

        public void GerarPedido(Produto produto){
            this.produtos.Add(produto);
        }
        public double CalcularPedido(double preco, int qtd){
            preco = preco * qtd;
            this.totalPago += preco;
            return this.totalPago;
        }
        //TODO: cancelar pedido
    }
}