using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats
{
    public class Piscina : Habitat
    {
        public Animal[] animais = new Animal[3];
        public int capacidadeAtual = 3;

        public bool ColocarAnimalPiscina(Animal animal){
            if (this.capacidadeAtual > 0){
                int index = 0;
                foreach (Animal aquatico in animais)
                {
                    if(aquatico == null){
                        this.animais[index] = animal;
                        this.capacidadeAtual--;
                        break;
                    }
                    index++;
                }
                return true;
            }
            else{
                return false;
            } 
        }
    }
}