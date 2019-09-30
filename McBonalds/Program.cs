using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Jose","55 55 5555-5555","ze@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Tel: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
            Console.WriteLine();

            // FAZER: Sistema de coleções para cadastro de clientes (mais de um)

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite uma senha:");
            string senha = Console.ReadLine();
            Console.WriteLine("Digite seu endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Digite seu telefone:");
            string tel = Console.ReadLine();
            Console.WriteLine("Digite seu email:");
            string email = Console.ReadLine();

            Cliente cliente2 = new Cliente(nome, tel, email);

            Console.WriteLine("Nome: " + cliente2.Nome + " Telefone: " + cliente2.Telefone + " Email: " + cliente2.Email);
            



            
         
        }

    }
}




