using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, VermelhoPlastico
    {
        public string ReciclarPlastico(){
            return this.GetType().Name; //Retorna o nome da classe.
        }
    }
}