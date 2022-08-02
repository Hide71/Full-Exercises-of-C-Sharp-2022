using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            Console.Write("Digite a nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Tem bom comportamento? (S/N): ");
            entrada = Console.ReadLine();
            bomComportamento = entrada.ToLower() == "s";
            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!!");
            }



        }
    }
}
