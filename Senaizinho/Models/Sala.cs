namespace Senaizinho.Models
{
    public class Sala
    {
        public int CapacidadeAtual{get; set;}
        public int capacidadeTotal{get; set;}
        public int numeroSala{get; set;}
        public string[] Alunos{get; set;}

        public Sala(int numeroSala, int capacidadeTotal){
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal; 
            //this.CapacidadeAtual = capacidadeTotal - Alunos.Length; 
        }
        public AlocarAluno(string nome){
            if(Alunos.Length < capacidadeTotal){
                //this.Alunos[] = nome;

            }
            else{
                System.Console.WriteLine("Esta sala esta cheia.");
            }
        }
        /*
        public RemoverAluno(string nome){

        }
        public string MostrarAluno(){
            return ;
        }
        */
    }
}