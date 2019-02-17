using System;

namespace CalculoIMC
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            double peso = 0, altura = 0, valorIMC = 0;
            Console.Title = "Guia Csharp";
            Console.WriteLine("Digite o valor da massa corporal em Kg :");

            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura em Metros utilizando Virgula !!: ");

            altura = Convert.ToDouble(Console.ReadLine());

            var calculaIMC = new CalculaIMC();

            valorIMC = calculaIMC.Calcular(peso, altura);

            Console.WriteLine("Resultado do IMC é : " + valorIMC);

            Console.WriteLine("Classificação : " + calculaIMC.ClassificarIMC(valorIMC));

            Console.ReadLine();

        }

    }

}