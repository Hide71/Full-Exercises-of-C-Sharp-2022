using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.745;
            Console.WriteLine(valor.ToString("f1"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("C0"));
            Console.WriteLine(valor.ToString("#.##"));
            Console.WriteLine(valor.ToString("C"));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
