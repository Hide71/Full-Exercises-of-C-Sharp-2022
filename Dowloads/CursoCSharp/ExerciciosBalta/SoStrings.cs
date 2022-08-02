using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Carro
    {
        internal protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;
        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int a)
        {
            int novaVelocidade = VelocidadeAtual + a;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                novaVelocidade = VelocidadeMaxima;
            }
            else
                VelocidadeAtual = novaVelocidade;
            return VelocidadeAtual;

        }
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }
    internal class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    internal class Ferrari : Carro
    {
        public Ferrari(): base(500)
        {

        }
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }
    internal class SoStrings
    {
        public static void Executar()
        {
            // var lista1 = new List<string>();
            // lista1.Add("Deixa");
            // lista1.Add("a");
            // lista1.Add("vida");
            // lista1.Add("me");
            // lista1.Add("Deixa");
            // lista1.Add("levar");
            // Console.WriteLine(lista1[0]);
            // lista1.Insert(5, "o destino me");
            // foreach(string palavras in lista1)
            // {
            //     var retorna = Console.BackgroundColor;
            //     Console.BackgroundColor = ConsoleColor.DarkRed;
            //     Console.WriteLine(palavras);
            //     Console.BackgroundColor = retorna;
            // }
            // var lista2 = new List<string>
            // {
            //     "amor",
            //     "paz",
            //     "Deus no coração"
            // };
            // lista1.AddRange(lista2);
            // lista1.ForEach(i => Console.WriteLine(i));
            // //Console.Write(palavras);
            // var amor = "Amor";
            // var lista3 = new List<string>();
            // lista3.Add(amor);
            // Console.WriteLine(lista3[0]);
            // Console.ReadKey();
            // Console.Clear();
            // var nomes = new List<string>
            // {
            //     "hideraldo",
            //     "clodoaldo",
            //     "denivaldo",
            //     "rafael"
            // };
            // nomes.ForEach(a => Console.WriteLine($"Muito Prazer!{a.ToUpper()}"));
            // Console.WriteLine($"Meu nome é {nomes[0]}");
            // Console.WriteLine("Quantas sequencias Fibonacci?: ");
            // int.TryParse(Console.ReadLine(), out int vezes);
            // int numero = 0;
            // int proximo = 0;
            //     var fibonacci = new List<int> { 1, 1 };
            // while(numero < vezes)
            // {
            //     numero = numero +1;
            //     proximo = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
            //     fibonacci.Add(proximo);


            // }
            // fibonacci.ForEach(a => Console.WriteLine(a));
            // var arrayList = new ArrayList
            // {
            //     "Pano",
            //     true,
            //     3,
            //     4.6

            // };
            // foreach(var itens in arrayList)
            // {
            //     Console.WriteLine(itens);
            // }
            // Console.WriteLine(arrayList[1]);
            // HashSet<string> conjunto = new HashSet<string>
            // {
            //     "Banco",
            //     "dados",
            // };
            // conjunto.Add("Faca");
            // foreach(string i in conjunto)
            // {
            //     Console.WriteLine(i);
            // }
            // Queue fila = new Queue();
            // fila.Enqueue(3);
            // fila.Enqueue("Bolinha");
            // fila.Enqueue("Neymar");
            // fila.Enqueue(true);
            // Console.WriteLine(fila.Dequeue());
            // Console.WriteLine(fila.Peek());
            // Console.WriteLine(fila.Dequeue());
            // foreach(object i in fila)
            // {
            //     Console.WriteLine(i);
            // }
            // Queue<Produtos> car = new Queue<Produtos>();
            // car.Enqueue(new Produtos("Sacola", 5));
            // car.Enqueue(new Produtos("Bola", 16));
            // car.Enqueue(new Produtos("Perfume", 85));
            // foreach(var a in car)
            // {
            //     Console.WriteLine($"{a.Nome} {a.Preco}");
            // }
            // int[] um = { 2, 4, 6, 8 };
            // int[] dois = { 4, 8, 12, 10 };
            // //Console.WriteLine(string.Join(",", um));
            //// Console.WriteLine(string.Join(",", dois));
            //for(int i = 0; i < um.Length; i++)
            // {
            //     Console.WriteLine(um[i] * dois[i]);
            //     Console.WriteLine();
            // }
            // Console.WriteLine("Maior de Quatro");
            // Console.WriteLine("----------------");
            // Console.Write("Digite um valor:" );
            // int.TryParse(Console.ReadLine(), out int uma);
            // Console.Write("Digite um valor:" );
            // int.TryParse(Console.ReadLine(), out int doisa);
            // Console.Write("Digite um valor:" );
            // int.TryParse(Console.ReadLine(), out int tres);
            // Console.Write("Digite um valor:" );
            // int.TryParse(Console.ReadLine(), out int quatro);
            // Console.WriteLine($"O maior valor entre {uma}, {doisa}, {tres} e {quatro} é: ");
            // Console.WriteLine(Math.Max(Math.Max(uma, doisa), Math.Max(tres, quatro)));
            // Console.WriteLine($"O menor valor entre {uma}, {doisa}, {tres} e {quatro} é: ");
            // Console.WriteLine(Math.Min(Math.Min(uma, doisa), Math.Min(tres, quatro)));

            //Console.Clear();
            //Console.WriteLine("Digite um valor: ");
            //int.TryParse(Console.ReadLine(), out int valor1);
            //int[] valores = { 11, 0, 2, 4, 7, 5, 9, 12, 89, 13, 12, 89, 4, 7, 9, 4, 9, 12 };
            ////Console.WriteLine(valores.Count(n => n == valor1));
            //Console.WriteLine(valores[0] == valores[valores.Length - 1]);
            Uno carro1 = new();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.VelocidadeMaxima);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Ferrari carro2 = new();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.VelocidadeMaxima);
            Console.BackgroundColor = ConsoleColor.Black;
            Carro carro3 = new Uno();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.BackgroundColor = ConsoleColor.Black;

            Carro carro4 = new Ferrari();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Acelerar());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.WriteLine(carro4.Frear());
            Console.BackgroundColor = ConsoleColor.Black;




        }
    }
}
