
namespace BaseRavenDB
{
    using Raven.Client.Documents;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var documentStore = new DocumentStore
            {
                Urls = new[] { "http://localhost:8080" },
                Database = "AgendaRaven"
            };
             documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                var cliente = new Cliente
                {
                    Nome = "Gabriela",
                    DataDeNascimento = Convert.ToDateTime("12/07/1992")
                };
                session.Store(cliente);
                session.SaveChanges();
            }

             Console.WriteLine("Operação concluída");
            Console.ReadKey();
        }


    }
}