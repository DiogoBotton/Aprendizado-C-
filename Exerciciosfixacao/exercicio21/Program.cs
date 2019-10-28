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
        }
    }
}
