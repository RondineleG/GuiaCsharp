  using System;
  namespace AprendendoCSharp  

  {
      class ClassePrincipal ///  a class que contem o metodo main
        {
        static void Main()
            {
            Console.WriteLine("Olá Mundo");
            Apresentacao.ApresentaNaTela("Ola");
            Apresentacao.ApresentaNaTela("Mundo");
            Arquivo.CrieArquivo("Este texto será salvo no arquivo");
            Arquivo.LerArquivo();
            Arquivo.DeletaArquivo();           
            Calculadora.CalculaSoma(10 , 20);
            Calculadora.CalculaMultiplicacao(5 , 6);
            Calculadora.CalculaSubtracao(100 , 50);
            Calculadora.CalculaDivisao(800 , 10);
            UsandoIfElse.UsandoIfeElse(60);
            Console.ReadKey();
            }
         
        }
    }