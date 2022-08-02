using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploTimeSpam
    {
        public static void Executar()
        {
            TimeSpan tempo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(tempo.Minutes);
            var comeco = DateTime.Now;
            var fim = DateTime.Now.AddMinutes(8);
            var resultado = fim - comeco;
            Console.WriteLine(resultado);

            Console.WriteLine(tempo.Add(TimeSpan.FromSeconds(8)));
            Console.WriteLine(tempo);
            Console.WriteLine(tempo.Subtract(TimeSpan.FromSeconds(8)));
            Console.WriteLine(tempo);


            Console.WriteLine(tempo.ToString("g"));
            Console.WriteLine(tempo.ToString("G"));
            Console.WriteLine(tempo.ToString("c"));
            
            Console.WriteLine(TimeSpan.Parse("01:10:33").TotalMilliseconds);


        }
    }
}
