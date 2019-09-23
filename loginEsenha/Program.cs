using System;

namespace loginEsenha
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string login_adm = "admin";
            string senha_adm = "admin";

            string login = "";
            string senha = "";

            Console.Write("Login:");
            login = Console.ReadLine();

            Console.Write("Senha:");
            senha = Console.ReadLine();

            if ((login == login_adm) && (senha == senha_adm))
            {
                Console.WriteLine("Você logou como ADMIN.");
            }
            else {
                Console.WriteLine("Você logou como usuário.");
            }
        
    
                     

        }
    }
}
