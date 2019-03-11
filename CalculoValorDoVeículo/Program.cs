using System;

namespace CalculoValorDoVeículo
{
    internal class Program
    {
        private static void Main(String[] args)
        {


            String marca = "";
            String modelo = "";
            Double valorFinal = 0;
            Double valorComissao = 0;
            Double valorImposto = 0;
            Double valorCusto = 0;

            Console.Title = "Guia Csharp";
            Console.WriteLine("Entre com a marca do veículo : ");
            marca = Console.ReadLine();

            Console.WriteLine("Entre com o modelo do veículo : ");
            modelo = Console.ReadLine();

            Console.WriteLine("Entre com o valor do custo do veículo : ");
            valorCusto = double.Parse(Console.ReadLine());

            valorImposto = (valorCusto * 0.45);
            valorComissao = (valorCusto * 0.28);
            valorFinal = valorCusto + valorImposto + valorComissao;


            Console.WriteLine("Resultado Final");
            Console.WriteLine("Marca do veículo : " + marca);
            Console.WriteLine("Modelo do veículo : " + modelo);
            Console.WriteLine("Valor do veículo : " + valorFinal);

            Console.ReadKey();

        }
    }
}
