using System;

namespace CalculosGeometricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guia Csharp";

            // calculo do quadrado
            /*
            Console.WriteLine("Qual valor tem o lado do Quadrado ?");
            double lado = Convert.ToDouble(Console.ReadLine());
            CalculoQuadrado.CalculaAreaQuadrado(lado);
            */
            
           Console.WriteLine("Qual valor tem o Comprimento do Retangulo ?");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual valor tem o Altura do do Retangulo ?");
            double altura = Convert.ToDouble(Console.ReadLine());
            CalculoRetangulo.CalculaAreaRetangulo(comprimento, altura);
            Console.ReadKey();

        }
    }
}
