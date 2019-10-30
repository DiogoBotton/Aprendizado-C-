using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax² + bx + C = 0");

            System.Console.Write("Digite ax: ");
            int ax = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Digite bx: ");
            int bx = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Digite c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            double b2 = Math.Pow(bx, 2);

            int AxC = (4 * ax) * c;

            double delta = b2 - AxC;

            System.Console.WriteLine("Valor Delta: " + delta);

        }
    }
}
