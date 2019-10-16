using System;
namespace BandaRock.Models
{
    public class InstrumentoMusical
    {
        string[] Notas = {"Dó","Ré","Mí","Fá","Sol","Lá","Sí"};
        
        public string TocarMusica(){
            int nota = new Random().Next(Notas.Length -1);
            return Notas[nota];
        }
        
    }
}