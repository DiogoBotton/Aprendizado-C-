using System;
using System.Collections.Generic;
using ByteBank2.Models;

namespace ByteBank2 {
    class Program {
        static void Main (string[] args) {
            /*List<ContaBancaria> listContas = new List<ContaBancaria> ();
            CriarConta (listContas);
            
            foreach (var conta in listContas)
            {
                System.Console.WriteLine("Titulares: " + conta.Titular);
            }*/
            
            ContaCorrente contaC1 = new ContaCorrente (1, 1, "Cesar");
            ContaCorrente contaC2 = new ContaCorrente (4545, 9090, "Zézinho");
            ContaEspecial contaE1 = new ContaEspecial (2, 2, "Alexandre");
            ContaBancaria[] Contas = new ContaBancaria[1];
            

            #region Ações do usuário ByteBank.

            string escolhaAcao = "";
            while (escolhaAcao != "0") {
                System.Console.WriteLine ("Escolha alguma ação:");
                System.Console.WriteLine ("1 para Depósito.");
                System.Console.WriteLine ("2 para Saque.");
                System.Console.WriteLine ("3 para Transferência.");
                System.Console.WriteLine ("0 para Sair do programa.");
                escolhaAcao = Console.ReadLine ();

                switch (escolhaAcao) {
                    case "1":
                        DepositarConta (contaC1);
                        break;

                    case "2":
                        SacarConta (contaC1);
                        break;

                    case "3":
                        TransferenciaConta (contaC1, contaC2);
                        break;
                }

            }
            #endregion

        }
        public static void CriarConta (List<ContaBancaria> listContas) {
            Console.Clear();
            System.Console.Write ("Entre com o titular da conta: ");
            string titular = Console.ReadLine ();
            System.Console.Write ("Entre com o N° da agência: ");
            int agencia = Convert.ToInt32 (Console.ReadLine ());
            System.Console.Write ("Entre com o N° da conta: ");
            int numConta = Convert.ToInt32 (Console.ReadLine ());

            bool escolheuConta = false;
            do {

                Console.Clear ();
                System.Console.WriteLine ("Entre com o tipo de conta:");
                System.Console.WriteLine ("1 para Conta Corrente.");
                System.Console.WriteLine ("2 para Conta Especial.");
                string tipoConta = Console.ReadLine ();

                switch (tipoConta) {
                    case "1":
                        ContaCorrente contaCorrente = new ContaCorrente (agencia, numConta, titular);
                        listContas.Add (contaCorrente);
                        escolheuConta = true;
                        break;
                    case "2":
                        ContaEspecial contaEspecial = new ContaEspecial (agencia, numConta, titular);
                        System.Console.Write ("Entre com o limite de cheque especial da conta: ");
                        int limite = Convert.ToInt32 (Console.ReadLine ());
                        contaEspecial.SetLimite (limite);

                        listContas.Add (contaEspecial);

                        escolheuConta = true;
                        break;
                    default:
                        System.Console.WriteLine ("Comando Inválido");
                        break;
                }
            } while (!escolheuConta);

            if(escolheuConta){
                System.Console.WriteLine("Conta criada com sucesso.");
            }

        }
        public static void DepositarConta (ContaBancaria contaBancaria) {
            double valor = 0;
            do {
                System.Console.WriteLine ("Digite o valor que deseja depositar:");
                valor = Convert.ToDouble (Console.ReadLine ());

                contaBancaria.Deposito (valor);

            } while (valor < 0);
            if (valor >= 0) {
                System.Console.WriteLine ($"Seu novo saldo agora é R${contaBancaria.Saldo}.");
            }

        }
        public static void SacarConta (ContaBancaria contaBancaria) {
            double valor = 0;
            bool saqueAprovado = false;
            do {
                System.Console.WriteLine ("Digite o valor que deseja sacar:");
                valor = Convert.ToDouble (Console.ReadLine ());

                saqueAprovado = contaBancaria.Saque (valor);
            } while (!saqueAprovado);
            if (saqueAprovado) {
                System.Console.WriteLine ($"Seu novo saldo agora é R${contaBancaria.Saldo}.");
            }
        }
        public static void TransferenciaConta (ContaBancaria contaBancaria, ContaBancaria contaC2) {
            bool transferenciaAprovada = false;
            double valor = 0;
            do {
                System.Console.WriteLine ("Digite o valor a ser transferido:");
                valor = Convert.ToDouble (Console.ReadLine ());

                transferenciaAprovada = contaBancaria.Transferencia (contaC2, valor);

                if (transferenciaAprovada) {
                    System.Console.ForegroundColor = System.ConsoleColor.Green;
                    System.Console.WriteLine ("Transferência efetuada com sucesso.");
                    System.Console.ResetColor ();

                    System.Console.WriteLine ($"Novo saldo: R${contaBancaria.Saldo}.");
                    System.Console.WriteLine ($"Saldo conta de origem: R${contaC2.Saldo}.");
                } else {
                    System.Console.WriteLine ("Não foi possível realizar a transferência, você não possuí este valor. ");
                }
            } while (!transferenciaAprovada);
        }
    }
}