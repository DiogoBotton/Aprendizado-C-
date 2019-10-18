namespace ByteBank2.Models
{
    public class ContaEspecial : ContaBancaria // Conta Especial herda Conta bancaria, que seria seu modelo.
    {
        public double Limite; //LIMITE que o usuário pode sacar ALÉM DE SEU SALDO.

        public ContaEspecial(int Agencia, int NumeroConta, string Titular) : base(Agencia, NumeroConta, Titular){
            this.Limite = 0;
        }

        public bool SetLimite(double Limite){
            if(Limite >= 0){
                this.Limite = Limite;
                return true;
            }
            return false;
        }

        public override bool Saque (double saque) {
            if (saque >= 0 && saque <= this.Saldo + this.Limite){
                this.Saldo -= saque;
                return true;
            }
            return false;
        }
    }
}