using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Cronometro
    {
        static void Cabecalho(int b)
        {
            Console.Clear();
            Console.WriteLine("Atenção!!!!");
            Thread.Sleep(1000);
            Console.WriteLine("Contando!!");
            Thread.Sleep(2500);
            Start(b);
        }
        static void Menu()
        {
            Console.WriteLine("M = Minuto");
            Console.WriteLine("S = Segundo");
            Console.WriteLine("0 = Sair");
            Console.Write("Quer contar até quanto?: ");
            int entrada = int.Parse(Console.ReadLine());
            Console.Write("Minuto(m), ou Segundo(s)?: ");
            string tempo = Console.ReadLine().ToLower();
            Console.Clear();
            int multiplayer = 1;
            if (tempo == "m")
            {
                multiplayer = 60;
            }
            if (entrada == 0)
            {
                System.Environment.Exit(0);
            }
            Cabecalho(entrada * multiplayer);
        }
        static void Start(int fim)
        {
            Console.Clear();
            int inicio = 0;
            while(inicio != fim)
            {
                inicio ++ ;
                Console.Clear();
                Console.WriteLine(inicio);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado!");
            Menu();
        }
        public static void Executar()
        {
            Menu();
        }
    }
}
