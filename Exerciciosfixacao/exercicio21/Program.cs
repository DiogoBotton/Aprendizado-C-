using System;

namespace exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com o valor que deseja sacar: ");
            uint valor = Convert.ToUInt32(Console.ReadLine());

            CalcularQtdNotas(valor);
        }
        public static void CalcularQtdNotas(uint valor){
            uint somaValor = valor;
            int count100 = 0;
            int count50 = 0;
            int count20 = 0;
            int count10 = 0;
            int count5 = 0;
            int count2 = 0;
            int countMoeda1 = 0;
            do{
                if(somaValor >= 100){
                    somaValor -= 100;
                    count100++;
                }
                else if(somaValor >= 50 && somaValor < 100){
                    somaValor -= 50;
                    count50++;
                }
                else if(somaValor >= 20 && somaValor < 50){
                    somaValor -= 20;
                    count20++;
                }
                else if(somaValor >= 10 && somaValor < 20){
                    somaValor -= 10;
                    count10++;
                }
                else if(somaValor >= 5 && somaValor < 10){
                    somaValor -= 5;
                    count5++;
                }
                else if (somaValor >= 2 && somaValor < 5){
                    somaValor -= 2;
                    count2++;
                }
                else if(somaValor >= 1 && somaValor < 2){
                    somaValor -= 1;
                    countMoeda1++;
                }
                
            }while(somaValor != 0);

            System.Console.WriteLine("|_____Seu dinheiro_____|");
            System.Console.WriteLine($"{count100} notas de 100;");
            System.Console.WriteLine($"{count50} notas de 50;");
            System.Console.WriteLine($"{count20} notas de 20;");
            System.Console.WriteLine($"{count10} notas de 10;");
            System.Console.WriteLine($"{count5} notas de 5;");
            System.Console.WriteLine($"{count2} notas de 2;");
            System.Console.WriteLine($"{countMoeda1} moedas de 1;");
            System.Console.WriteLine("|______________________|");
        }
    }
}
