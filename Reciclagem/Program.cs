using Reciclagem.Models;
using Reciclagem.Interfaces;
using System;
using System.Collections.Generic;

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

            do{

            Console.Clear();
            
            System.Console.WriteLine ("|______Programa de Reciclagem______|");
            System.Console.WriteLine ("           Tipos de Lixo:           ");
            System.Console.WriteLine();
            ExibirLixos();
            System.Console.WriteLine();
            System.Console.WriteLine("Jogue algum objeto no lixo digitando seu código.");
            System.Console.WriteLine ("|__________________________________|");
            codigo = Convert.ToInt32(Console.ReadLine());
            
                if (codigo < 1 || codigo > TiposDeLixo.lixos.Count){
                    System.Console.WriteLine("Código inválido.");
                }
            }while(codigo < 1 || codigo > TiposDeLixo.lixos.Count);

            var lixos = TiposDeLixo.lixos[codigo];
            string msg = lixos.JogarNoLixo();
            System.Console.WriteLine(msg);
            msg = lixos.Lixeira();
            System.Console.WriteLine(msg);

            Type composteira = lixos.GetType().GetInterface("PretoOrganico");
            if(composteira != null){
                //Casting = Método de conversão. A classe LIXO não "enxerga" o que tem dentro da classe CascaBanana, e por isso, indicamos para ela o que queremos.
                msg = ((CascaBanana) lixos).Composteira();
                System.Console.WriteLine(msg);
            }
            Console.ReadLine();
            
            
        }
        public static void ExibirLixos () {
            string[] TiposDeLixos = Enum.GetNames(typeof(LixosEnum));
            int count = 1;
            foreach (var lixo in TiposDeLixos)
            {
                System.Console.WriteLine($"          {count++}.{lixo}");
            }
        }
    }
}