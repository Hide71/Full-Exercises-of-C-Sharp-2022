using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Comedia, Acao, Aventura, Guerra, Terror };
    public class Filme
    {
        public string NomeDoFilme;
        public Genero GeneroDoFilme;
    }

    internal class ExemploGenero
    {
        public static void Executar()
        {
            Filme filme = new Filme();
            filme.NomeDoFilme = "Hallowen";
            filme.GeneroDoFilme = Genero.Terror;
            Console.WriteLine("O {0} é {1}", filme.NomeDoFilme, filme.GeneroDoFilme);
            int Id = (int)Genero.Aventura;
            Console.WriteLine(Id);
        }
    }
}
