using System;
namespace AprendendoCSharp
{
    public class UsandoIfElse
    {
        /*
         Idades:
         00-02 = Bebe
         03-09 = Criança
         10-17 = Adolescente
         18-59 = Adulto
         60 = Idoso
        */

        // If = Se  -   Else = senão

        // if(Verdadeiro ou Falso)


        public static void UsandoIfeElse(int idade)
        {

            if (idade <= 2)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um bebe");
                if (idade == 1)
                {
                    Console.WriteLine("E um bebe com " + idade + " ano");
                }
            }
            else
                Console.WriteLine("Com esta idade : " + idade + " ano" + " não e um bebe");

            // && = e
            if (idade >= 3 && idade <= 9)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e uma criança");
                if (idade >= 6)
                    Console.WriteLine("A criança comecou a estudar");
            }
            else
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " não e uma crianca");
            }
            // || = ou
            if (idade >= 60 || idade <= 60)
            {
                Console.WriteLine("Com esta idade : " + idade + " ano" + " e um idoso");

            }
        }
    }
}
    