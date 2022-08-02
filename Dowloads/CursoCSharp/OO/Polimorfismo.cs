using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
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
    class Arroz : Comida
    {
   
    }
    class Feijao : Comida   
    {

    }
    class Carne : Comida
    {
  
    }
    class Pessoa
    {
        public double Peso;
        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Feijao feijao)
        //{
        //  Peso += feijao.Peso;
        //}
        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}
        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }
    }
    internal class Polimorfismo
    {
        public static void Executar()
        {
            Arroz ingrediente1 = new Arroz();
            ingrediente1.Peso = 0.30;
            Feijao ingrediente2 = new Feijao();
            ingrediente2.Peso = 0.25;
            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.30;
            Pessoa cliente = new Pessoa();
            cliente.Peso = 85.0;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            Console.WriteLine($"O peso do cliente agora é {cliente.Peso}Kg.");
        }
    }
}
