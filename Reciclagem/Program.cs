using System;
using System.Collections.Generic;
using System.Linq;
using Reciclagem.Interfaces;
using Reciclagem.Models; //Buscar coisas dentro da coleção.

namespace Reciclagem {
    enum LixosEnum : int {
        GarrafaPET = 1,
        GuardaChuva,
        Latinha,
        Papelao,
        PoteManteiga,
        CascaDeBanana

    }
    class Program {
        static void Main (string[] args) {
            int codigo = 0;

            do {

                Console.Clear ();

                System.Console.WriteLine ("|______Programa de Reciclagem______|");
                System.Console.WriteLine ("           Tipos de Lixo:           ");
                System.Console.WriteLine ();
                ExibirLixos ();
                System.Console.WriteLine ();
                System.Console.WriteLine ("Jogue algum objeto no lixo digitando seu código.");
                System.Console.WriteLine ("|__________________________________|");
                codigo = Convert.ToInt32 (Console.ReadLine ());

                if (codigo < 1 || codigo > TiposDeLixo.lixos.Count) {
                    System.Console.WriteLine ("Código inválido.");
                }
            } while (codigo < 1 || codigo > TiposDeLixo.lixos.Count);
            var lixo = TiposDeLixo.lixos[codigo];

            Type lixinho = TiposDeLixo.lixos[codigo].GetType ().GetInterfaces ().FirstOrDefault ();

            Reciclar (TiposDeLixo.lixos[codigo]);
            //Precisa-se dos IF's pois a classe lixo não sabe as interfaces que suas classes filhas herdam.

            if (lixinho.Equals (typeof (AzulPapel))) {
                AzulPapel lixozinho = (AzulPapel) lixo;
                TipoReciclagem (lixozinho);
            } else if (lixinho.Equals (typeof (CinzaNaoReciclavel))) {
                CinzaNaoReciclavel lixozinho = (CinzaNaoReciclavel) lixo;
                TipoReciclagem (lixozinho);
            } else if (lixinho.Equals (typeof (MetalAmarelo))) {
                MetalAmarelo lixozinho = (MetalAmarelo) lixo;
                TipoReciclagem (lixozinho);
            } else if (lixinho.Equals (typeof (PretoOrganico))) {
                PretoOrganico lixozinho = (PretoOrganico) lixo;
                TipoReciclagem (lixozinho);
            } else if (lixinho.Equals (typeof (VerdeVidro))) {
                VerdeVidro lixozinho = (VerdeVidro) lixo;
                TipoReciclagem (lixozinho);
            } else if (lixinho.Equals (typeof (VermelhoPlastico))) {
                VermelhoPlastico lixozinho = (VermelhoPlastico) lixo;
                TipoReciclagem (lixozinho);
            }

        }
        public static void ExibirLixos () {
            string[] TiposDeLixos = Enum.GetNames (typeof (LixosEnum));
            int count = 1;
            foreach (var lixo in TiposDeLixos) {
                System.Console.WriteLine ($"          {count++}.{lixo}");
            }
        }
        public static void Reciclar (Lixo lixo) {

            Type Tipolixo = lixo.GetType ().GetInterfaces ().FirstOrDefault ();
            if (Tipolixo.Equals (typeof (PretoOrganico))) {
                //Casting = Método de conversão. A classe LIXO não "enxerga" o que tem dentro da classe CascaBanana, e por isso, indicamos para ela o que queremos.
                PretoOrganico organico = (PretoOrganico) lixo; //"Eu garanto que lixo contem PretoOrganico."
                System.Console.WriteLine (organico.Composteira () + " foi levado para a COMPOSTAGEM.");
                Console.ReadLine ();

            } else if (Tipolixo.Equals (typeof (VerdeVidro))) {
                VerdeVidro vidro = (VerdeVidro) lixo;
                System.Console.WriteLine (vidro.ReciclarVidro () + " foi jogado no lixo VERDE.");
                Console.ReadLine ();
            } else if (Tipolixo.Equals (typeof (AzulPapel))) {
                AzulPapel papel = (AzulPapel) lixo;
                System.Console.WriteLine (papel.ReciclarPapel () + " foi jogado no lixo AZUL.");
                Console.ReadLine ();
            } else if (Tipolixo.Equals (typeof (VermelhoPlastico))) {
                VermelhoPlastico plastico = (VermelhoPlastico) lixo;
                System.Console.WriteLine (plastico.ReciclarPlastico () + " foi jogado no lixo VERMELHO.");
                Console.ReadLine ();
            } else if (Tipolixo.Equals (typeof (MetalAmarelo))) {
                MetalAmarelo metal = (MetalAmarelo) lixo;
                System.Console.WriteLine (metal.ReciclarMetal () + " foi jogado no lixo AMARELO.");
                Console.ReadLine ();
            } else if (Tipolixo.Equals (typeof (CinzaNaoReciclavel))) {
                CinzaNaoReciclavel especial = (CinzaNaoReciclavel) lixo;
                System.Console.WriteLine (especial.DescarteEspecial () + " foi jogado no lixo de DESCARTES ESPECIAIS (CINZA).");
                Console.ReadLine ();
            }

        }
        public static void TipoReciclagem (AzulPapel lixo) {
            System.Console.WriteLine (lixo.ReciclarPapel () + " Deve sempre ser jogado na lixeira de PAPEIS.");
        }
        public static void TipoReciclagem (CinzaNaoReciclavel lixo) {
            System.Console.WriteLine (lixo.DescarteEspecial () + " Deve sempre ser jogado na lixeira de Descartes especiais.");
        }
        public static void TipoReciclagem (MetalAmarelo lixo) {
            System.Console.WriteLine (lixo.ReciclarMetal () + " Deve sempre ser jogado na lixeira de METAIS.");
        }
        public static void TipoReciclagem (PretoOrganico lixo) {
            System.Console.WriteLine (lixo.Composteira () + " Deve sempre ser jogado na lixeira de ORGÂNICOS.");
        }
        public static void TipoReciclagem (VerdeVidro lixo) {
            System.Console.WriteLine (lixo.ReciclarVidro () + " Deve sempre ser jogado na lixeira de VIDROS.");
        }
        public static void TipoReciclagem (VermelhoPlastico lixo) {
            System.Console.WriteLine (lixo.ReciclarPlastico () + " Deve sempre ser jogado na lixeira de PLASTICOS.");
        }
    }
}