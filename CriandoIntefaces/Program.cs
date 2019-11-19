using System;

namespace CriandoIntefaces
{
    interface ICaneta
    {
        string Colorir { get; set; }
        bool Aberta();
        bool Feichada();
        void Escreve(string text);
    }

    class Diario : ICaneta
    {
        public string Colorir { get; set; }

        private bool estaAberto = false;

        public bool Feichada()
        {
            estaAberto = false;
            Console.WriteLine("Diario feichado para escrita");

            return estaAberto;
        }

        public bool Aberta()
        {
            estaAberto = true;
            Console.WriteLine("Diario aberto pra escrita");

            return estaAberto;
        }

        public void Escreve(string texto)
        {
            if (estaAberto)
                Console.WriteLine("Diario: " + texto);
        }
    }
    public class Program
    {
        public static void Main()
        {
            ICaneta caneta = new Diario();
            caneta.Aberta();
            caneta.Escreve("Minha Escrita");
            caneta.Feichada();
        }
    }

}