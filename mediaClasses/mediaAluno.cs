namespace mediaClasses {
    public class mediaAluno {
        //atributos
        private string Nome{get; set;}
        private double Media{get; set;}

        //construtor
        public mediaAluno(string Nome){
            this.Nome = Nome;
            
        }

        //Métodos de acesso

        //Não entendi: diferença get e set

        public void setSoma(double soma){ //parametro de valor(??)
            double media;

            media = soma / 4;

            this.Media = media;
        }
        public double getMedia(){
            return Media;
        }
        public string getNome(){
            return Nome;
        }
        


    }
}