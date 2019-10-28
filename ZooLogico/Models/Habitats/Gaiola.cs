using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats
{
    public class Gaiola : Habitat
    {
        public Animal[] animais = new Animal[3];
        public int capacidadeAtual = 3;

        public bool ColocarAnimalGaiola(Animal animal){
            if (this.capacidadeAtual > 0){
                int index = 0;
                foreach (Animal voador in animais)
                {
                    if(voador == null){
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