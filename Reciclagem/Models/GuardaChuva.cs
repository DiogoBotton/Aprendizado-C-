using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, MetalAmarelo
    {
        public override string JogarNoLixo(){
            return "Você jogou Guarda Chuva no lixo.";
        }
        public override string Lixeira(){
            return "Você jogou no lixo AMARELO.";
        }
    }
}