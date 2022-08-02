using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoas
    {
        public string Nome;
        public int Idade;
        public string Apresentacao()
        {
            return string.Format($"Muito prazer! Me chamo {Nome} tenho {Idade} anos de idade.");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentacao());
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
