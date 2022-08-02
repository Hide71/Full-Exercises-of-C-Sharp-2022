using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<string, string>();
            filmes.Add("A", "Homem Aranha");
            filmes.Add("B", "Gladiador");
            filmes.Add("C", "Os Vingadores");
            filmes.Add("D", "Brasileirinhas");
            if (filmes.ContainsKey("A"))
            {
                Console.WriteLine("A: {0}", filmes["A"]);
                 Console.WriteLine(filmes.GetValueOrDefault("A"));
            }
            Console.WriteLine(filmes.ContainsValue("Amnesia"));
            Console.WriteLine("Removeu? {0}", filmes.Remove("D"));
            filmes.TryGetValue("C", out string filmeNovo);
            Console.WriteLine(filmeNovo);
            foreach(string key in filmes.Keys)
            {
                Console.WriteLine(key);
            }
            foreach(string valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            foreach(KeyValuePair<string, string> filme in filmes)
            {
                Console.WriteLine(filme);
            }
            foreach(var filme in filmes)
            {
                Console.WriteLine(filme);
            }
        }
    }
}
