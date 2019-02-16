using System;

namespace ConsoleApp
{
    internal class AprendendoArrays
    {
        public static void UsandoArrays()
        {
            // Arrays de inteiros
            Int32[] array = new Int32[] { 1, 2, 3, 4, 50 };
            Console.WriteLine(array[4]);

            Int32[] array2 = new Int32[10];
            array2[0] = 50;
            array2[1] = 20;
            array2[2] = 30;
            array2[3] = 40;
            array2[4] = 60;
            array2[5] = 70;
            array2[6] = 80;
            array2[7] = 90;
            array2[8] = 10;
            array2[9] = 00;
            Console.WriteLine("Array2 e " + array2[5]);
            Console.ReadLine();
        }
    }
}
