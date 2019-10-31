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

            Habitat habitat = new Habitat();

            bool querSair = false;
            int codigo = 0;
            do {
                Console.Clear ();

                codigo = ListarAnimais ();

                if (ListaAnimais.animais.ContainsKey (codigo)) {
                    ColocarAnimalHabitat (ListaAnimais.animais[codigo], habitat, pasto, gaiola, aquario, aquarioGelado, casaArvore, cavernaPedra, piscina);
                } else {
                    if (codigo == 0) {
                        querSair = true;
                    } else {
                        System.Console.WriteLine ($"O código {codigo} não existe na lista de animais.");
                        Console.ReadLine ();
                    }
                }

            } while (!querSair);

        }
        public static int ListarAnimais () {
            string[] animais = Enum.GetNames (typeof (AnimaisEnum));
            bool validacao = false;
            int codigo;
            do {
                int count = 1;

                System.Console.WriteLine ("|__________ZooLógico__________|");
                System.Console.WriteLine ("Digite o código do animal para adiciona-lo em um habitat.");
                foreach (string animal in animais) {
                    System.Console.WriteLine ($"{count}.{animal}");
                    count++;
                }
                System.Console.WriteLine ("Digite 0 para Sair do Programa");
                System.Console.WriteLine ("|_____________________________|");
                validacao = int.TryParse (Console.ReadLine (), out codigo);
            } while (!validacao);

            return codigo;

        }
        public static void ColocarAnimalHabitat (Animal animal, Habitat habitat, Pasto pasto, Gaiola gaiola, Aquario aquario, AquarioGelado aquarioGelado, CasaArvore casaArvore, CavernaPedra cavernaPedra, Piscina piscina) {
            Type[] tipoAnimal = animal.GetType ().GetInterfaces ();
            bool AnimalPrecisaSerSeparado = false;
            bool colocouNoHabitat = false;

            //Caso houver mais de uma interface por animal, fazer um vetor de type (Type[]);
            //Um Foreach para iterar no vetor de Type[].
            //I.Equals(typeof(IBranquiado))
            //A cada vez que aloca mais um animal, declara um novo objeto (habitat)
            //Validação para saber se o animal precisa ser separado dos demais ou não.
            if (tipoAnimal.Contains (typeof (IBranquiado))) {
                AnimalPrecisaSerSeparado = true;
            } else {
                AnimalPrecisaSerSeparado = false;
            }
            

            if (AnimalPrecisaSerSeparado) {
                foreach (Type intFace in tipoAnimal) {

                    if (intFace.Equals (typeof (IBranquiado))) {
                        IBranquiado branquiado = (IBranquiado) animal;
                        IAquatico aquatico = (IAquatico) animal;
                        
                        //Aquario aqualio = (Aquario) habitat;
                        
                        colocouNoHabitat = aquario.ColocarAnimalAquario (animal);

                        if (colocouNoHabitat) {
                            System.Console.WriteLine (aquatico.Nadar () + " sabe nadar e" + branquiado.RespirarBaixoDAgua () + ", então deve ficar no habitat Aquário.");
                            System.Console.WriteLine ($"Foi possível alocar {aquatico.Nadar()} no habitat.");
                            System.Console.WriteLine ($"Vagas restantes: {aquario.capacidadeAtual}");
                            Console.ReadLine ();
                        } else {
                            System.Console.WriteLine ($"Não foi possível alocar {aquatico.Nadar()} no Aquário.");
                            System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                            Console.ReadLine ();
                        }
                    }
                }
            } else {
                foreach (Type intFace in tipoAnimal) {

                    if (intFace.Equals (typeof (IVoador))) {
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

                    } else if (intFace.Equals (typeof (ITerrestre))) {
                        ITerrestre terrestre = (ITerrestre) animal;

                        colocouNoHabitat = pasto.ColocarAnimalPasto (animal);
                        if (colocouNoHabitat) {
                            System.Console.WriteLine (terrestre.Andar () + " anda, então deve ficar no habitat Pasto.");
                            System.Console.WriteLine ($"Foi possível alocar {terrestre.Andar()} no habitat.");
                            System.Console.WriteLine ($"Vagas restantes: {pasto.capacidadeAtual}");
                            Console.ReadLine ();
                        } else {
                            colocouNoHabitat = cavernaPedra.ColocarAnimalCavernaPedra (animal);
                            if (colocouNoHabitat) {
                                System.Console.WriteLine (terrestre.Andar () + " anda, então deve ficar no habitat Caverna de Pedra.");
                                System.Console.WriteLine ($"Foi possível alocar {terrestre.Andar()} no habitat.");
                                System.Console.WriteLine ($"Vagas restantes: {cavernaPedra.capacidadeAtual}");
                                Console.ReadLine ();
                            } else {

                                System.Console.WriteLine ($"Não foi possível alocar {terrestre.Andar()} nos habitats Pasto e Caverna de Pedra.");
                                System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                                Console.ReadLine ();
                            }
                        }
                    } else if (intFace.Equals (typeof (IQuionofilo))) {
                        IQuionofilo frio = (IQuionofilo) animal;
                        colocouNoHabitat = aquarioGelado.ColocarAnimalAquarioGelado (animal);

                        if (colocouNoHabitat) {
                            System.Console.WriteLine (frio.ResistirAoFrio () + " resiste ao frio, então deve ficar no habitat Aquário Gelado.");
                            System.Console.WriteLine ($"Foi possível alocar {frio.ResistirAoFrio()} no habitat.");
                            System.Console.WriteLine ($"Vagas restantes: {aquarioGelado.capacidadeAtual}");
                            Console.ReadLine ();
                        } else {
                            System.Console.WriteLine ($"Não foi possível alocar {frio.ResistirAoFrio()} no Aquário Gelado.");
                            System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                            Console.ReadLine ();
                        }
                    } else if (intFace.Equals (typeof (IArboricula))) {
                        IArboricula macaquitos = (IArboricula) animal;
                        colocouNoHabitat = casaArvore.ColocarAnimalCasaArvore (animal);

                        if (colocouNoHabitat) {
                            System.Console.WriteLine (macaquitos.EscalarArvores () + " escala árvores, então deve ficar no habitat Casa de Árvores.");
                            System.Console.WriteLine ($"Foi possível alocar {macaquitos.EscalarArvores()} no habitat.");
                            System.Console.WriteLine ($"Vagas restantes: {casaArvore.capacidadeAtual}");
                            Console.ReadLine ();
                        } else {
                            System.Console.WriteLine ($"Não foi possível alocar {macaquitos.EscalarArvores()} na Casa de Árvores.");
                            System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                            Console.ReadLine ();
                        }
                    } else if (intFace.Equals (typeof (IAquatico))) {
                        IAquatico aquatico = (IAquatico) animal;
                        colocouNoHabitat = piscina.ColocarAnimalPiscina (animal);

                        if (colocouNoHabitat) {
                            System.Console.WriteLine (aquatico.Nadar () + " sabe nadar, então deve ficar no habitat Piscina.");
                            System.Console.WriteLine ($"Foi possível alocar {aquatico.Nadar()} no habitat.");
                            System.Console.WriteLine ($"Vagas restantes: {piscina.capacidadeAtual}");
                            Console.ReadLine ();
                        } else {
                            System.Console.WriteLine ($"Não foi possível alocar {aquatico.Nadar()} na Piscina.");
                            System.Console.WriteLine ("O habitat atingiu sua capacidade máxima.");
                            Console.ReadLine ();
                        }
                    }
                }
            }

        }
    }
}