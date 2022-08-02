using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            double preco = 1000.0;
            int imposto = 355;
            double desconto = 0.1;
            var totalSemDesconto = preco + imposto;
            var precoComDesconto = totalSemDesconto - totalSemDesconto * desconto;
            Console.WriteLine(precoComDesconto);

            var peso = 70;
            var altura = 1.68;
            var imc = peso / Math.Pow(altura, 2);
            Console.WriteLine(imc);

            int par = 22;
            int impar = 55;
            Console.WriteLine($"O numero {par}/ 2 tem resto {par % 2} .");
            Console.WriteLine($"O numero {impar}/ 2 tem resto {impar % 2} .");

        }
    }
}
