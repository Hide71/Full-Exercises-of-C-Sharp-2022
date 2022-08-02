using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Sponto
    {
        public int X;
        public int Y;
    }
    public class Cponto
    {
        public int X;
        public int Y;
    }
    internal class StructVsClasse
    {
        public static void Executar()
        {
            Sponto ponto1 = new Sponto { X = 3, Y = 5 };
            Sponto copiaPonto1 = ponto1;
            copiaPonto1.X = 5;
            Console.WriteLine(ponto1.X);
            Console.WriteLine(copiaPonto1.X);

            Cponto ponto2 = new Cponto { X = 3,Y = 5 };
            Cponto copiaPonto2 = ponto2;
            copiaPonto2.X = 5;
            Console.WriteLine(ponto2.X);
            Console.WriteLine(copiaPonto2.X);
        }
    }
}
