namespace ByteBank2.Models {
    public abstract class ContaBancaria //Classe base.
    {
        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria (int Agencia, int NumeroConta, string Titular) {
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            this.Saldo = 0;
        }

        public abstract bool Saque (double saque); //saque abstract pois terá comportamentos diferentes em outras classes, e por isso, deverá ser preciso criar metodos saques diferentes nas classes.
        public bool Deposito (double deposito) {
            if (deposito >= 0) {
                this.Saldo += deposito;
                return true;
            }
            return false;//Pode vir sem else pois o return encerra o método.
        }
        public bool Transferencia (ContaBancaria contaDestino, double transferencia) {
            if (this.Saque (transferencia)) {
                contaDestino.Deposito(transferencia);
                return true;
            }
            else{
                return false;
            }
        }
    }
}