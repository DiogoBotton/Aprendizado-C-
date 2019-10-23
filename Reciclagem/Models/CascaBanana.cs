using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class CascaBanana : Lixo, PretoOrganico
    {
        public string Composteira(){
            return this.GetType().Name;
        }
    }
}