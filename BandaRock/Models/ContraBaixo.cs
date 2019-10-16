using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercurssao, IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do Contra Baixo.");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do Contra Baixo.");
            return true;
        }
    }
}