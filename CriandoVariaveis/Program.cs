using System;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto - Criando Variaveis");

            int idade;
            string nome = "Rondinele";
            idade = 27; 
            Console.WriteLine("Ola " + nome + ": Sua idade é " + idade +  "!");
            Console.WriteLine("Execução finalizada. Tecle enter para sair. . . ");
            Console.ReadLine();
        }
    }
}
