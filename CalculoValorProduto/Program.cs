using System;
namespace CalculoValorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
              
            string nomeProduto = "";      
            int quantidade = 0;    
            double preco = 0;
            double percentualDesconto = 0;
            double totalDesconto = 0;
            double totalBruto = 0;
            
            Console.Write("Entre com o nome do Produto : ");     
            nomeProduto = Console.ReadLine();                           

            Console.Write("Entre com a quantidade : ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Entre com preço do produto : ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de desconto : ");
            percentualDesconto = double.Parse(Console.ReadLine());

            totalBruto = quantidade * preco;             
            totalDesconto = totalBruto - ((percentualDesconto / 100) * totalBruto);
            Console.Write("Total com desconto : " + totalDesconto);
            Console.ReadKey();  
        }
    }
}
