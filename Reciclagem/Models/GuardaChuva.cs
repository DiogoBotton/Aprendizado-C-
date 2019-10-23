using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, MetalAmarelo
    {
        public string ReciclarMetal(){
            return this.GetType().Name;
        }
    }
}