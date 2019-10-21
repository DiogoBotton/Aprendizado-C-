using System.Collections.Generic;
namespace Reciclagem.Models
{
    public class TiposDeLixo
    {
        public static Dictionary<int, Lixo> lixos = new Dictionary<int, Lixo>(){
            {1, new GarrafaPET()},
            {2, new GuardaChuva()},
            {3, new Latinha()},
            {4, new Papelao()},
            {5, new PoteManteiga()},
            {6, new CascaBanana()}
        };
    }
}