using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Apresentar(params string[] alunos)
        {
            foreach(string aluno in alunos)
            {
                Console.WriteLine($"Olá {aluno}!");
            }
        }
        public static void Executar()
        {
            Apresentar("João", "Carlos", "Antônio", "Fernanda", "Lavínia");
        }
    }
}
