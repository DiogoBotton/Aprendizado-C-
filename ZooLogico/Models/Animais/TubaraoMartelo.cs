using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class TubaraoMartelo : Animal, IAquatico, IBranquiado
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }

        public string RespirarBaixoDAgua()
        {
            return " respirar de baixo d'Água";
        }
    }
}