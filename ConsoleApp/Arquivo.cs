using System;
using System.IO;
namespace ConsoleApp
    {
    public class Arquivo
        {
        public static void CrieArquivo(string texto)
            {
            // Tratamento das \ barras invertidas usando @ no inicio.
            //Mudar caminho para funcionar
            var arquivo = File.CreateText(@"C:\VS-Projects\GuiaCsharp\ConsoleApp\bin\Debug\texto.txt");
            arquivo.WriteLine(texto);
            arquivo.Close();
            }
        public static void LerArquivo()
            {
                //Mudar caminho para funcionar
            var texto = File.ReadAllText(@"C:\VS-Projects\GuiaCsharp\ConsoleApp\bin\Debug\texto.txt");
            Console.WriteLine("Conteudo do Texo " + texto);
            }

        public static void DeletaArquivo()
            {
                //Mudar caminho para funcionar
            File.Delete(@"C:\VS-Projects\GuiaCsharp\ConsoleApp\bin\Debug\texto.txt");

            }
        }
    }
