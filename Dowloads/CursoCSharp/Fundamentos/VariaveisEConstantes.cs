using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area dae circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é " + (area + 1000));
            //Tipos Interos:
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo?: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Maior salário {0}", salario);

            int menorvalorInt = int.MinValue;
            Console.WriteLine("Menor valor: " + menorvalorInt);// Mais utilizado dos int

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor de Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000_00;//Mais usado double
            Console.WriteLine("Valor da Apple " + valorDeMercadoApple);

            decimal distanciaDasEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia das estrelas " + distanciaDasEstrelas);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string frase = "Seja bem vindo ao Curso C# !";
            Console.WriteLine(frase);
        }

    }
}
