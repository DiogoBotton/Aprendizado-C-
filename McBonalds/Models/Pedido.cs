namespace McBonalds.Models
{
    public class Pedido
    {
        public string nomeUsuario;
        public string Endereco;
        public string Produto;//Como saberá o tipo do produto (Hamburguer ou Shake).
        public double totalPago;
    }
}