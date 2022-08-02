using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Calculadora2
    {
        public static void MenuCronometro()
        {
            Console.WriteLine("Quer contar até quanto: ");
            Console.WriteLine("S = 1s = segundos");
            Console.WriteLine("M = 1M = minutos");
            string dados = Console.ReadLine().ToLower();
            int multiplicador = 1;
            string  sM = dados.Substring(dados.Length -1);
            string va = dados.Substring(0, dados.Length - 1);
            int va1 = Convert.ToInt32(va);
            if(sM == "m")
            {
                multiplicador = 60;
            }
            Cronometro(va1);
        }
        public static void Cronometro(int valor)
        {
            for(int i = 0; i <= valor; i++)
            {
                Console.Clear();
                Console.Write(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Cronometro finalizado!");
        }
        public void Somador()
        {
            Console.WriteLine("Digite um valor: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A soma entre {a} e {b} é {a + b}" );
        }
        public static void Somar()
        {
            Console.Clear();
            Console.Write("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float resultado = valor1 + valor2;
            Console.WriteLine("O resultado da soma entre {0} e {1} é {2}", valor1, valor2, resultado);
            Console.ReadKey();
        }
        public static void Subtrair()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            float.TryParse(Console.ReadLine(), out float valor1);
            Console.Write("Digite outro valor: ");
            float.TryParse(Console.ReadLine(), out float valor2);
            Console.WriteLine($"O resultado da subtração entre {valor1} e {valor2} é {valor1 - valor2}");
            Console.ReadKey();
        }
        public static void Dividir()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            float.TryParse(Console.ReadLine(), out float valor1);
            Console.Write("Digite outro valor: ");
            float.TryParse(Console.ReadLine(), out float valor2);
            Console.WriteLine($"O resultado da divisão entre {valor1} e {valor2} é {valor1 / valor2}");
            Console.ReadKey();

        }
        public static void Multiplicar()
        {
            Console.Clear();
            Console.Write("Digite um valor: ");
            float.TryParse(Console.ReadLine(), out float valor1);
            Console.Write("Digite outro valor: ");
            float.TryParse(Console.ReadLine(), out float valor2);
            Console.WriteLine($"O resultado da multiplicação entre {valor1} e {valor2} é {valor1 * valor2}");
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("-------------");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("[1]- Somar");
            Console.WriteLine("[2]- Subtair");
            Console.WriteLine("[3]- Dividir");
            Console.WriteLine("[4]- Multiplicar");
            Console.WriteLine("[5]- Sair");
            Console.WriteLine("-----------------");
            Console.Write("Opção: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            switch (opcao)
            {
                case 1: Somar();break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 5: System.Environment.Exit(0);break;
                default:Menu();break;
            };
        }
        public static void Executar()
        {
            Calculadora2 calculadora2 = new Calculadora2();
            calculadora2.Somador();
        }
    }
}
