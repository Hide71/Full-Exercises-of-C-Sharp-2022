using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;
        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {

        }
        public double PrecoComDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.44, 0.1);
            Console.WriteLine(produto1.PrecoComDesconto());
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 1.99,
                //Desconto = 0.5

            };
            Console.WriteLine(produto2.PrecoComDesconto());
            Produto.Desconto = 0.02;
            Console.WriteLine(produto1.PrecoComDesconto());
            Console.WriteLine(produto2.PrecoComDesconto());





        }
    }
}
