namespace ByteBank {
    class ContaCorrente {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        private double _Saldo;

        public double Saldo{
            get {return _Saldo;} //_Saldo apenas leitura (get)
        }

        public ContaCorrente (int Agencia, int Conta, Cliente Titular) {
            this.Agencia = Agencia;
            this.Conta = Conta;
            this.Titular = Titular;
        }

        public bool Deposito (double deposito) {
            if (deposito >= 0) {
                this._Saldo += deposito;
                return true;
            } else {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine ("Você não pode depositar um valor negativo.");
                System.Console.ResetColor ();
                return false;
            }
        }
        public bool Saque (double saque) {
            if (saque <= Saldo && saque > 0) //Não poderá sacar numeros negativos
            {
                this._Saldo -= saque;
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