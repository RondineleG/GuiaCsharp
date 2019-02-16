using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo");
            Apresentacao.ApresentaNaTela("Ola, Mundo");
            Console.WriteLine("Digite o Primeiro numero :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero !");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Calculadora.CalculaSoma(n1, n2);
            Calculadora.CalculaMultiplicacao(n1, n2);
            Calculadora.CalculaSubtracao(n1, n2);
            Calculadora.CalculaDivisao(n1, n2);
            Console.WriteLine("Digite uma idade !");
            double idade = Convert.ToDouble(Console.ReadLine());
            UsandoifElse.IfeElse(idade);
            Console.ReadKey();
        }
    }
}
