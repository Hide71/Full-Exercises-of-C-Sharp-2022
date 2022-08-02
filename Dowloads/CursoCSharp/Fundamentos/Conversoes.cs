using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int nota = 10;
            double notaQuebrada = nota;
            Console.WriteLine(notaQuebrada);
            double nota3 = 9.7;
            int nota2 = (int)nota3;
            Console.WriteLine(nota2);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine(idadeInt);

            idadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine(idadeInt);

            Console.Write("Digite um numero: ");
            string entrada = Console.ReadLine();
            int numero;
            int.TryParse(entrada, out numero);
            Console.WriteLine(numero);

            Console.Write("Digite um numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);


        }
    }
}
