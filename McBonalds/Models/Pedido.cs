using System.Collections.Generic;
namespace McBonalds.Models
{
    public class Pedido
    {
        public string nomeUsuario;
        public string Endereco;
        public List<Produto> produto; //cliente escolhe um produto, que FAZ PARTE DE um pedido.
        public double totalPago;

         
    }
}