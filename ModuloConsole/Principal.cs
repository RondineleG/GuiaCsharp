using System;
namespace ModuloConsole
    {
    class Principal
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Olá Mundo");
            Apresentacao.ApresentaNaTela("Ola");
            Apresentacao.ApresentaNaTela("Mundo");
            Arquivo.CrieArquivo("Salvando Dados No Texto");
            Arquivo.LerArquivo();
            Arquivo.DeletaArquivo();           
            Calculadora.CalculaSoma(10 , 20);
            Calculadora.CalculaMultiplicacao(5 , 6);
            Calculadora.CalculaSubtracao(100 , 50);
            Calculadora.CalculaDivisao(800 , 10);
            UsandoifElse.UsandoIfeElse(60);
            Console.ReadKey();
            }
         
        }
    }