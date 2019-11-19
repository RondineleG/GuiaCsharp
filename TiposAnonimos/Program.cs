using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipoAnonimo = new
            {
                PrimeiroNome = "Rondinele",
                SegundoNome = "Sousa",
                Idade = 27,
                Vivo = true
            };

            Console.WriteLine(tipoAnonimo.Idade);
        }
    }
}
