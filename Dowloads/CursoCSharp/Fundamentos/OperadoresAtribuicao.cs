using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var numero = 3;
            numero = 7;
            numero += 10;
            numero -= 3;
            numero *= 5;
            numero /= 2;
            Console.WriteLine(numero);

            int a = 1;
            int b = a;
            a++;
            b--;
            Console.WriteLine($"{a} {b}");
        }
    }
}
