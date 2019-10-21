using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class CascaBanana : Lixo, PretoOrganico
    {
        public override string JogarNoLixo(){
            return "Você jogou Casca de Banana no lixo.";
        }
        public override string Lixeira(){
            return "Você jogou no lixo PRETO.";
        }
        public string Composteira(){
            return "O lixo foi enviado para a COMPOSTEIRA.";
        }
    }
}