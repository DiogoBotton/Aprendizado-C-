using System;

namespace loopInfinito
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTAGEM infinita com while -- tecnica para invasões (by alexandre)
            int num = 0;
            while (true){

                if (num == 10001) //Limitador de iteração para não travar a aplicação.
                    break;
                Console.WriteLine(num);
                num++;
            }
            
            //Contagem utilizando WHILE e Continue
            while (num < 10){

                num++;
                if ((num % 2) == 0) //Apenas números ímpares (interrompe as repetições com números pares).
                    continue;

                Console.WriteLine(num);
            }

            //Continue e Break
            while (true){
                Console.WriteLine("Digite um número de 0 a 10. Digite 5 para sair do programa.");
                num = Convert.ToInt32(Console.ReadLine());

                if ((num < 0) || (num > 10)) //Se num for menor que 0 ou maior que 10, execute novamente a instrução while.
                    continue;
                else{                        //Caso contrário, imprima o número na tela.
                    if (num == 5){           //Caso num for igual à 5, encerre o programa.
                        break;
                    }
                    Console.WriteLine($"O número é {num}");
                }
                
                    
                
            }

            //Contagem utilizando DO / WHILE
            do {
                Console.WriteLine(num);
                num++;
            }while(num <= 50);
            
            //Contagem utilizando FOR.
            for (int i = 0; i < 10; i++){
                Console.WriteLine(i);
            }

            //Tabuada do 5 com WHILE.
            while (num <= 10){
                Console.WriteLine($"5 * {num} = {num * 5}");
                num++;
            }

            //Tabuada do 5 com FOR.
            for (int i = 0; i <= 10; i++){
                Console.WriteLine($"5 * {i} = {i * 5}");
            }

            //FOR infinito
            for (int i = 0; i < 1; i--){
                if (i == -10001)
                    break;
                Console.WriteLine(i);
            }
        }
    }
}
