using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultaAnonimoLINQ
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IList<Aluno> listaAlunos = new List<Aluno>() {
                        new Aluno() { AlunoId = 1, Nome = "John", Idade = 18 } ,
                        new Aluno() { AlunoId = 2, Nome = "Steve",  Idade = 21 } ,
                        new Aluno() { AlunoId = 3, Nome = "Bill",  Idade = 18 } ,
                        new Aluno() { AlunoId = 4, Nome = "Ram" , Idade = 20  } ,
                        new Aluno() { AlunoId = 5, Nome = "Ron" , Idade = 21 }
                    };

            var nomes = from query in listaAlunos
                        select new
                        {
                            AlunoId = query.AlunoId,
                            Nome = query.Nome
                        };

            Console.ReadKey();
        }
    }
}