using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite uma nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            double notaDeCorte = 7.0;
            Console.WriteLine($"Nota invalida?: {nota > 10}");
            Console.WriteLine($"Nota invalida?:{nota < 0 } ");
            Console.WriteLine($"Tem como melhorar?:{nota != 10} ");
            Console.WriteLine($"Passou por média?: {nota == notaDeCorte}");
            Console.WriteLine($"Recuperação?: {nota >= 5.0}");
            Console.WriteLine($"Reprovado?: {nota <= 3.0}");

         
        }
    }
}
