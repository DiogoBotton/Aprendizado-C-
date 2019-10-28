using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;
using ZooLogico.Models.Habitats;

namespace ZooLogico {
    enum AnimaisEnum : uint {
        Arara = 1,
        Chimpanzé,
        Golfinho,
        Leão,
        Orangotango,
        Pinguim,
        Tartagura,
        TubarãoMartelo,
        Tucano
    }
    class Program {
        static void Main (string[] args) {
            Pasto pasto = new Pasto ();
            Gaiola gaiola = new Gaiola ();
            Aquario aquario = new Aquario ();
            AquarioGelado aquarioGelado = new AquarioGelado ();
            CasaArvore casaArvore = new CasaArvore ();
            CavernaPedra cavernaPedra = new CavernaPedra ();
            Piscina piscina = new Piscina ();

            //Habitat habitat = new Habitat();

            bool querSair = false;
            int codigo = 0;
            do {
                Console.Clear ();

                codigo = ListarAnimais ();

                if (ListaAnimais.animais.ContainsKey (codigo)) {
                    ColocarAnimalHabitat (ListaAnimais.animais[codigo], pasto, gaiola, aquario, aquarioGelado, casaArvore, cavernaPedra, piscina);
                } else {
                    if(codigo == 0){
                        querSair = true;
                    }
                    else{
                    System.Console.WriteLine ($"O código {codigo} não existe na lista de animais.");
                    Console.ReadLine ();
                    }
                }

            } while (!querSair);

        }
        public static int ListarAnimais () {
            string[] animais = Enum.GetNames (typeof (AnimaisEnum));

            int count = 1;
            System.Console.WriteLine ("|__________ZooLógico__________|");
            System.Console.WriteLine ("Digite o código do animal para adiciona-lo em um habitat.");
            foreach (string animal in animais) {
                System.Console.WriteLine ($"{count++}.{animal}");
            }
            System.Console.WriteLine ("Digite 0 para Sair do Programa");
            System.Console.WriteLine ("|_____________________________|");
            int codigo = Convert.ToInt32 (Console.ReadLine ());

            return codigo;

        }
        public static void ColocarAnimalHabitat (Animal animal, Pasto pasto, Gaiola gaiola, Aquario aquario, AquarioGelado aquarioGelado, CasaArvore casaArvore, CavernaPedra cavernaPedra, Piscina piscina) {
            Type tipoAnimal = animal.GetType ().GetInterfaces ().FirstOrDefault ();

            //Caso houver mais de uma interface por animal, fazer um vetor de type (Type[]);
            //Um Foreach para iterar no vetor de Type[].

            bool colocouNoHabitat = false;

            if (tipoAnimal.Equals (typeof (IVoador))) {
                IVoador voador = (IVoador) animal;

                colocouNoHabitat = gaiola.ColocarAnimalGaiola (animal);
                if (colocouNoHabitat) {

                    System.Console.WriteLine (voador.Voar () + " voa, então deve ficar no habitat Gaiola.");
                    System.Console.WriteLine ($"Foi possível alocar {voador.Voar()} no habitat.");
                    System.Console.WriteLine ($"Vagas restantes: {gaiola.capacidadeAtual}");
                    Console.ReadLine ();

                    //TODO: Fazer método de listagem de animais em cada Habitat.
                } else {
                    System.Console.WriteLine ($"Não foi possível alocar {voador.Voar()} na Gaiola.");
                    System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                    Console.ReadLine ();

                }

            } else if (tipoAnimal.Equals (typeof (ITerrestre))) {
                ITerrestre terrestre = (ITerrestre) animal;

                colocouNoHabitat  = pasto.ColocarAnimalPasto(animal);
                if(colocouNoHabitat){
                    System.Console.WriteLine (terrestre.Andar() + " anda, então deve ficar no habitat Pasto.");
                    System.Console.WriteLine ($"Foi possível alocar {terrestre.Andar()} no habitat.");
                    System.Console.WriteLine ($"Vagas restantes: {pasto.capacidadeAtual}");
                    Console.ReadLine ();
                }
                else{
                    System.Console.WriteLine ($"Não foi possível alocar {terrestre.Andar()} no Pasto.");
                    System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                    Console.ReadLine ();
                }
            }
            //TODO: Fazer aquatico, branquiado, quionofilo, arboricula.

        }
    }
}