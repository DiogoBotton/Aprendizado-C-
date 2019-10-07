namespace TodoList {

    public class TodoItem {
        public string Titulo; //Nome da tarefa à fazer.
        public string Nota; //informações sobre o todo.
        
        public TodoItem (string Titulo, string Nota){
            this.Titulo = Titulo;
            this.Nota = Nota;
        }

    }
}