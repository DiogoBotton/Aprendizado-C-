using BandaRock.Interfaces;

namespace BandaRock.Models

{   //Classe Filha herda da Classe PAI, que herda as interfaces harmonia,melodia e percurssão.
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercurssao
    {
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocando acordes do Violão.");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando notas do violão.");
            return true;
        }
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo o ritmo do violão.");
            return true;
        }
    }
}