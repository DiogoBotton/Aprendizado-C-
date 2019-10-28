using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats
{
    public class CasaArvore : Habitat
    {
        public Animal[] animais = new Animal[3];
        public int capacidadeAtual = 3;

        public bool ColocarAnimalCasaArvore(Animal animal){
            if (this.capacidadeAtual > 0){
                int index = 0;
                foreach (Animal arboricula in animais)
                {
                    if(arboricula == null){
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