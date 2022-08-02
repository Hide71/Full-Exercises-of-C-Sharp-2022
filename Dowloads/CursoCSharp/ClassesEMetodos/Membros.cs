using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoas sicrano = new Pessoas();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;
            Pessoas fulano = new Pessoas();
            fulano.Nome = "Beto";
            fulano.Idade = 55;

            Console.WriteLine($"Olá me chamo {sicrano.Nome} e tenho {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var apresentacaoDoFulano = fulano.Apresentacao();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
