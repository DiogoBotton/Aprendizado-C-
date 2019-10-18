namespace ByteBank2.Models {
    public class ContaCorrente : ContaBancaria // Conta corrente herda Conta bancaria, que seria seu modelo.
    {
        public ContaCorrente (int Agencia, int NumeroConta, string Titular) : base (Agencia, NumeroConta, Titular) { //Herda o construtor da classe base (ContaBancaria).

        }
        public override bool Saque (double saque) {
            if (saque >= 0 && saque <= this.Saldo){
                this.Saldo -= saque;
                return true;
            }
            return false;
        }
    }
}