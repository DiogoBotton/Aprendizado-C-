using System;

namespace aprendendoClassesMetodos
{
    public class Aluno
    {//Propriedades
        public string Nome{get;set;}
        public string Curso{get;set;}
        public string Cpf{get;set;}
        public int[] Notas;

        //Construtor
        public Aluno(string Nome, string Curso, string Cpf)
        {
            this.Nome = Nome; //Propriedade é igual à parametro. || Atributo nome recebe(=) o conteudo da string Nome
            this.Curso = Curso;
            this.Cpf = Cpf;
            Notas = new int[4];
        }

        //Métodos de acesso
        public int[] getNotas(){return Notas;}

        public void setNotas(int bi, int nota){
            int i = bi -1;
            if ((i < 0) || (i > 3)){
                //Condição de Erros:
                throw new ArgumentOutOfRangeException ($"{nameof(Notas)} o Número precisa ser de 1 a 4");
            }
            else if ((nota <0) || (nota > 10)){
                throw new ArgumentOutOfRangeException ($"{nameof(Notas)} o Número precisa ser de 0 a 10");
            }
            else {
                this.Notas[i] = nota;
            }
        }
    }
}