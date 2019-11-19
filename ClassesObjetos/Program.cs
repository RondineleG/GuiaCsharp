using System;

namespace ClassesObjetos
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new Conta();
            conta1.numero = 1;
            conta1.titular = "Rondinele";
            conta1.saldo = 99;
            Console.WriteLine("Saldo: " + conta1.saldo);
            var valor =  conta1.Saca(50.0);
            Console.WriteLine("Saque realizad o de: " + valor.ToString());
            Console.WriteLine("Saldo: " + conta1.saldo);

            conta1.Deposita(150.0);
            Console.WriteLine(conta1.titular);
            Console.WriteLine(conta1.saldo);

            var conta2 = new Conta();
            conta2.numero = 1;
            conta2.titular = "Beatriz";
            conta2.saldo = 99;
            Console.WriteLine(conta2.saldo);
            Console.WriteLine("Saldo: " + conta1.saldo);
            conta1.Saca(50.0);
            Console.WriteLine("Saldo: " + conta1.saldo);

            conta2.Deposita(150.0);
            Console.WriteLine(conta2.titular);
            Console.WriteLine("Saldo: " + conta1.saldo);

            conta2.Transfere(50.0, conta1);

            if (conta1.Saca(100.0))
            {
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine("Saldo: " + conta1.saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                Console.WriteLine("Saldo: " + conta1.saldo);
            }
            Console.Read();
        }
    }
}
