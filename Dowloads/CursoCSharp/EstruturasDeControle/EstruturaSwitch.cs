using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch 
    { 
        public static void Executar()
        {
            Console.Write("Avalie o atendimento com notas de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break ;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    Console.WriteLine("Parabéns");
                    break;
                case 5:
                    Console.WriteLine("Otimo");
                    break;
                default:
                    Console.WriteLine("Erro ao digitar!!");
                    break;
                    
            }
            Console.WriteLine("Obrigado por votar!!!");
        }
    }
}
