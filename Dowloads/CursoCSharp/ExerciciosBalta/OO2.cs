using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class OO2
    {
        public class Animal
        {
            public string Nome;
            public int Num;

            public Animal(string nome, int num)
            {
                Nome = nome;
                Num = num;
            }

        }
        public class Cachorro : Animal
        {
            public double Altura;
            public Cachorro(string nome, int num): base(nome, num)
            {
                Console.WriteLine($"{nome} numero {num} inicializado do Animal");
            }
            public Cachorro(string nome,int num, double altura) : this(nome, num)
            {
                Altura = altura;
            }
            public override string ToString()
            {
                return $"O {Nome} tem {Altura} de altura";
            }

        }
        public static void Executar()
        {
            Cachorro sheik = new Cachorro("Sheik", 1, 3.00);
            Console.WriteLine(sheik.ToString());
            Animal cach = new Cachorro("Bambi", 0, 7);
            Console.WriteLine(cach.ToString());
            Action teste = () => { Console.WriteLine("Estou testando apenas");};
            Func<int> dadinho = ()=> { Random random = new Random();return random.Next(1, 12);};
            Console.WriteLine(dadinho());
        }

    }
}
