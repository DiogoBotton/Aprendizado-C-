using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList {
    class Program {
        static void Main (string[] args) {
            List<TodoItem> todoList = new List<TodoItem> (); //Criando Lista que receberá APENAS conteúdo da classe TodoItem.
            string fileName = "todo.csv";
            string FilePath = ".\\" + fileName; //A primeira contra barra indica que o próximo caractere será apenas TEXTO.

            try {
                string[] todoFile = File.ReadAllLines (FilePath); //Passando o caminho do arquivo que irá ser lido nos paramêtros de ReadAllLines.
                foreach (string line in todoFile) {
                    string[] itens = line.Split (","); //Quando lê uma virgula, separa a linha.
                    string titulo = itens[0].Replace ("\"", ""); //O que você quer substituir, por o que você quer substituir. Se achar aspas duplas, vai substituí-la pela instrução após virgula.
                    string nota = itens[1].Replace ("\"", "");

                    TodoItem todoItem = new TodoItem (titulo, nota);
                    todoList.Add (todoItem); //Armazena o conteúdo de todoItem(classe) na lista todoList.
                }
            } catch (IOException erro) {
                System.Console.WriteLine ("Erro ao acessar arquivo.");
                System.Console.WriteLine (erro.Message);
            }
            int opcao = 0;

            do {
                Console.Clear ();
                System.Console.WriteLine ("Todo List");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite uma opção:");
                System.Console.WriteLine ("1- Adicionar Item.");
                System.Console.WriteLine ("2- Remover Item.");
                System.Console.WriteLine ("3- Sair do Programa.");
                System.Console.Write ("Opção: ");
                opcao = Convert.ToInt32 (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        AddItem (todoList);
                        break;
                    case 2:
                        RemoveItem (todoList);
                        break;
                    case 3:
                        System.Console.WriteLine ("Finalizando programa");
                        //TODO Encontrar método para salvar o arquivo após o programa ser finalizado.
                        try {
                            StreamWriter writer = new StreamWriter ("todo.csv");
                            //string[] todo;
                            foreach (TodoItem item in todoList) {
                                string todo = "\"" + item.Titulo + "\"" + "," + "\"" + item.Nota + "\"";
                                
                                writer.WriteLine (todo);
                            }
                            writer.Close();
                        } catch (IOException erro) {
                            System.Console.WriteLine ("Erro ao acessar arquivo.");
                            System.Console.WriteLine (erro.Message);
                        }
                        /*
                        File.WriteAllLines(FilePath, todoList.ToString()); //*falho*
                        try catch, foreach.
                        */
                        //TODO 
                        break;
                    default:
                        System.Console.WriteLine ("Opção inválida.");
                        Console.ReadLine ();
                        break;
                }

            } while (opcao != 3);

        }
        //Método de listagem de itens
        public static void ListaItens (List<TodoItem> todoList) {
            Console.Clear ();
            int count = 1;
            System.Console.WriteLine ("Todo List");
            System.Console.WriteLine ();
            System.Console.WriteLine ($"ID{"",2} Titulo {"", 12} Notas");
            foreach (TodoItem item in todoList) {
                System.Console.WriteLine ($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }
        //Adicionar item à lista
        public static void AddItem (List<TodoItem> todoList) {
            Console.Clear ();
            System.Console.WriteLine ("Novo Item:");
            System.Console.WriteLine ();
            System.Console.Write ("Título: ");
            string titulo = Console.ReadLine ();
            System.Console.WriteLine ("Nota: ");
            string nota = Console.ReadLine ();

            TodoItem item = new TodoItem (titulo, nota);

            todoList.Add (item);

        }

        //Remover item da lista
        public static void RemoveItem (List<TodoItem> todoList) {
            int index = 0;
            do {
                Console.Clear ();
                System.Console.WriteLine ("Remover item");
                System.Console.WriteLine ();
                ListaItens (todoList);
                System.Console.WriteLine ();
                System.Console.WriteLine ("Digite o ID ou x para terminar.");
                System.Console.WriteLine ();
                System.Console.Write ("ID: ");
                string id = Console.ReadLine ();

                if (id.ToLower () == "x") {
                    break; //Quebra o ciclo (loop infinito)
                } else {
                    index = Convert.ToInt32 (id) - 1;
                }
                if ((index < 0) || (index > todoList.Count - 1)) { //Count funciona como o Lenght. Listas usam apenas Count.
                    System.Console.WriteLine ("Id Inválido");
                    System.Console.WriteLine ("Pressione <enter> para continuar");
                    Console.ReadLine ();
                } else {
                    todoList.RemoveAt (index);
                }

            } while (true);
        }
    }
}