using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Os numeros pares entre 0 e {intervalo} são: ");
            for(int i = 0; i <= intervalo; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }
                else
                {
                    if (i < 50)
                    {
                        Console.Write($"{i} ->");

                    }
                    else { Console.Write($"{i}."); }

                }
            }
        }
    }
}
