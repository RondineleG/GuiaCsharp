using System;
namespace Variaveis
{ 


    class Program
    {       

        static void Main()
        {
            int idade;
            double peso;
            float altura;
            string nome;
            char sexo;
            decimal preco;
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
                Console.WriteLine("Ola " + nome + "com " + idade + " anos ja e um adulto");
            }
                Console.ReadKey();
        }
    }
}
