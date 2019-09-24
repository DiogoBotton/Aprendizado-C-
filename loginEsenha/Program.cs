using System;

namespace loginEsenha {
    class Program {
        static void Main (string[] args) {

            string login_adm = "admin";
            string senha_adm = "admin";

            string login = "";
            string senha = "";

            string registro_login = "";
            string registro_senha = "";

            string resp;

            Console.Write ("Digite seu Login:");
            login = Console.ReadLine ();

            Console.Write ("Digite sua Senha:");
            senha = Console.ReadLine ();

            if ((login == login_adm) && (senha == senha_adm)) {
                Console.WriteLine ("Você logou como ADMIN.");
            } else if ((login != registro_login) && (senha != registro_senha)) {
                Console.WriteLine ("Login e senha inválidos ou não encontrado nas credênciais do programa.");
                Console.WriteLine ("Deseja fazer um cadastro? Responda s / n (fechar programa).");
                resp = Console.ReadLine ();

                switch (resp) {
                    case "s":
                        Console.Write ("Crie um login:");
                        registro_login = Console.ReadLine ();
                        Console.Write ("Crie uma senha:");
                        registro_senha = Console.ReadLine ();

                        Console.WriteLine ("Você foi registrado com sucesso! Agora faça o seu login.");

                        while ((login != registro_login) || (senha != registro_senha)) {

                            Console.Write ("Digite seu Login:");
                            login = Console.ReadLine ();

                            Console.Write ("Digite sua Senha:");
                            senha = Console.ReadLine ();

                            if ((login != registro_login) || (senha != registro_senha)){
                                Console.WriteLine("Login ou senha invalidos, tente novamente. ");
                            }
                        }
                        if ((login == registro_login) && (senha == registro_senha)) {
                            Console.WriteLine ("Seu login foi efetuado com sucesso.");
                        }
                        break;
                    case "n":
                        Console.Write ("O programa será finalizado.");
                        break;
                }

            }

        }
    }
}