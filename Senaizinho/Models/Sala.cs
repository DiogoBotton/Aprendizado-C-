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
        public void AlocarAluno(string nome){
            int index = 0;
            
            if(Alunos.Length < capacidadeTotal){
                foreach (string nomes in Alunos)
                {
                    if (nomes == null){
                        this.Alunos[index] = nome;
                    }
                    index++;
                }
                System.Console.WriteLine("O aluno foi cadastrado com sucesso nesta sala.");
                System.Console.ReadLine();
                
            }
            else{
                System.Console.WriteLine("Esta sala esta cheia.");
                System.Console.ReadLine();
                
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