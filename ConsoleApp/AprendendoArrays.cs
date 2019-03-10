using System;

namespace ConsoleApp
{
    internal class AprendendoArrays
    {
        public static void UsandoArrays()
        {
            // Arrays de inteiros
            int[] arrayInteiro = new int[] { 1, 2, 3, 4, 50 };
            Console.WriteLine(arrayInteiro[4]);

            int[] segundoArray = new int[10];
            segundoArray[0] = 50;
            segundoArray[1] = 20;
            segundoArray[2] = 30;
            segundoArray[3] = 40;
            segundoArray[4] = 60;
            segundoArray[5] = 70;
            segundoArray[6] = 80;
            segundoArray[7] = 90;
            segundoArray[8] = 10;
            segundoArray[9] = 00;
            Console.WriteLine("O Segundo Array e " + segundoArray[5]);
            Console.ReadLine();
        }
    }
}
