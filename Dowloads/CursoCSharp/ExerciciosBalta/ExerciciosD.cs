using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class ExerciciosD
    {

        public static bool Teste(string a)
        {
            int c = 0;
            for (int i = 0; i < a.Length -1; i++)
            {
                if (a[0].Equals('w'))
                    c++;
                if (a.Substring(i, 2).Equals("ww") && c > 2)
                    return false;

            }
            return true;
        }
        public static Action<int> Ex = ExerciciosC.NomeEx;
        public static void Executar()
        {
            //Ex(43);
            //Console.WriteLine("Digite uma entrada: ");
            //var entrada = Console.ReadLine();
            //Console.WriteLine(Teste(entrada));

            //Ex(44);
            //Console.WriteLine("digite algo: ");
            //string algo = Console.ReadLine();
            //var c = string.Empty;
            //for(int i = 0; i < algo.Length; i++)
            //{
            //    if(algo[i] % 2 == 0)
            //    {
            //        c += algo[i];

            //    }
            //}
            //Console.WriteLine(c);

            //Ex(45);
            //Console.WriteLine("Digite um valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //int[] lista = { 1, 1, 3, 5, 6, 6, 6, 2, 9, 5, 0, 8, 9, 9, 9, 9 };
            //for(int i = 0; i < lista.Length; i++)
            //{
            //    if (lista[i].Equals(valor))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(lista.Count(s => s == valor));
            //Ex(46);
            //Console.WriteLine("Digite um valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            //Console.WriteLine(numeros[0] == valor || numeros[numeros.Length -1] == valor);
            Action lambda = () =>
            {

                Console.WriteLine("Ola tudo bem?");
            };
            lambda();
            
        }

    }
}
