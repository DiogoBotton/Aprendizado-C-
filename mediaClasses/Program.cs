using System;

namespace mediaClasses {
    class Program {
        static void Main (string[] args) {
            string nome = "";
            double[] notas = new double[4];
            double soma = 0;

            Console.WriteLine ("Digite o nome do aluno.");
            nome = Console.ReadLine ();

            for (int n = 0; n < 4; n++) {//Por que com foreach não conta/aumenta os números? n + 1.
                Console.WriteLine ($"Digite a {n + 1}° nota do aluno {nome}.");
                notas[n] = Convert.ToDouble (Console.ReadLine ());

                soma += notas[n];

                if ((notas[n] < 0) || (notas[n] > 10)) {
                    throw new ArgumentOutOfRangeException ("A nota deve ser de 0 à 10.");
                }
            }

            //Instanciando mediaAluno, criando o objeto "aluno1"
            mediaAluno aluno1 = new mediaAluno (nome);
            aluno1.setSoma(soma); //parametro de valor(???)

            Console.WriteLine ("O Aluno " + aluno1.getNome() + " conseguiu a média: " + aluno1.getMedia()); //aluno1.Media e nome estão inacessíveis, pois são declarados privados.
        }
    }
}