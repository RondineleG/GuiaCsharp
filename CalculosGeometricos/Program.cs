using System;

namespace CalculosGeometricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guia Csharp";
            Console.WriteLine("Qual valor tem o lado do Quadrado ?");
            int lado = Convert.ToInt32(Console.ReadLine());
            CalculoQuadrado.CalculaAreaQuadrado(lado);
            Console.ReadKey();

        }
    }
}
