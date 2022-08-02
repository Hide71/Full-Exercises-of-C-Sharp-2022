using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct Dependentes
    {
        public string Nome;
        public int Idade;
    }
    internal class ValorVsReferencia
    {
        public static void Executar()

        {
            int numero = 5;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependentes dependente1 = new Dependentes();
            dependente1.Nome = "José";
            dependente1.Idade = 21;
            Console.WriteLine($"{dependente1.Nome} {dependente1.Idade}");
            var copiaDependente1= dependente1;
            Console.WriteLine($"{copiaDependente1.Nome} {copiaDependente1.Idade}");
            dependente1.Nome = "Carlos";
            copiaDependente1.Idade = 13;
            Console.WriteLine($"{dependente1.Nome} {dependente1.Idade}");
            Console.WriteLine($"{copiaDependente1.Nome} {copiaDependente1.Idade}");


        }
    }
}
