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
                Vivo = true,

                OutroTipoAnonimo = new
                { 
                    Enderecp ="Rua Maria Lobes",
                    Numero = 190,
                    Bairro = "Centro"
                }

            };

            Console.WriteLine(tipoAnonimo.OutroTipoAnonimo.Bairro);
        }
    }
}
