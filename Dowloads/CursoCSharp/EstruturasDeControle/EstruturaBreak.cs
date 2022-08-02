using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine("O numero que queremos é: {0} ", numero);
            for(int i = 1; i <= 50; i++)
            {
                Console.Write($"{i} é o numero escolhido?: ");
                if (i == numero)
                {
                    Console.WriteLine("Sim!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não!!");
                }
            }
        }
    }
}
