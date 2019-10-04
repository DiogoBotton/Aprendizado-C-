using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            // #region NomeDaRegiao
            // #endregion

            #region Cadastro de Clientes.
            Console.WriteLine ("Digite seu nome");
            string nome = Console.ReadLine ();
            Console.WriteLine ("Digite seu CPF");
            string cpf = Console.ReadLine ();
            Console.WriteLine ("Digite seu Email");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            string senha = "";
            string validacaoSenha = "";

            bool trocouSenha = false;

            do {
                Console.WriteLine ("Digite uma senha");
                senha = Console.ReadLine ();

                trocouSenha = cliente1.TrocaSenha (senha); //Recebe o valor booleano da classe.

                if (trocouSenha == false) {
                    System.Console.WriteLine ("Digite uma senha com mais de 6 caracteres e menor que 16.");
                } else {
                    do {

                        System.Console.WriteLine ("Confirme sua senha.");
                        validacaoSenha = Console.ReadLine ();

                        if (validacaoSenha == senha) {
                            System.Console.WriteLine ("Sua conta foi cadastrada com sucesso!");
                        } else {
                            System.Console.WriteLine ("Senhas não correspondem, digite novamente.");
                        }
                    } while (validacaoSenha != senha);
                }
            } while (trocouSenha != true); //ou (!trocouSenha)
            #endregion

            //---------------------------------------------------------------------------------------------------------------------

            #region Conta Corrente.
            Console.WriteLine ("Entre com o número da Agência:");
            int agencia = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Entre com o número da conta:");
            int conta = Convert.ToInt32 (Console.ReadLine ());

            ContaCorrente conta1 = new ContaCorrente (agencia, conta, cliente1); //Titular recebe a classe CLIENTE.

            do {
                Console.WriteLine ("Inicie o saldo da conta do cliente:");
                conta1.Saldo = Convert.ToDouble (Console.ReadLine ());
                if (conta1.Saldo < 0) {
                    System.Console.WriteLine ("Você não pode iniciar a conta com saldo negativo.");
                }
            } while (conta1.Saldo < 0);

            System.Console.WriteLine ($"O saldo atual da conta é: R$ {conta1.Saldo}. ");
            #endregion

            #region Ações do usuário ByteBank.
            Cliente cliente2 = new Cliente ("Zé", "422.547.654.15", "zezinhoi@gmail.com");
            ContaCorrente conta2 = new ContaCorrente (4545, 9090, cliente2);

            string escolhaAcao = "";
            while (escolhaAcao != "0") {
                System.Console.WriteLine ("Escolha alguma ação:");
                System.Console.WriteLine ("1 para Depósito.");
                System.Console.WriteLine ("2 para Saque.");
                System.Console.WriteLine ("3 para Transferência.");
                System.Console.WriteLine ("0 para Sair do programa.");
                escolhaAcao = Console.ReadLine ();

                double valor = 0;
                    switch (escolhaAcao) {
                        case "1":
                            do {
                                System.Console.WriteLine ("Digite o valor que deseja depositar:");
                                valor = Convert.ToDouble (Console.ReadLine ());

                                conta1.Deposito (valor);

                            } while (valor < 0);
                            if (valor >= 0) {
                                System.Console.WriteLine ($"Seu novo saldo agora é R${conta1.Saldo}.");
                            }
                            break;

                        case "2":
                            bool saqueAprovado = false;
                            do {
                                System.Console.WriteLine ("Digite o valor que deseja sacar:");
                                valor = Convert.ToDouble (Console.ReadLine ());

                                saqueAprovado = conta1.Saque (valor);
                            } while (!saqueAprovado);
                            if (saqueAprovado) {
                                System.Console.WriteLine ($"Seu novo saldo agora é R${conta1.Saldo}.");
                            }

                            break;

                        case "3":
                            bool transferenciaAprovada = false;
                            do {

                                /*/System.Console.WriteLine("Digite a conta corrente de destino:");
                                Console.ReadLine();*/
                                System.Console.WriteLine ("Digite o valor a ser transferido:");
                                valor = Convert.ToDouble (Console.ReadLine ());

                                transferenciaAprovada = conta1.Transferencia (conta2, valor);

                                if (transferenciaAprovada == true) {
                                    System.Console.ForegroundColor = System.ConsoleColor.Green;
                                    System.Console.WriteLine ("Transferência efetuada com sucesso.");
                                    System.Console.ResetColor ();

                                    System.Console.WriteLine ($"Novo saldo: R${conta1.Saldo}.");
                                    System.Console.WriteLine ($"Saldo conta de origem: R${conta2.Saldo}.");
                                } else {
                                    System.Console.WriteLine ("Não foi possível realizar a transferência, você não possuí este valor. ");
                                }
                            } while (transferenciaAprovada == false);
                            break;
                    }
                
            }
            #endregion

        }
        /*public static Cliente CriarCliente(){}
        public static ContaCorrente CriarConta(){}*/
    }
}