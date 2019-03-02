using System;

namespace CaixaRetangular
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double volume, comprimento, largura, altura;
            Console.Title = "Guia Csharp";
            Console.WriteLine("Digite o comprimento da caixa em metros : ");

            comprimento = double.Parse(Console.ReadLine());

           Console.WriteLine("Digite largura da caixa em metros: ");

            largura = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite a altura da caixa em metros: ");

            altura = double.Parse(Console.ReadLine());
            
            volume = comprimento * largura * altura;           

            Console.WriteLine("Uma caixa retangular com {0} metros de comprimento, {1}" +
                " metros de largura e {2} metros de altura é de : \n{3} metros cúbicos",
                comprimento, largura, altura, volume);

            Console.ReadLine();
        } 

    }  

}