using System;

namespace KahootExercicio {
    class Program {
        static void Main (string[] args) {
            int[, ] matrix = { { 10, 15, 48 }, { 56, 97, 77 }, { 2, 100, 33 } };
            int valor = 0;
            foreach (int item in matrix) {
                valor += item;
            }
            System.Console.WriteLine (valor);
        }
    }
}