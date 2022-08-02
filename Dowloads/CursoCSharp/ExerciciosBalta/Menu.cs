using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DesenharLinha();
            EscreverOpcao();
            var entrada = int.Parse(Console.ReadLine());
    
            Chamar(entrada);
        }
        public static void DesenharLinha()
        {
            Console.Write("+");
            for (int linha = 0; linha <= 30; linha++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
            for (int coluna = 0; coluna <= 10; coluna++)
            {
                Console.Write("|");
                for(int linha = 0; linha <= 30; linha++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");

            }
            Console.Write("+");
            for (int linha = 0; linha <= 30; linha++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void EscreverOpcao()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma Opção: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("[1]- Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("[2]- Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("[0]- Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }
        public static void Chamar(int entrada)
        {
            switch (entrada)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Abrir");break;
                case 0:
                    { 
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                     
                    }
                default:Show();break;
            }
        }

    }
}
