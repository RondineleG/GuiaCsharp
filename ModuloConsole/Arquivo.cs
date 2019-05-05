using System;
using System.IO;
namespace ModuloConsole
    {
    public class Arquivo
        {
        public static void CrieArquivo(string texto)
            {
            // Tratamento das \ barras invertidas usando @ no inicio.
            var arquivo = File.CreateText(@"G:\FormacaoDesenvolvedor\ModuloConsole\bin\Debug\texto.txt");
            arquivo.WriteLine(texto);
            arquivo.Close();
            }
        public static void LerArquivo()
            {
            var texto = File.ReadAllText(@"G:\FormacaoDesenvolvedor\ModuloConsole\bin\Debug\texto.txt");
            Console.WriteLine("Conteudo do Texo " + texto);
            }

        public static void DeletaArquivo()
            {
            File.Delete(@"G:\FormacaoDesenvolvedor\ModuloConsole\bin\Debug\texto.txt");

            }
        }
    }
