using System.Collections.Generic;
namespace McBonalds.Models
{
    public abstract class Produto 
    {
        public static Dictionary<int, Hamburguer> listHamburgueres = new Dictionary<int, Hamburguer>(){
            {1, new HamburguerVegano()},
            {2, new HamburguerFurioso()},
            {3, new HamburguerBacon()}
        };
        public static Dictionary<int, Shake> listShakes = new Dictionary<int, Shake>(){
            {1, new ShakeChocolate()},
            {2, new ShakeMorango()},
            {3, new ShakeNutella()}
        };
    }
}