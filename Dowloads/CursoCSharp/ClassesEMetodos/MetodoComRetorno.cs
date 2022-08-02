using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Calculadora
    {
        public int somar(int a, int b)
        {

            return a + b;
        }
        public double dividir(int a, int b)
        {
            return a / b;
        }
        public int subtrair(int c, int d)
        {
            return c - d;
        }
        public int multiplicar(int z , int t)
        {
            return z * t;
        }
    }
    class CalculadoraCadeia
    {
        int memoria;
        public CalculadoraCadeia somar(int a)
        {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia subtrair(int a)
        {
                memoria -= a;
                return this;
        }
        public CalculadoraCadeia dividir(int a)
        {
            memoria /= a;
            return this;
        }
        public CalculadoraCadeia multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public CalculadoraCadeia zerar()
        {
            memoria = 0;
            return this;
        }
    }



    internal class MetodoComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new Calculadora();
            Console.WriteLine(calculadoraComum.somar(5, 6));
            int calc = calculadoraComum.multiplicar(5, 2);
            Console.WriteLine(calc);
            Console.WriteLine(calculadoraComum.dividir(15, 3));
            Console.WriteLine(calculadoraComum.subtrair(6, 5));
            var calc2 = new CalculadoraCadeia();
            Console.WriteLine(calc2.somar(5).subtrair(3).imprimir().zerar().imprimir().somar(2).multiplicar(10).
                dividir(2).imprimir().subtrair(1).imprimir().zerar().imprimir());
        }
    }
}
