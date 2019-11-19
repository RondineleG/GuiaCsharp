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
                    Endereco = "Rua Maria Lobes",
                    Numero = 190,
                    Bairro = "Centro"
                }
            };

            ChamaTipoAnonimo(tipoAnonimo);

            Console.WriteLine(tipoAnonimo.OutroTipoAnonimo.Bairro);           
            
        }
        static void ChamaTipoAnonimo(dynamic parametro)
        {
            Console.WriteLine(parametro.OutroTipoAnonimo.Numero);
        }
    }
}
