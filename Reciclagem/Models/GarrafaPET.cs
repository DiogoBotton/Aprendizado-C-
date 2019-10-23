using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, VermelhoPlastico
    {
        public string ReciclarPlastico(){
            return this.GetType().Name;
        }
    }
}