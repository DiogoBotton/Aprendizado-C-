using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Bom dia, boa tarde, boa noite, funcionário! Decidimos dar um aumento salárial de 30% para aqueles cujo salário é menor que R$ 500,00.");
            Console.Write("Digite seu salário aqui: R$");
            salario = Convert.ToDouble(Console.ReadLine()); //Converte o readline que lê por padrão String para DOUBLE

            double aumento30p;

            aumento30p = (salario * 0.3) + salario;

            if (salario <= 500)
            {
                Console.WriteLine("Seu novo salário será: R$" + aumento30p);
            }
            else 
            {
                Console.WriteLine($"Seu salário é maior do que R$ 500,00. Pois então, você continuará recebendo o seu salário normal, que é R${salario}.");
            }

        }
    }
}
