using System;
namespace ConsoleApp
{
    public class Calculadora
        {
        public static void CalculaSoma(int valor1 , int valor2)
            {
            Console.WriteLine("A Soma e : " +  (valor1 + valor2));
            }
        public static void CalculaMultiplicacao(int valor1 , int valor2)
            {
            Console.WriteLine("A Multiplicação e : " + (valor1 * valor2));
            }
        public static void CalculaDivisao(int valor1 , int valor2)
            {
            Console.WriteLine("A divisão e : " + (valor1 / valor2));
            }
        public static void CalculaSubtracao(int valor1 , int valor2)
            {
            Console.WriteLine("A Subtração  e : " + (valor1 - valor2));
            }
        }
    }
