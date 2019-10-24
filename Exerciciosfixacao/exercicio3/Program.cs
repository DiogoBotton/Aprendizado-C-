using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tempo da viagem? Em horas.");
            double tempo = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Qual será a velocidade média? Em km/h.");
            double Velo = Convert.ToDouble(Console.ReadLine());

            double distancia = tempo * Velo;

            double litrosUsados = distancia / 12;

            System.Console.WriteLine("Litros usados na viagem: " + litrosUsados);

            System.Console.WriteLine("Programa 2:");
            Console.ReadLine();
            Console.Clear();
            

           // System.Console.WriteLine("Qual a distancia a ser percorrida?");
            //double distancia = Convert.ToDouble(Console.ReadLine());
            
            System.Console.WriteLine("Temp celsius: ");
            double TC = Convert.ToDouble(Console.ReadLine());

            double conversaoF = ((TC / 5) * 9) + 32;

            System.Console.WriteLine("Fahrenheit: " + conversaoF);




        }
    }
}
