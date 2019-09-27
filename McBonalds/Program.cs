using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente ("Jose","55 55 5555-5555","ze@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Tel: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);

            // Sistema de coleções para cadastro de clientes (mais de um)

            
         
        }

    }
}




