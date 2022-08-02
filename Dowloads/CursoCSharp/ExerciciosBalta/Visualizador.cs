using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Visualizador
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Modo Visualizador");
            Console.WriteLine("===================");
            Replace(texto);
            Console.WriteLine("===================");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string texto)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var palavras = texto.Split(' ');

            for(var i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(palavras[i].Substring(palavras[i].IndexOf('>') + 1,((palavras[i].LastIndexOf('<') - 1) - palavras[i].IndexOf('>'))));
                    Console.Write(" ");

                    
                          
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
