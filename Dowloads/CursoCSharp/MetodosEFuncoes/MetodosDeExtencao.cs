using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int soma(this int numero, int outroNumero)
        {
            return numero + outroNumero;
        }
        public static int subtracao (this int numero, int outroNumero)
        {
            return numero - outroNumero;
        }
    }
    internal class MetodosDeExtencao
    {
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.soma(5));
            Console.WriteLine(numero.subtracao(2));
            Console.WriteLine(2.soma(20));
            Console.WriteLine(5.subtracao(3));
        }
    }
}
