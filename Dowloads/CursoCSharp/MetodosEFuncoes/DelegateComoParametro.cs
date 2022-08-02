using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegateComoParametro
    {
        public delegate int operacao(int x, int y);
        public static int soma(int x, int y)
        {
            return x + y;
        }
        public static string calculadora(operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return string.Format("Resultado: " + resultado);
        }

        public static void Executar()
        {
            Console.WriteLine(soma(3, 5));
            Console.WriteLine(calculadora(soma,3 ,2));
            operacao subtracao = (int x , int y) => x - y;
            Console.WriteLine(calculadora(subtracao, 3, 2));
            Console.WriteLine(subtracao(6, 2));
        }
    }
}
