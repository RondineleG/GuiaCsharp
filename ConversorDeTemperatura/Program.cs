using System;

namespace ConversorDeTemperatura
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            {
                // Variaveis
                Double f, c;

                while (true)
                {
                    // Titulo do console
                    Console.Title = "Guia Csharp - Conversor De Temperatura ";
                  
                    Console.WriteLine(" Digite 0 para converter de Fakrenkeit para Celcius . ");
                    Console.WriteLine(" Digite 1 para converter de Celcius para Fakrenkeit . ");
                    Int32 temperatura = int.Parse(Console.ReadLine());

                    if (temperatura == 0)
                    {
                        Console.WriteLine("Digite a temperatura em Fakrenkeit :");

                        f = double.Parse(Console.ReadLine());

                        c = ((f - 32) * 5 / 9);

                        Console.WriteLine("A temperatura de {0} graus Fakrenkeit equivale a {1} graus celcius :", f, c);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Pressione qualquer tecla para continuar!!!");

                    }
                    else if (temperatura == 1)
                    {
                        Console.WriteLine("Digite a temperatura em Celcius :");

                        c = double.Parse(Console.ReadLine());

                        f = ((c * 1.8) + 32);

                        Console.WriteLine("A temperatura de {0} graus Celcius equivale a {1} graus Farenheit :", c, f);
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Pressione qualquer tecla para continuar!!!");

                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Digite somente 0 ou 1 ");
                        Console.WriteLine("Pressione qualquer tecla para continuar!!!");
                    }
                    Console.ReadKey();
                }

            }

        }
    }
}
