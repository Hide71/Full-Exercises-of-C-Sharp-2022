using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;    
            Nascimento = nascimento;
            Nascimento = new DateTime(1990, 12, 1);
        }
   
        public string DataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class ReadOnly
    {
        public static void Executar()
        {
            Cliente cliente1 = new Cliente("José Abreu", new DateTime(1971, 12, 1));
            Console.WriteLine(cliente1.DataDeNascimento());
            Console.WriteLine(cliente1.Nome);


            Cliente cliente2 = new Cliente("João de  Abreu", new DateTime(1970, 12, 25));
            Console.WriteLine(cliente1.DataDeNascimento());
            Console.WriteLine(cliente2.Nome);
        }
    }
}
