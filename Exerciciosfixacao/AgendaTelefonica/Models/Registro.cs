namespace AgendaTelefonica.Models {
    public class Registro {
        private string _Nome;
        private string _Telefone;
        private string _Aniversario;

        public string Nome { get { return _Nome; } }
        public string Telefone { get { return _Telefone; } }
        public string Aniversario { get { return _Aniversario; } }

        public Registro (string _Nome, string _Telefone, string _Aniversario) {
            this._Nome = _Nome;
            this._Telefone = _Telefone;
            this._Aniversario = _Aniversario;
        }

    }
}