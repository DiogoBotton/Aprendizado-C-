using System;

namespace exercicio15
{
    enum MesesEnum : int {
        JANEIRO = 1,
        FEVEREIRO,
        MARÇO,
        ABRIL,
        MAIO,
        JUNHO,
        JULHO,
        AGOSTO,
        SETEMBRO,
        OUTUBRO,
        NOVEMBRO,
        DEZEMBRO
    };
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = Enum.GetNames(typeof(MesesEnum));

            int mes = 0;

            System.Console.Write("Digite o número de um mês: ");
            mes = Convert.ToInt32(Console.ReadLine());
            
            if(mes > 0 && mes <= 12){
                System.Console.WriteLine("Nome do mês: " + meses[mes -1]);
            }
            else{
                System.Console.WriteLine("Esse número não é valido.");
            }

        }
    }
}
