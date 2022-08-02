using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class SuperMercado
    {
        internal string Nome;
        internal double Preco;

        public SuperMercado(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

    }
    internal class Mercadoria : SuperMercado
    {
        public string Departamento = " ";
        public Mercadoria(string nome, double preco) : base(nome, preco)
        {

        }
        public Mercadoria(string nome, double preco, string departamento) : this(nome, preco)
        {
            Departamento = departamento;
        }
        public override string ToString()
        {
            return $"A Mercadoria {Nome} custa {Preco} e está na seção {Departamento}";
        }
    }
    internal class OO3
    {
        public static void Executar()
        {
            Mercadoria mercadoria = new Mercadoria("Arroz", 12, "Alimentação");
            SuperMercado desodorante = new Mercadoria("Vanness", 5, "Perfumaria");
            SuperMercado acougue = new Mercadoria("Contra Filé", 35.5, "Açougue");
            Console.WriteLine(mercadoria);
            Console.WriteLine(desodorante);
            Console.WriteLine(acougue);
            Func<int> dado = () => { Random randon = new Random(); return randon.Next(1, 7); };
            Console.WriteLine(dado());
            Action algoNoconsole = () =>  Console.WriteLine("Olá Mundo!");;
            algoNoconsole();
            Console.ReadKey();
            Console.Clear();
        }



    }
}
    
