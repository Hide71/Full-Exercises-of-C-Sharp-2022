using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CursoCSharp.ExerciciosBalta
{
    internal class UsandoMoedas
    {
        public static void Executar()
        {
            decimal salario = 10578.95m;
            Console.WriteLine(salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br")));
            Console.WriteLine(salario.ToString("F", CultureInfo.CreateSpecificCulture("pt-Br")));
            Console.WriteLine(salario.ToString("N", CultureInfo.CreateSpecificCulture("pt-Br")));
            Console.WriteLine(salario.ToString("G", CultureInfo.CreateSpecificCulture("pt-Br")));
            Console.WriteLine(Math.Round(salario));
            Console.WriteLine(Math.Ceiling(salario));
            Console.WriteLine(Math.Floor(salario));
        }
    }
}
