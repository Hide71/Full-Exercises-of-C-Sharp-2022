using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        class CalculadoraEstatica
        {
            public int somar(int a, int b)
            {
                return a + b;
            }   
            public static int multiplicar(int a, int b)
            {
                return a * b;
            }
       
        }

        public static void Executar()
        {
            var calc = new CalculadoraEstatica();
            Console.WriteLine(calc.somar(3,6));
            //Console.WriteLine(calc.multiplicar(6,6));
            Console.WriteLine(CalculadoraEstatica.multiplicar(6, 6));
        }
    }
}
