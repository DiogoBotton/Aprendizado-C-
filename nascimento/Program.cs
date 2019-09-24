using System;

namespace nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = -1;
            int idade = 0;
            

                do                      //Validação de entrada.
                {

                    Console.WriteLine("Instrução: Qual sua data de nascimento (digite apenas o ano).");
                    ano = Convert.ToInt32(Console.ReadLine());
                    if ((ano < 1919) || (ano > 2019)){
                        Console.WriteLine("Data inválida, digite um ano de 1919 à 2019.");
                    }
                }while ((ano < 1919) || (ano > 2019));

                    idade = 2019 - ano;

                    if ((idade >= 0) && (idade <= 2))
                    {
                        Console.WriteLine($"Sua idade é: {idade} e você pertence a faixa etária de Recém-Nascidos.");
                    }
                    else if ((idade >= 3) && (idade <= 11))
                    {
                        Console.WriteLine($"Sua idade é: {idade} e você pertence a faixa etária de Crianças.");
                    }
                    else if ((idade >= 12) && (idade <= 19))
                    {
                        Console.WriteLine($"Sua idade é: {idade} e você pertence a faixa etária de Adolescentes.");
                    }
                    else if ((idade >= 20) && (idade <= 65))
                    {
                        Console.WriteLine($"Sua idade é: {idade} e você pertence a faixa etária de Adulto.");
                    }
                    else if ((idade > 65))
                    {
                        Console.WriteLine($"Sua idade é: {idade} e você pertence a faixa etária de Idosos.");
                    }

                
            



        }
    }
}
