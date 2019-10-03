using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Cliente cliente = CriarCliente();
            
            ContaCorrente conta = CriarConta();
            

        }
        public static Cliente CriarCliente(){
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite seu Email");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(nome, cpf, email);
            
            string senha = "";
            string validacaoSenha = "";

            bool trocouSenha = false;

            do{
            Console.WriteLine("Digite uma senha");
            senha = Console.ReadLine();

            trocouSenha = cliente.TrocaSenha(senha); //Recebe o valor booleano da classe.
            
                if (trocouSenha == false){
                    System.Console.WriteLine("Digite uma senha com mais de 6 caracteres e menor que 16.");
                }
                else {
                    do{

                    System.Console.WriteLine("Confirme sua senha.");
                    validacaoSenha = Console.ReadLine();

                    if (validacaoSenha == senha){
                        System.Console.WriteLine("Sua conta foi cadastrada com sucesso!");
                    }
                    else{
                        System.Console.WriteLine("Senhas não correspondem, digite novamente.");
                    }
                    }while (validacaoSenha != senha);
                }
            }while (trocouSenha != true);//ou (!trocouSenha)

            return cliente;
        }
        public static ContaCorrente CriarConta(){
            Console.WriteLine("Entre com o Titular:");
            string titular = Console.ReadLine();
            Console.WriteLine("Entre com o número da Agência:");
            int agencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(agencia, numero, titular);
            
            do{
            Console.WriteLine("Entre com o Saldo da conta:");
            conta.Saldo = Convert.ToDouble(Console.ReadLine());
                if (conta.Saldo < 0){
                    System.Console.WriteLine("Você não pode iniciar a conta com saldo negativo.");
                }
            }while (conta.Saldo < 0);

            System.Console.WriteLine($"O saldo atual da conta é: R$ {conta.Saldo}. ");

            return conta;
        }
    }
}
