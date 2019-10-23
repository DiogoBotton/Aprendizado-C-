using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : Lixo, AzulPapel
    {
        public string ReciclarPapel(){
            return this.GetType().Name;
        }
    }
}