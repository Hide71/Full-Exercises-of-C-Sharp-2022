using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;   
        }
    }
    class Multiplicar : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }
    class Calculadora
    {
        List<OperacaoBinaria> operacao = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicar()
        };
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
            foreach (var op in operacao)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = new Calculadora().ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
