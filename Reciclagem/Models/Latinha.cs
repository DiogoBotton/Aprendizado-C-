using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : Lixo, MetalAmarelo
    {
        public override string JogarNoLixo(){
            return "Você jogou Latinha no lixo.";
        }
        public override string Lixeira(){
            return "Você jogou no lixo AMARELO.";
        }
    }
}