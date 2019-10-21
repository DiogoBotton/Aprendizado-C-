using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : Lixo, AzulPapel
    {
        public override string JogarNoLixo(){
            return "Você jogou Papelão no lixo.";
        }
        public override string Lixeira(){
            return "Você jogou no lixo AZUL.";
        }
    }
}