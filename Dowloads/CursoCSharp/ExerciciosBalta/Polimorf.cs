using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Polimorf
    {
        public class Comida
        {
            public double Peso;
            public Comida(double peso)
            {
                Peso = peso;
            }
            public Comida()
            {

            }
        }
        public class Arroz : Comida
        {
            public Arroz(double Peso) : base(Peso) { }
        }
        public class Feijao : Comida
        {
            public Feijao(double Peso) : base(Peso) { }
        }
        public class Carne : Comida
        {
        }
        public class Pessoa
        {
            public double Peso ;

            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar()
        {
            Arroz ingrediente1 = new(0.3);
            Feijao ingrediente2 = new(0.25);
            Carne ingrediente3 = new();
            ingrediente3.Peso = 0.3;
            Pessoa cliente = new();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}!");
                
        }
    }
}
