using System;
namespace Variaveis
{ 


    class Program
    {       

        static void Main()
        {
            int idade;
            double peso = 68.0;
            float altura = 130.5f;
            string nome;
            char sexo = 'M';
            decimal preco = 1200;
            Console.Title = "Variaveis";
            
            Console.WriteLine("Qual seu nome ?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Idade nao permitida");
                
            }
            else
            {
                Console.WriteLine("Ola " + nome + " com " + idade + " anos ja e um adulto");
            }

            Console.WriteLine("Nome : " + nome + " Idade : " + idade + " Sexo : " + sexo +
                " Peso: " + peso + " Altura: " + altura + " Prec: " + preco);
                Console.ReadKey();
        }
    }
}
