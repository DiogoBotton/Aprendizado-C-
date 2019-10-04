namespace ByteBank {
    class ContaCorrente {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public double Saldo { get; set; }

        public ContaCorrente (int Agencia, int Conta, Cliente Titular) {
            this.Agencia = Agencia;
            this.Conta = Conta;
            this.Titular = Titular;
            this.Saldo = 0;
        }

        public double Deposito (double deposito) {
            if (deposito < 0) {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine ("Você não pode depositar um valor negativo.");
                System.Console.ResetColor ();
                return this.Saldo;
            } else {
                this.Saldo += deposito;
                return this.Saldo;
            }
        }
        public bool Saque (double saque) {
            if (saque <= Saldo && saque > 0) //Não poderá sacar numeros negativos
            {
                this.Saldo -= saque;
                return true;
            } else {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine ("Você não possuí esse saldo ou utilizou de números negativos.");
                System.Console.ResetColor ();
                return false;
            }
        }
        public bool Transferencia (ContaCorrente contaDestino, double transferencia) {
            if (this.Saque (transferencia)) { //Se o método SAQUE retornar verdadeiro, Utilize do método DEPÓSITO
                //contaDestino.Saldo += transferencia; // Sem chamar o método deposito.
                contaDestino.Deposito (transferencia); //Chamou o metodo deposito para fazer transferência.
                return true;
            } else {
                return false;
            }
        }

    }
}