using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    class Produto
    {
        public string Nome;
        public int Preco;
        public static double Desconto;

        public Produto(string nome, int preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;

        }
        public Produto()
        {

        }
        public double ValorCDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class CadeiasDeInt
    {
        int memoria;
        public CadeiasDeInt Somar(int a)
        {
            memoria += a;
            return this;
        }
        public CadeiasDeInt Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CadeiasDeInt Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

    }
    
    internal class Cadeias
    {
        //int a = 10; 
        public static void Executar()
        {
            
            //Cadeias cad = new();
            //Console.WriteLine(cad.a);
            //CadeiasDeInt cadeias = new();
            //Console.WriteLine(cadeias.Somar(5).Multiplicar(10).Imprimir());
            //Produto produto1 = new("Caneta", 5, 0.1);
            //Produto produto2 = new Produto()
            //{
            //    Nome = "Borracha",
            //    Preco = 7,
            //    //Desconto = 0.5
            //};
            //Console.WriteLine(produto1.ValorCDesconto());
            //Console.WriteLine(produto2.ValorCDesconto());

            //Produto.Desconto = 0.7;
            //Console.WriteLine(produto1.ValorCDesconto());
            //Console.WriteLine(produto2.ValorCDesconto());

            //Produto.Desconto = 0.2;
            //Console.WriteLine(produto1.ValorCDesconto());
            //Console.WriteLine(produto2.ValorCDesconto());


        }
    }
}
