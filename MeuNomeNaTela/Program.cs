using System;

namespace MeuNomeNaTela
{
    class Program
    {
        static void Main(string[] args)
        {
            string meuNome;     
            Console.Title = "Guia Csharp";            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Qual e o seu nome : ");
            meuNome = Console.ReadLine();
            Console.WriteLine(string.Format("Meu nome é: {0}", meuNome));
            Console.WriteLine("Meu nome é: " + meuNome);
            Console.Write(meuNome);
            Console.ReadKey();


        }
    }
}
