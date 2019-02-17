using System;
namespace CriandoUmaCalculadora
{
    internal class Program
    {
        private static void Main()
        {

            Int32 numero1, numero2, resultado = 0;
            String operacao;
            Console.Title = "Guia Csharp";
            Console.WriteLine("Digite o primeiro numero : ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação : [*, /, - , + ]");
            operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero : ");
            numero2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "+":
                    resultado = numero1 + numero2;
                    break;

                default:
                    Console.WriteLine("Ocorreu um erro inesperado!");
                    break;
            }

            Console.WriteLine(numero1 + " " + operacao + " " + numero1 + " = " + resultado);

            Console.ReadKey();
        }
    }
}
