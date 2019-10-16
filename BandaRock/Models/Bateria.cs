using BandaRock.Interfaces;
namespace BandaRock.Models
{
    public class Bateria : InstrumentoMusical, IPercurssao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo com a bateria.");
            return true;
        }
    }
}