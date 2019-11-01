using ZooLogico.Models.Animais;
namespace ZooLogico.Models.Habitats
{
    public abstract class Habitat
    {
        private Animal[] animais;
        private int _capacidadeAtual;
        public int capacidadeAtual{
            get{return _capacidadeAtual;}
        }

        public Habitat(){
            this.animais = new Animal[3];
            this._capacidadeAtual = 3;
        }
        public bool AlocarAnimal(Animal animal){
            if (this._capacidadeAtual > 0){
                int index = 0;
                foreach (Animal especie in animais)
                {
                    if(especie == null){
                        this.animais[index] = animal;
                        this._capacidadeAtual--;
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