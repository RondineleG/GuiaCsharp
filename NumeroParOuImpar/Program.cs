﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado;
            Console.WriteLine("Digite um numero : ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado % 2 == 0 )
            {
                Console.WriteLine("Numero Par ");
            }
            else
            {
                Console.WriteLine("Numero Impar ");

            }

            Console.ReadKey();
        }
    }
}
