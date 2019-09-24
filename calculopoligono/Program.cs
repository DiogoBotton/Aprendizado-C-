using System;

namespace calculopoligono
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;

            while (escolha != "0")
            {

                Console.WriteLine("Selecione o que deseja:");
                Console.WriteLine("1. Opção: Digite quadrado para calculo da área do QUADRADO.");
                Console.WriteLine("2. Opção: Digite triangulo para calculo da área do TRIÂNGULO.");
                Console.WriteLine("3. Opção: Digite circulo para calculo da área do CÍRCULO.");
                Console.WriteLine("4. Opção: Digite trapezio para calculo da área do TRAPÉZIO.");
                Console.WriteLine("5. Opção: Digite retangulo para calculo da área do RETÂNGULO.");
                Console.WriteLine("6. Opção: Digite losango para calculo da área do LOSANGO.");
                escolha = Console.ReadLine();

                    switch (escolha)
                    {
                        case "quadrado":

                            double areaquadrado = 0;

                            Console.Write("Digite o lado do quadrado:");
                            lado1 = Convert.ToDouble(Console.ReadLine());

                            areaquadrado = lado1 * lado1;

                            Console.WriteLine($"A área do quadrado é: " + areaquadrado);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");
                            break;

                        case "losango":

                           

                            double arealosango = 0;

                            Console.Write("Digite o lado da diagonal maior:");
                            lado1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o lado da diagonal menor:");
                            lado2 = Convert.ToDouble(Console.ReadLine());
                            

                            arealosango = (lado1 * lado2) / 2;

                            Console.WriteLine($"A área do losango é: " + arealosango);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");

                            break;

                        case "circulo": //2pi r quadrado

                         
                            double circulo = 0;

                            Console.Write("Digite o raio:");
                            lado1 = Convert.ToDouble(Console.ReadLine());

                            circulo = (2 * 3.14) * (lado1 * lado1); //pi raio ao quadrado

                            Console.WriteLine($"A área do círculo é: " + circulo);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");
                            break;

                        case "trapezio":

                            double trapezio = 0;

                            Console.Write("Digite o lado da base maior:");
                            lado1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o lado da base menor:");
                            lado2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite a altura:");
                            lado3= Convert.ToDouble(Console.ReadLine());

                            trapezio = (((lado1 * lado2) * lado3) / 2);

                            Console.WriteLine($"A área do trapezio é: " + trapezio);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");
                            break;

                        case "retangulo":

                            double retangulo = 0;

                            Console.Write("Digite o lado 1 do retângulo:");
                            lado1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o lado 2 do retângulo:");
                            lado2 = Convert.ToDouble(Console.ReadLine());

                            retangulo = lado1 * lado2;

                            Console.WriteLine($"A área do retângulo é: " + retangulo);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");
                            break;

                        case "triangulo":

                            double triangulo = 0;

                            Console.Write("Digite a base:");
                            lado1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite a altura:");
                            lado2 = Convert.ToDouble(Console.ReadLine());

                            triangulo = (lado1 * lado2) / 2;

                            Console.WriteLine($"A área do triângulo é: " + triangulo);
                            Console.WriteLine("OU digite 0 para VOLTAR ao menu.");
                            break;

                        case "bhaskara":


                        break;



                    }
                
            }



        }
    }
}
