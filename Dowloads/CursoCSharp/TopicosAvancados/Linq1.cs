using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class Aluno
    {
        internal string Nome;
        internal int Idade;
        internal double Nota;
        //public Aluno(string nome, int idade, double nota)
        //{
        //    Nome = nome;
        //    Idade = idade;
        //    Nota = nota;

        //}
        //public Aluno()
        //{

        //}
    }
    internal class Linq1
    {
        public static void Executar()
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno(){Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno(){Nome = "André", Idade = 21, Nota = 4.3},
                new Aluno(){Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno(){Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno(){Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno(){Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno(){Nome = "Marcio", Idade = 18, Nota = 6.8},
                new Aluno(){Nome = "Pedro", Idade = 23, Nota = 10.0},

            };
            Console.WriteLine("Aprovados");
            Console.WriteLine("------------------");
            var aprovados = alunos.Where(n => n.Nota > 7.0).OrderBy(n => n.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("Chamada");
            Console.WriteLine("------------------------");
            var chamada = alunos.OrderBy(n => n.Nome).Select(n => n.Nome);
            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);

            }
            Console.WriteLine("Aprovados por Idade");
            Console.WriteLine("---------------------");
            var aprovadoIdade =
                from aluno in alunos
                where aluno.Nota > 7.0
                orderby aluno.Idade
                select aluno.Nome;
            foreach(var aluno in aprovadoIdade)
            {
                Console.WriteLine(aluno);
            } 
                
            
            

        }
    }
}
