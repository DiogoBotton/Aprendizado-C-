using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando notas do teclado.");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do teclado.");
            return true;
        }
    }
}