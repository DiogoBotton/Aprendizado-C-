using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, VermelhoPlastico
    {
        public override string JogarNoLixo(){
            return "Você jogou Pote de Manteiga no lixo.";
        }
        public override string Lixeira(){
            return "Você jogou no lixo VERMELHO.";
        }
    }
}