using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaForeach
    {
        public static void Executar()
        {
            string palavra = "Olá!";
            foreach(var letras in palavra)
            {
                Console.WriteLine(letras);
            }
            var nomes = new string[] { "Maria", "José", "Paula", "Marcia" };
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
