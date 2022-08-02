using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            DateTime novaData = new DateTime(year: 2025, month: 6, day: 12);
            Console.WriteLine(novaData);
            Console.WriteLine(DateOnly.FromDateTime(novaData));
            DateTime atual = DateTime.Now;
            Console.WriteLine(atual);
            Console.WriteLine("Horas: " + atual.Hour);
            Console.WriteLine("Minutos: " + atual.Minute);
            var amanha = atual.AddDays(1);
            var ontem = atual.AddDays(-1);
            Console.WriteLine(amanha);
            Console.WriteLine(ontem);
            Console.WriteLine(atual.ToString("dd mm yyyy HH:mm"));
            Console.WriteLine(atual.ToString("D"));
            Console.WriteLine(atual.ToString("d"));
            Console.WriteLine(atual.ToString("f"));
            Console.WriteLine(atual.ToString("g"));
            Console.WriteLine(atual.ToString("G"));
            Console.WriteLine(atual.ToString("GG"));
            Console.WriteLine(atual.ToString("gg"));
            Console.WriteLine(atual.ToString("M"));
            Console.WriteLine(atual.ToString("R"));
            Console.WriteLine(atual.ToString("t"));
            Console.WriteLine(atual.ToString("T"));
           
        }
    }
}
