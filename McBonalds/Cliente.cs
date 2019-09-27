using System;

namespace McBonalds
{
    public class Cliente
    {
        //Propriedades , DECLARAÇÃO DE ATRIBUTOS
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime dataNascimento { get; set; }
        
        //Construtor 
        public Cliente(string Nome, string Telefone, string Email)
        {
            this.Nome = Nome; //Atributo nome recebe(=) o conteudo da string Nome
            this.Email = Email;
            this.Telefone = Telefone;
        }


    }
}