using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            do
            {
                Console.Write("Qual é o seu nome?: ");
                entrada = Console.ReadLine();
                Console.WriteLine($"Muito Prazer,{entrada}!");
                Console.WriteLine("Quer cotinuar?(S/N): ");
                entrada = Console.ReadLine();
            }
            while(entrada.ToLower()== "s");
        }
    }
}
