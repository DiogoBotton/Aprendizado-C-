using System;
using System.Collections.Generic;
using McBonalds.Models;

namespace McBonalds {
    class Program {
        static void Main (string[] args) {
            //FEITO: Sistema de coleções para cadastro de clientes (mais de um)

            //TODO: Login ADM, classe PRODUTOS que terá hamburgueres e shakes, que terão seus subprodutos (hamburguer vegano, shake de chocolate, etc), e classe pedidos(?)
            //PROBLEMA: Se o programa for salvo em csv, sempre vai acrescentar à lista de clientes mais uma conta ADMIN.
            List<Cliente> listClientes = new List<Cliente> () { new Cliente ("admin", "admin") };
            //TODO: Pergunta: o ADM pode estar na lista de CLIENTES??

            List<Shake> shakes = new List<Shake> () { { new Shake ("Shake de Cholate", 10.99) }, { new Shake ("Shake de Morango", 9.90) }, { new Shake ("Shake de Nutella", 12.90) }
            };
            List<Hamburguer> hamburgueres = new List<Hamburguer> () { { new Hamburguer ("Hambúrguer Vegano", 10.90) }, { new Hamburguer ("Hambúrguer FURIOSO", 12.90) }, { new Hamburguer ("Hambúrguer Vegano", 11.90) }
            };

            int indexList = 0;
            bool querSair = false;
            bool fezLogin = false;
            do {
                Console.Clear ();

                System.Console.WriteLine ("Bem Vindo á Hamburgueria McBonalds!!!");
                System.Console.WriteLine ("Digite uma das opções abaixo:");
                System.Console.WriteLine ("1 - Criar Cadastro.");
                System.Console.WriteLine ("2 - Fazer Login");
                System.Console.WriteLine ("3 - Visualizar produtos.");
                System.Console.WriteLine ("0 - Sair.");
                string opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        CriarCadastro (listClientes);
                        break;

                    case "2":
                        fezLogin = FazerLogin (listClientes, out indexList);
                        //TODO: Visualização de pedidos.
                        if (fezLogin) {
                            //*Provaveis problemas futuros na gravação do programa em arquivo CSV nesta condição.
                            if (indexList != 0 && indexList > 0) {
                                #region Menu Cliente Logado.

                                Cliente usuario = listClientes[indexList];

                                bool saiuDaConta = false;

                                do {
                                    Console.Clear ();

                                    System.Console.WriteLine ($"Olá, {usuario.Nome}! Seja Bem Vindo ");
                                    System.Console.WriteLine ("Escolha uma das opções abaixo:");
                                    System.Console.WriteLine ("1 - Comprar Hamburgueres.");
                                    System.Console.WriteLine ("2 - Comprar Shakes.");
                                    System.Console.WriteLine ("3 - Adicionar saldo na carteira.");
                                    System.Console.WriteLine ("0 - Sair da Conta.");
                                    string opcoesLogado = Console.ReadLine ();

                                    switch (opcoesLogado) {
                                        case "1":
                                            Console.Clear ();

                                            bool compraConcluida = false;

                                            int codigoH = 0;
                                            do {
                                                ExibirMenuHamburgueres (hamburgueres);

                                                System.Console.WriteLine ("Digite o código do hambúrguer desejado.");
                                                codigoH = Convert.ToInt32 (Console.ReadLine ());
                                                if (codigoH <= 0 || codigoH > shakes.Count) {
                                                    System.Console.WriteLine ("Código Inválido.");
                                                    Console.ReadLine();
                                                    
                                                }
                                            } while (codigoH <= 0 || codigoH > shakes.Count);

                                            Hamburguer hbg = hamburgueres[codigoH - 1];

                                            compraConcluida = usuario.ComprarProduto (hbg.Preco);

                                            if (compraConcluida) {
                                                Console.Clear ();

                                                System.Console.WriteLine ("Sua compra foi realizada com sucesso!");
                                                System.Console.WriteLine ($"Você comprou [{hbg.Nome}] por [R$ {hbg.Preco}].");
                                                System.Console.WriteLine ($"Seu novo saldo na carteira é: R$ {usuario.Carteira}.");
                                                Console.ReadLine ();
                                            } else {
                                                Console.Clear ();

                                                System.Console.WriteLine ("Não foi possível realizar a compra, você não possúi saldo suficiente na carteira McBonalds.");
                                                System.Console.WriteLine ($"Seu saldo na carteira: R$ {usuario.Carteira}.");
                                                Console.ReadLine ();
                                            }

                                            break;

                                        case "2":
                                            Console.Clear ();
                                            int codigoS = 0;
                                            do {
                                                ExibirMenuShakes (shakes);
                                                System.Console.WriteLine ("Digite o código do hambúrguer desejado.");
                                                codigoS = Convert.ToInt32 (Console.ReadLine ());

                                                if (codigoS <= 0 || codigoS > shakes.Count) {
                                                    System.Console.WriteLine ("Código Inválido.");
                                                    Console.ReadLine();
                                                    
                                                }
                                            } while (codigoS <= 0 || codigoS > shakes.Count);

                                            Shake shk = shakes[codigoS - 1];

                                            compraConcluida = usuario.ComprarProduto (shk.Preco);

                                            if (compraConcluida) {
                                                Console.Clear ();

                                                System.Console.WriteLine ("Sua compra foi realizada com sucesso!");
                                                System.Console.WriteLine ($"Você comprou [{shk.Nome}] por [R$ {shk.Preco}].");
                                                System.Console.WriteLine ($"Seu novo saldo na carteira é: R$ {usuario.Carteira}.");
                                                Console.ReadLine ();
                                            } else {
                                                Console.Clear ();

                                                System.Console.WriteLine ("Não foi possível realizar a compra, você não possúi saldo na carteira McBonalds.");
                                                System.Console.WriteLine ($"Seu saldo na carteira: R$ {usuario.Carteira}.");
                                                Console.ReadLine ();
                                            }

                                            break;

                                        case "3":
                                            Console.Clear ();

                                            bool depositoRealizado = false;

                                            System.Console.Write ("Digite o valor que será depositado na carteira McBonalds: ");
                                            double valor = Convert.ToInt32 (Console.ReadLine ());

                                            depositoRealizado = usuario.AdcSaldoCarteira (valor);

                                            if (depositoRealizado) {
                                                System.Console.WriteLine ($"Foi depositado [R$ {valor}] na sua carteira.");
                                                System.Console.WriteLine ($"Seu novo saldo na carteira é: R$ {usuario.Carteira}.");
                                                Console.ReadLine ();
                                            } else {
                                                System.Console.WriteLine ("Não foi possível fazer o deposito na carteira McBonalds.");
                                                System.Console.WriteLine ("Verifique se você utilizou de números negativos ou nulos.");
                                                Console.ReadLine ();
                                            }

                                            break;

                                        case "0":
                                            System.Console.WriteLine ($"Até mais {usuario.Nome}, volte sempre!");
                                            System.Console.WriteLine ("Você deslogou.");
                                            Console.ReadLine ();
                                            saiuDaConta = true;
                                            break;

                                        default:
                                            System.Console.WriteLine ("Comando Inválido.");
                                            break;
                                    }
                                } while (!saiuDaConta);
                                #endregion
                            } else {
                                #region Menu ADMIN

                                Cliente admin = listClientes[indexList];

                                bool saiuDaConta = false;

                                do {
                                    Console.Clear ();
                                    //Ideias: possibilidade de acrescentar à lista um novo lanche ou Shake.,
                                    //Enviar ao cliente uma MSG (nos meus pedidos) se foi aceito ou não.
                                    //Perguntas: Como que irá aceitar um pedido?
                                    System.Console.WriteLine ($"Conta ADMIN:[{admin.Nome}], DashBoard ADM. ");
                                    System.Console.WriteLine ("Escolha uma das opções abaixo:");
                                    System.Console.WriteLine ("1 - Pedidos.");
                                    System.Console.WriteLine ("2 - Visualizar lista de clientes");
                                    System.Console.WriteLine ("3 - .");
                                    System.Console.WriteLine ("0 - Sair da Conta.");
                                    string opcoesAdm = Console.ReadLine ();

                                    switch (opcoesAdm) {
                                        case "1":
                                            break;

                                        case "2":
                                            break;

                                        case "0":
                                            saiuDaConta = true;
                                            break;

                                        default:
                                            System.Console.WriteLine ("Comando Inválido.");
                                            break;
                                    }
                                } while (!saiuDaConta);
                                #endregion
                            }
                        }
                        break;

                    case "3":
                        #region Menu de visualização de produtos.

                        bool sairViewProdutos = false;
                        do {
                            Console.Clear ();

                            System.Console.WriteLine ("Escolha uma das opções abaixo:");
                            System.Console.WriteLine ("1 - Hamburgueres.");
                            System.Console.WriteLine ("2 - Shakes.");
                            System.Console.WriteLine ("0 - Sair do menu de visualização.");
                            string opcaoView = Console.ReadLine ();
                            switch (opcaoView) {
                                case "1":
                                    ExibirMenuHamburgueres (hamburgueres);
                                    System.Console.WriteLine ("Para comprar algum produto, você deve estar cadastrado e logado.");
                                    Console.ReadLine ();

                                    break;

                                case "2":
                                    ExibirMenuShakes (shakes);
                                    System.Console.WriteLine ("Para comprar algum produto, você deve estar cadastrado e logado.");
                                    Console.ReadLine ();

                                    break;

                                case "0":
                                    sairViewProdutos = true;
                                    break;

                                default:
                                    System.Console.WriteLine ("Comando Inválido.");
                                    break;
                            }
                        } while (!sairViewProdutos);

                        #endregion
                        break;

                    case "0":
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Inválido.");
                        break;
                }

            } while (!querSair);

        }
        public static void CriarCadastro (List<Cliente> listClientes) {
            bool nomeJaExiste = false;
            string nome = "";

            do {
                Console.WriteLine ("Digite seu nome:");
                nome = Console.ReadLine ();

                foreach (Cliente item in listClientes) {

                    if (item.Nome == nome) {
                        System.Console.WriteLine ("Este nome já existe, tente novamente.");
                        nomeJaExiste = true;
                        break;
                    } else {
                        nomeJaExiste = false;
                    }

                }
            } while (nomeJaExiste);

            Console.WriteLine ("Digite sua data de nascimento:");
            DateTime data = Convert.ToDateTime (Console.ReadLine ());
            Console.WriteLine ("Digite seu endereço:");
            string endereco = Console.ReadLine ();
            Console.WriteLine ("Digite seu telefone:");
            int tel = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Digite seu email:");
            string email = Console.ReadLine ();
            Console.WriteLine ("Digite seu CPF/CNPJ:");
            int cpf = Convert.ToInt32 (Console.ReadLine ());

            Cliente cliente = new Cliente (nome, tel, email, cpf);
            cliente.dataNascimento = data;
            cliente.Endereco = endereco;

            bool trocouSenha = false;

            do {
                Console.WriteLine ("Digite uma senha:");
                string senha = Console.ReadLine ();
                trocouSenha = cliente.TrocarSenha (senha);

                if (!trocouSenha) {
                    System.Console.WriteLine ("Digite uma senha entre 6 e 16 caracteres.");
                } else {
                    System.Console.WriteLine ("Sua conta foi cadastrada com sucesso.");
                    Console.ReadLine ();
                }
            } while (!trocouSenha);

            listClientes.Add (cliente);

        }
        public static bool FazerLogin (List<Cliente> listClientes, out int indexList) {
            bool nomeExiste = false;
            bool validacaoSenha = false;
            bool contaAdmin = false;
            int index = 0;

            System.Console.Write ("Digite seu nome: ");
            string nome = Console.ReadLine ();

            foreach (Cliente item in listClientes) {
                if (item.Nome == nome) {
                    nomeExiste = true;
                    if (item.Nome == "admin") {
                        contaAdmin = true;
                    } else {
                        contaAdmin = false;
                    }
                    break;
                } else {
                    nomeExiste = false;
                }
                index++;
            }

            System.Console.Write ("Digite sua senha: ");
            string senha = Console.ReadLine ();

            foreach (Cliente item in listClientes) {
                if (item.Senha == senha) {
                    validacaoSenha = true;
                    break;
                } else {
                    validacaoSenha = false;
                }
            }

            if (!contaAdmin) {
                if (nomeExiste && validacaoSenha) {
                    Cliente conta = listClientes[index];
                    System.Console.WriteLine ($"Olá, {conta.Nome}! Você logou com sucesso!");
                    System.Console.WriteLine ($"Você tem R${conta.Carteira} de saldo na sua carteira McBonalds. ");
                    indexList = index;
                    Console.ReadLine ();
                    return true;
                } else {
                    System.Console.WriteLine ("Nome ou senha inválidos.");
                    indexList = -1;
                    Console.ReadLine ();
                    return false;
                }
            } else {
                if (validacaoSenha) {

                    System.Console.WriteLine ("Você entrou com uma Conta ADMIN.");
                    indexList = index;
                    Console.ReadLine ();
                    return true;
                } else {
                    System.Console.WriteLine ("Senha ADMIN incorreta.");
                    indexList = -1;
                    Console.ReadLine ();
                    return false;
                }
            }

        }
        public static void ExibirMenuHamburgueres (List<Hamburguer> hamburgueres) {
            Console.Clear ();

            int codigo = 1;

            System.Console.WriteLine ("################################");
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine ("#        Hambúrgueres        #");
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine ("################################");

            foreach (Hamburguer hbg in hamburgueres) {
                System.Console.WriteLine ($"  {codigo++}.{hbg.Nome}  Preço: R$ {hbg.Preco}");
            }
        }
        public static void ExibirMenuShakes (List<Shake> shakes) {
            Console.Clear ();

            int codigo = 1;

            System.Console.WriteLine ("################################");
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine ("#           Shakes           #");
            System.Console.WriteLine ("#                            #");
            System.Console.WriteLine ("################################");

            foreach (Shake shk in shakes) {
                System.Console.WriteLine ($"  {codigo++}.{shk.Nome}  Preço: R$ {shk.Preco}");
            }
        }

    }
}