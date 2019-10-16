using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class Tambores : InstrumentoMusical, IPercurssao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo com os Tambores.");
            return true;
        }
    }
}