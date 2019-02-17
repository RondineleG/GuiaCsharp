using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guia Csharp";
            Console.WriteLine("Olá Mundo");
            Apresentacao.ApresentaNaTela("Ola, Mundo");
            Console.WriteLine("Digite o Primeiro numero :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero !");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Calculadora.CalculaSoma(n1, n2);
            Calculadora.CalculaMultiplicacao(n1, n2);
            Calculadora.CalculaSubtracao(n1, n2);
            Calculadora.CalculaDivisao(n1, n2);
            Console.WriteLine("Digite uma idade !");
            double idade = Convert.ToDouble(Console.ReadLine());
            UsandoifElse.IfeElse(idade);
            Console.ReadKey();

            // Arrays de strings
            string[] meses;
            meses = new string[12];
            meses[0] = "Janeiro";
            meses[1] = "Fevereiro";
            meses[2] = "Março";
            meses[3] = "Abril";
            meses[4] = "Maio";
            meses[5] = "Junho";
            meses[6] = "Julho";
            meses[7] = "Agosto";
            meses[8] = "Setembro";
            meses[9] = "Outubro";
            meses[10] = "Novembro";
            meses[11] = "Desembro";
            string mesNascimento = meses[6];
            Console.WriteLine(" Meu aniversario e no mes de " + mesNascimento);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
