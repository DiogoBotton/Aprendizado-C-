using System;
using System.Collections.Generic;
using ByteBank2.Models;

namespace ByteBank2 {
    class Program {
        static void Main (string[] args) {
            ContaCorrente contaC1 = new ContaCorrente (1, 1, "Cesar");
            ContaCorrente contaC2 = new ContaCorrente (4545, 9090, "Zézinho");
            ContaEspecial contaE1 = new ContaEspecial (2, 2, "Alexandre");
            
            //ContaBancaria[] Contas = new ContaBancaria[1];
            //List<ContaBancaria> ContasA = new List<ContaBancaria>();
            contaE1.SetLimite(500);

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
                        SacarConta(contaC1);
                        break;

                    case "3":
                        TransferenciaConta(contaC1, contaC2);
                        break;
                }

            }
            #endregion

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