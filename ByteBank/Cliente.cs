namespace ByteBank {
    class Cliente {
        private string _Nome;
        private string _Cpf; //* erro de stackoverflow { get {return Cpf;} set { Cpf = value;} }
        private string _Email;
        private string Senha;
        /* 
            *SET EQUIVALE À UM METODO
                public void set(string value){
                this._Email = value;
            }
        */
        //Dois jeitos para alterar os métodos de acesso.
        
        //Método de acesso
        public string Nome{
            get {return _Nome;}
            set {_Nome = value;}
        }
        public string Cpf { get {return _Cpf;} set {_Cpf = value;} }
        public string Email { get{return _Email;} set {_Email = value;} }
        
        //Construtor
        public Cliente (string Nome, string Cpf, string Email) {
            this._Nome = Nome;
            this._Cpf = Cpf;
            this._Email = Email;

        }

        public bool TrocaSenha (string Senha) {
            if ((Senha.Length > 6) && (Senha.Length < 16)) {
                this.Senha = Senha;
                return true;
            } else {
                return false;
            }
        }
    }
}
