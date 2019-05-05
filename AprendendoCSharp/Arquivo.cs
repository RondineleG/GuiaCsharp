using System;
using System.IO;
namespace AprendendoCSharp
    {   
    public class Arquivo
        {
        public static void CrieArquivo(string texto)
            {
            // Tratamento das \ barras invertidas usando @ no inicio.
            var arquivo = File.CreateText(@"H:\FormacaoDesenvolvedor.Net\AprendendoCSharp\bin\Debug\texto.txt");
            arquivo.WriteLine(texto);
            arquivo.Close();
            }
        public static void LerArquivo()
            {
            var texto = File.ReadAllText(@"H:\FormacaoDesenvolvedor.Net\AprendendoCSharp\bin\Debug\texto.txt");
            Console.WriteLine("Sanvando texto no arquivo " + texto);
            }

        public static void DeletaArquivo()
            {
            File.Delete(@"H:\FormacaoDesenvolvedor.Net\AprendendoCSharp\bin\Debug\texto.txt");

            }
        }
    }
