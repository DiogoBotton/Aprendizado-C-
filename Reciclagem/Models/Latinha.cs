using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : Lixo, MetalAmarelo
    {
        public string ReciclarMetal(){
            return this.GetType().Name;
        }
    }
}