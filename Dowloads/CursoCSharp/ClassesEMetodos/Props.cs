using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CursoCSharp.ClassesEMetodos
{
    class CarroOpcional
    {
        string nome;
        double desconto = 0.1;
        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco; 
        }
        public CarroOpcional()
        {

        }
        public string Nome
        {
            get
            {
                return("Opcional: " + nome);
            }
            set
            {
                nome = value;
            }
        }
        public double Preco { get; set;}
        public double PrecoComDesconto
        {
            get => Preco - Preco * desconto;
        }
    }
    internal class Props
    {
        public static void Executar()
        {
            CarroOpcional carro1 = new CarroOpcional("Direção Elétrica", 1050.50);
            Console.WriteLine(carro1.Nome);
           Console.WriteLine(carro1.PrecoComDesconto);
            CarroOpcional carro2 = new CarroOpcional();
            carro2.Nome = "Vidro";
            carro2.Preco = 300;
            Console.WriteLine(carro2.PrecoComDesconto);
            Console.WriteLine(carro2.Nome);
            Console.WriteLine(carro2.Preco);
            
            
        }
    }
}
