namespace ByteBank {
    class Cliente {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        //Construtor
        public Cliente (string Nome, string Cpf, string Email) {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;

        }

        //Método de acesso
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