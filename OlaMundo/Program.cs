namespace OlaMundo
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome : ");
            var nome = Console.ReadLine();
            var mensagen = "Olá Mundo!";

            Console.WriteLine("Olá , " + nome +" Esse foi seu primeiro "+ mensagen);
            Console.ReadKey();
        }
    }
}
