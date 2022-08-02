using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected int VelocidadeMaxima;
        int VelocidadeInicial;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeInicial + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeInicial = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeInicial = VelocidadeMaxima;
            }
            else
            {
                VelocidadeInicial = novaVelocidade;
            }
            return VelocidadeInicial;
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
    public class Uno : Carro
    {
        public Uno (): base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari(): base(350)
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
    internal class Heranca
    {
        public static void Executar()
        {
            Uno carro1 = new Uno();
            Console.WriteLine("Uno...");
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Ferrari carro2 = new Ferrari();
            Console.WriteLine("Ferrari...");
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Carro carro3 = new Ferrari();
            Console.WriteLine("Ferrari com Tipo Carro...");
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            carro3 = new Uno();
            Console.WriteLine("Uno com Tipo Carro...");
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
