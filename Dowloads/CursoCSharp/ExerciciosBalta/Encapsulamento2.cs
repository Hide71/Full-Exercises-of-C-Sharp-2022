using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento2;

namespace CursoCSharp.ExerciciosBalta
{
    public class Adotivo : SubCelebridade2
    {
        public new void Acessar()
        {
            Console.WriteLine("Adotivo...");
            Console.WriteLine("-------------------");
            Console.WriteLine(nivel1);
            Console.WriteLine(nivel2);
            //Console.WriteLine(nivel3);
            Console.WriteLine(nivel4);
            //Console.WriteLine(nivel5);
            //Console.WriteLine(nivel6);
            Console.WriteLine("-----------------------------");
        }
    }
    public class AmigoDistante2
    {
        public SubCelebridade2 amiga2 = new();
        public void Acessar()
        {
            Console.WriteLine("Amigo Distante...");
            Console.WriteLine("----------------------");
            Console.WriteLine(amiga2.nivel1);
            //Console.WriteLine(amiga2.nivel2);
           //Console.WriteLine(amiga2.nivel3);
            //Console.WriteLine(amiga2.nivel4);
            //Console.WriteLine(amiga2.nivel5);
            //Console.WriteLine(amiga2.nivel6);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
        }
    }
    internal class Encapsulamento2
    {
        public static void Executar()
        {
            //SubCelebridade2 primeiroAcesso = new();
            //primeiroAcesso.Acessar();
            new SubCelebridade2().Acessar();
            //Filho filho = new();
            //filho.Acessar();
            new Filho().Acessar();
            new Amigo2().Acessar();
            new Adotivo().Acessar();
            new AmigoDistante2().Acessar();
       
        }
    }
}
