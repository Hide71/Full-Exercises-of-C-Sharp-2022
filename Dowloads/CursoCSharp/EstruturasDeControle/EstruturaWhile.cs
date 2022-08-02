using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            int tentativasRestantes = 5;
            int tentativas = 0;
            bool acertou = false;
            while(tentativasRestantes > 0 && !acertou)
            {
                Console.Write("Digite um valor de 1 a 15: ");
                int.TryParse(Console.ReadLine(), out int valor);
                tentativasRestantes--;
                tentativas++;
                if (valor == numeroSecreto)
                {
                    var corNormal = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Acertou com {tentativas} tentativas.");
                    Console.BackgroundColor=corNormal;
                    acertou = true;
                }
                else if (valor > numeroSecreto)
                {
                    Console.WriteLine($"Menos Tente denovo!!!, ainda tem {tentativasRestantes} chances.");

                }
                else if (valor < numeroSecreto){
                    Console.WriteLine($"Mais Tente denovo!! ainda tem {tentativasRestantes} tentativas.");
  
                }
                if (tentativasRestantes == 0)
                {
                    Console.WriteLine("Game Over!!!!");
                }
            }
        }
    }
}
