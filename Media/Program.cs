using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float num4 = 0;

            Console.WriteLine("Digite o 1° número");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° número");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3° número");
            num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 4° número");
            num4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} + {num3} + {num4} / 4 = {num1 + num2 + num3 + num4 / 4}");

        }
    }
}
