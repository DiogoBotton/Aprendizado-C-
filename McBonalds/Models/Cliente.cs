using System;

namespace McBonalds.Models
{
    public class Cliente
    {
        //Propriedades , DECLARAÇÃO DE ATRIBUTOS
        private string _Nome; 
        public string Endereco;
        private int Cpf;
        public int Telefone;
        private string _Senha;
        private string Email;
        public DateTime dataNascimento;
        private double _Carteira;
        
        public double Carteira{
            get {return _Carteira;}
        }
        public string Nome{
            get{return _Nome;}
        }
        public string Senha{
            get{return _Senha;}
        }
        
        //Construtor 
        public Cliente(string Nome, int Telefone, string Email, int Cpf)
        {
            this._Nome = Nome; //Atributo nome recebe(=) o conteudo da string Nome
            this.Email = Email;
            this.Telefone = Telefone;
            this.Cpf = Cpf;
            this._Carteira = 0;
        }
        //Sobrecarga do metodo cliente para ADMIN
        public Cliente(string Nome, string Senha){
            this._Nome = Nome;
            this._Senha = Senha;
        }

        public bool AdcSaldoCarteira(double valor){
            if(valor > 0){
                this._Carteira += valor;
                return true;
            }
            else{
                return false;
            }
        }
        public bool TrocarSenha(string senha){
            if(senha.Length >= 6 && senha.Length <= 16 ){
                this._Senha = senha;
                return true;
            }
            return false;
        }

        public bool ComprarProduto(double preco){
            if(this._Carteira >= preco){
                this._Carteira -= preco;
                return true;
            }
            return false;
        }


    }
}