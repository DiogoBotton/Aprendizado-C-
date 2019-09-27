using System;

namespace codingdojo
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;
            int alt = 0;
            string ast = "*";
            string ast2 = "*";

            Console.WriteLine("Digite um número:");
            qtd = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite a altura:");
            alt = Convert.ToInt32(Console.ReadLine());
            
            // Com while
            while (qtd != 0)
            {
                for (int i = 0; i < alt; i++)
                {
                    Console.WriteLine(ast2); //valor fixo que será impresso
                    ast2 += ast; //soma +1 ast para o próximo loop.
                }
                ast2 = "*"; // declarando novamente com quantos asteriscos ele irá iniciar a próxima repetição (for), para não iniciar novamente com a mesma quantidade do loop anterior.
                qtd--; //
            }

            // Com FOR
            /*
            for (int i = 0; i < qtd; i++){
                for (int j = 0; j < alt; j++){
                    Console.WriteLine(ast2);
                    ast2 += ast;
                }
                ast2 = "*";
            }
            */

        }
    }
}
