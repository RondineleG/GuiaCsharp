using System;
namespace ConsoleApp
    {
    public class UsandoifElse
        {
        
      
        public static void IfeElse(double idade)
        {
            if (idade >0 && idade <= 2)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um bebe");
            }
            else if (idade > 2 && idade <= 12)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e uma criança");
                if (idade >= 4 || idade <=6)
                {
                    Console.WriteLine("A criança comecou o presinho");
                }
                else if (idade > 6 || idade <= 10)
                {
                    Console.WriteLine("A criança comecou o ensino fundamental");
                }
                else
                {
                    Console.WriteLine("A criança comecou o ensino medio");
                }
            }
            else if (idade >= 13 && idade <= 19)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um adolescente");
            }
            else if (idade > 19 && idade <= 59)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um adulto");
            }
            else if (idade >= 60 && idade <=99)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um idoso");
            }
            else
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " centenario !!!!");
            }

        }



        }
    }