using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            string entrada;
            double soma = 0;
            Console.Write("Informe o numero de alunos: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int alunos);
            for(int i = 1; i <= alunos; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double nota);
                soma += nota;

            }
            double media = alunos > 0 ? soma / alunos : 0;
            Console.WriteLine($"Media da turma: {media}");

        }
    }
}
