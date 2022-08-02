using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
     class ExerciciosA
    {
        public static void Cabecalho(int a)
        {
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine(string.Format("Exercicio numero " + a));
            Console.WriteLine("++++++++++++++++++++++");
        }
        public static string MudarPrimeiroEultimo(string palavra)
        {
            return palavra.Length > 1 ? palavra.Substring(palavra.Length - 1) + palavra.Substring(1, palavra.Length - 2) + palavra.Substring(0, 1) : palavra;
        }
        public static void Executar()
        {
            Console.Clear();
            //Cabecalho(1);
            //Console.WriteLine("Olá!");
            //Console.WriteLine("Hideraldo Rodrigues");

            //Cabecalho(2);
            //Console.Write("Digite um valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A Soma ente {valor1} e {valor2} é: {valor1 + valor2}.");

            //Cabecalho(3);
            //int a = 50;
            //int b = 10;
            //Console.WriteLine(a / b);

            //Cabecalho(4);
            //Console.WriteLine("Testar dados:");
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5)% 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //Cabecalho(5);
            //Console.Write("Digite o primeiro numero: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("O primeiro numero digitado foi {0} , o segundo foi: {1} Portanto: ", a, b);
            //int c = a;
            //a = b;
            //b = c;


            //Console.WriteLine("O primeiro trocado é: {0} e o segundo trocado é: {1}", a, b);

            //Cabecalho(6);

            //Console.Write("Digite um numero a multiplicar:");
            //var entrada1 = int.TryParse(Console.ReadLine(), out int numero1);
            //Console.Write("Digite outro numero a multiplicar:");
            //var entrada2 = int.TryParse(Console.ReadLine(), out int numero2);
            //Console.Write("Digite mais outro  numero a multiplicar:");
            //var entrada3 = int.TryParse(Console.ReadLine(), out int numero3);
            //Console.WriteLine(numero1 * numero2 * numero3 );
            //Cabecalho(7);
            //Console.Write("Digite o primeiro numero: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2} ", a, b, a - b);
            //Console.WriteLine("{0} * {1} = {2}",a, b,  a * b);
            //Console.WriteLine("{0} / {1} = {2}",a, b,  a / b);

            //Cabecalho(8);
            //Console.Write("Digite a tabuada: ");
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Tabuada do {numero}:");
            //Console.WriteLine("----------------------");
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine($"{numero} X  1 = {numero * 1}");
            //Console.WriteLine($"{numero} X  2 = {numero * 2}");
            //Console.WriteLine($"{numero} X  3 = {numero * 3}");
            //Console.WriteLine($"{numero} X  4 = {numero * 4}");
            //Console.WriteLine($"{numero} X  5 = {numero * 5}");
            //Console.WriteLine($"{numero} X  6 = {numero * 6}");
            //Console.WriteLine($"{numero} X  7 = {numero * 7}");
            //Console.WriteLine($"{numero} X  8 = {numero * 8}");
            //Console.WriteLine($"{numero} X  9 = {numero * 9}");
            //Console.WriteLine($"{numero} X 10 = {numero * 10}");
            //Console.WriteLine("-------------------------------");
            //Console.ResetColor();

            //Cabecalho(9);
            //Console.Write("Digite o primeiro numero: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro numero: ");
            //int numero3 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o quarto numero: ");
            //int numero4 = int.Parse(Console.ReadLine());
            //int soma = numero1 + numero2 + numero3 + numero4;
            //double media = soma / 4;
            //Console.WriteLine($"A media entre {numero1}, {numero2}, {numero3}, {numero4} é: {media} ");

            //Cabecalho(10);
            //Console.Write("Digite o primeiro numero: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("Digite o terceiro numero: ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($"O resultado dos numeros {x}, {y}, {z} :(x + y) * z é: {(x + y) * z}" +
            //    $"e x * y + y * z é {x * y + y * z}");

            //Cabecalho(11);
            //Console.Write("Qual é a sua idade?: ");
            //int idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Voce parece ter mais de {0} anos.", idade);


            //Cabecalho(12);

            //Console.Write("Digite um numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{numero} {numero} {numero} {numero}");
            //Console.WriteLine($"{numero}{numero}{numero}{numero}");
            //Console.WriteLine($"{numero} {numero} {numero} {numero}");
            //Console.WriteLine($"{numero}{numero}{numero}{numero}");


            //Cabecalho(13);

            //Console.Write("Digite um numero: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{numero1}{numero1}{numero1}");
            //Console.WriteLine($"{numero1} {numero1}");
            //Console.WriteLine($"{numero1} {numero1}");
            //Console.WriteLine($"{numero1} {numero1}");
            //Console.WriteLine($"{numero1}{numero1}{numero1}");

            //Cabecalho(14);
            //Console.WriteLine("Digite o grau: ");
            //int grau = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("A conversão de {0} C para Kelvin é: {1} K", grau, grau + 273);
            //Console.WriteLine("A conversão de {0} C para Fahrenheit é: {1} F", grau, grau * 18 / 10 + 32);

            //Cabecalho(15);
            //string palavra = "homem aranha";
            //Console.WriteLine("univesp".Remove(0, 1));
            //Console.WriteLine(palavra.Remove(1, 1));
            //Console.WriteLine(palavra.Replace("anha", "eia"));

            //Cabecalho(16);
            //Console.WriteLine(MudarPrimeiroEultimo("pastel"));
            //Console.WriteLine(MudarPrimeiroEultimo("H"));
            //Console.WriteLine(MudarPrimeiroEultimo("paralelepipedo"));
            //Console.WriteLine("pastel".Length);
            //Console.WriteLine("pastel".Substring("pastel".Length - 1));
            //Console.WriteLine("pastel".Substring(1, "pastel".Length - 2));
            //Console.WriteLine("pastel".Substring(0, 1));
            //Console.WriteLine("pastel".Substring(3));

            //string nome = "amigavel";
            //Console.WriteLine($"{nome.Substring(5)}{nome.Substring(1, 6)}{nome.Substring(0, 1)}");

            //Cabecalho(17);
            //string name = "A raposa marrom rápida pula sobre o cão preguiçoso";
            //char letra = name[0];
            //Console.WriteLine($"{letra}{name}{letra}");
            //Console.WriteLine("Escreva a frase: ");
            //string frase = Console.ReadLine();
            //if (frase.Length >= 1)
            //{
            //    string l = frase.Substring(0, 1);
            //    Console.WriteLine($"{l}{frase} {l}");
            //}

            Cabecalho(18);
            Console.WriteLine("Digite um valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((valor1 < 0 && valor2 > -1) || (valor2 < 0 && valor1 > -1));



           

            
        }

    }
}
