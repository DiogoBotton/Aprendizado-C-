using System;

namespace argsTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
            Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
    }
}
