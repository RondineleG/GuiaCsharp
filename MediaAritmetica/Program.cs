using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numeros impares
            int a = 1;
            int b = 3;
            int c = 5;
            int d = 7;
            int e = 9;

            //  Numeros pares
            int f = 2;
            int g = 4;
            int h = 6;
            int i = 8;

            double resultadoImpar = (a + b + c + d + e) / 5;
            double resultadoPar = (f + g + h + i) / 4;
            if (resultadoImpar == resultadoPar)
            {
                Console.WriteLine("A media dos numeros Pares e Impares de 1 a 9 são Iguais !!!!");
                
            }
            Console.WriteLine("A média dos numero impar  e : "  + resultadoImpar);
            Console.WriteLine("A média dos numero Par  e : " + resultadoPar);
          
            Console.ReadKey();

        }
    }
}
