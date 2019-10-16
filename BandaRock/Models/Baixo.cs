using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class Baixo : InstrumentoMusical, IPercurssao, IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do Baixo.");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do Baixo.");
            return true;
        }
    }
}