using System;
namespace AprendendoArrays
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Arrays";
            // criando array usando var
            var novoArray = new int[2];
            novoArray[0] = 10;
            novoArray[1] = 2;
            //Criando Array e definindo valores
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Lendo  valor de array na posicao 4
            Console.WriteLine(array[4]);
            //Criando Array e definindo seu tamanho
            int[] array2 = new int[10];
            //Definino valor para uma posicao do array
            array2[0] = 50;
            //Lendo  valor de array na posicao 0
            Console.WriteLine(array2[0]);
            Console.WriteLine(novoArray[1]);

            Console.ReadKey();
        }
    }
}
