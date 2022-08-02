using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    public class Produtos
    {
        public string Nome;
        public double Preco;

        public Produtos()
        {
        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Exercicios22062022
    {
        public static void Executar()
        {
            var novoProduto = new List<Produtos>();
            novoProduto.Add (new Produtos("Arroz", 15));
            var livro = new Produtos("Assasins Creed", 50.89);
            var carrinho = new List<Produtos>();
            carrinho.Add(livro);
            var combo = new List<Produtos>
            {
                new Produtos("Lapis", 2.8),
                new Produtos("Caneta", 5.4),
                new Produtos("Borracha", .50)
            };
            carrinho.AddRange(combo);
            carrinho.Add(new Produtos("Canetinha", 4.99));
            foreach(var itens in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(itens));
                Console.WriteLine($"{itens.Nome} {itens.Preco}");


            }
            int [] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int conta = numeros.Count();
            Console.WriteLine(conta);
            Console.WriteLine(numeros.Contains(2));
            Console.WriteLine(numeros.Max());
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Produtos cerveja = new Produtos()
            {
                Nome = "Antartica",
                Preco = 12.5

            };
            Console.WriteLine(cerveja.Nome);
            var carrinhoCerva = new List<Produtos>();
            carrinhoCerva.Add(cerveja);
            Console.WriteLine(carrinhoCerva.Count());
            var comboCerva = new List<Produtos>
            {
                new Produtos ("Brahma", 15),
                new Produtos ("Skol", 16),
                new Produtos("Heineken", 17)

            };
            carrinhoCerva.AddRange(comboCerva);
            Console.WriteLine(carrinhoCerva.Count);
            foreach(var unidade in carrinhoCerva)
            {
                Console.WriteLine($"{unidade.Nome} {unidade.Preco} ");
            }
        }
    }
}
