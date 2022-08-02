using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    
    delegate double Operacao(double a, double b);
    internal class LambdaComDelegate
    {
        public static void Executar()
        {
            Operacao soma = (a, b) => (a + b);
            Operacao sub = (a, b) => (a - b);
            Operacao mult = (a, b) => (a * b);
            Operacao div = (a, b) => (a / b);
            Console.WriteLine(soma(5,5));
            Console.WriteLine(sub(10,5));
            Console.WriteLine(mult(6,5));
            Console.WriteLine(div(25,5));
        }
    }
}
