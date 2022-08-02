using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    class ExerciciosB
    {
        public static bool Primo(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));
            if (n == 1) return false;
            if (n == 2) return true;
            for(int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Soma2(int a, int b)
        {
            Console.WriteLine(a + b);
            if(a == 20 ||b == 20 || a + b == 20)
            {
                Console.WriteLine("verdadeiro");
            }
        }
        public static int DiferencaAbs(int a, int b)
        {
           
            return a > b ? Math.Abs(a - b) * 2: Math.Abs(a - b);
        }
        public static int SomaOuTriplo(int a, int b)
        {
            //int resultado = a + b;
            //if (a == b)
            //{
            //    resultado = (a + b) * 3;
            //}
            //return resultado;
            return (a == b) ? (a + b) * 3 : a + b;
        }
        public static Action<int> Cab = ExerciciosA.Cabecalho;
        public static void Executar()
        {
            Console.Clear();
            //Cab(19);
            //Console.Write("Declare um valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //Console.Write("Declare outro valor: ");
            //int.TryParse(Console.ReadLine(), out int valor2);
            //int soma1 = valor1 + valor2;
            //if (valor1 == valor2)
            //{
            //    int soma = soma1 * 3;
            //    Console.WriteLine("O triplo de {0} é: {1}", soma1, soma);
            //}
            //else
            //    Console.WriteLine("A soma ente {0} e {1} é: {2}",valor1, valor2, soma1);

            //Console.WriteLine(SomaOuTriplo(5, 5));
            //Console.WriteLine(SomaOuTriplo(60, 35));
            //Console.WriteLine(SomaOuTriplo(-10, + 50));
            //Console.WriteLine(SomaOuTriplo(3, -10));
            //Cab(20);
            //Console.WriteLine(DiferencaAbs(13, 40));
            //Console.WriteLine(DiferencaAbs(50, 21));
            //Console.WriteLine(DiferencaAbs(0, 23));

            //Cab(21);
            //Soma2(20, 10);
            //Soma2(10, 30);
            //Soma2(6, 16);
            //Soma2(5, 20);
            //Soma2(45, 10);
            //Soma2(10, 10);

            //Cab(24);
            //Console.WriteLine("Escreva uma frase: ");
            //string frase = Console.ReadLine();
            //string[] palavras = frase.Split();
            //string maiorPalavra = " ";
            //int tamanho = 0;
            //foreach(string palavra in palavras)
            //{
            //    if(palavra.Length > tamanho)
            //    {
            //        maiorPalavra = palavra;
            //        tamanho = palavra.Length;
            //    }
            //}
            //Console.WriteLine(maiorPalavra);
            //for(int numeroImpar = 1; numeroImpar <= 99; numeroImpar ++)
            //{
            //    Console.WriteLine(numeroImpar);
            //}
            //Cab(26);
            //long soma = 0;
            //int cont = 0;
            //int n = 2;
            //while(cont < 500)
            //{
            //    if (Primo(n))
            //    {
            //        soma += n;
            //        cont++;
            //    }
            //    n++;
            //}
            //Console.WriteLine(soma.ToString());
            //Cab(27);
            //int soma = 0;
            //Console.WriteLine("Digite um valor: ");
            //int valor = int.Parse(Console.ReadLine());
            //while(valor != 0)
            //{
            //    soma += valor % 10;
            //    valor /= 10;
            //}
            //Console.WriteLine("Soma dos digitos do valor: {0}", soma);

            Cab(28);
            string palavras = "Amor a dois é uma beleza";
            string[] novaPalavra = palavras.Split();
            for(int i = novaPalavra.Length -1; i>= 0; i--)
            {
                Console.Write(novaPalavra[i]);
            }
            
 

        }
    }
}
