using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats
{
    public class Pasto : Habitat
    {
        public Animal[] animais = new Animal[3];
        public int capacidadeAtual = 3;

        public bool ColocarAnimalPasto(Animal animal){
            if (this.capacidadeAtual > 0){
                int index = 0;
                foreach (Animal pastos in animais)
                {
                    if(pastos == null){
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