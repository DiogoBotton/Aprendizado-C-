using System;

namespace aprendendoClassesMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Diogo","Desenvolvimento de Sistemas","123.456.789-00"); //Chamando o método construtor da classe aluno. (new Aluno() )
            Aluno aluno2 = new Aluno("Alexandre","Prof-DEV","123.456.789-00");

            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("Curso: " + aluno1.Curso);
            Console.WriteLine("CPF: " + aluno1.Cpf);

            Console.WriteLine();

            Console.WriteLine("Nome: " + aluno2.Nome);
            Console.WriteLine("Curso: " + aluno2.Curso);
            Console.WriteLine("CPF: " + aluno2.Cpf);

            //Pedindo ao usuário para digitar
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o curso:");
            string curso = Console.ReadLine();

            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a nota:");
            int nota = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o bimestre:");
            int bimestre = Convert.ToInt32(Console.ReadLine());

            Aluno aluno3 = new Aluno(nome,cpf,curso); //aluno3 pertence à classe Aluno, seu conteudo(parametro) será o que esta dentro de parenteses. 
            aluno3.setNotas(bimestre, nota);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("Curso: " + aluno3.Curso);
            Console.WriteLine("CPF: " + aluno3.Cpf);
            foreach (int n in aluno3.getNotas()){
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
