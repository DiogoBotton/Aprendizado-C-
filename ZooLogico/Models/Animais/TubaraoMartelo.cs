using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class TubaraoMartelo : Animal, IBranquiado
    {
        public string RespirarBaixoDAgua()
        {
            return this.GetType().Name;
        }
    }
}