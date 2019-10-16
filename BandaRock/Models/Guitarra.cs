using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando notas da guitarra.");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes da guitarra.");
            return true;
        }
    }
}