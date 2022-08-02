using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();
        public string Tocar()
        {
            return "Trim trim trim";
        }
    }
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Bixby";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Siri";
        }
    }
    internal class Abstract
    {
        public static void Executar()
        {
            Celular sam = new Samsung();
            Console.WriteLine(sam.Assistente());
            Iphone phone = new Iphone();
            Console.WriteLine(phone.Assistente());

            //var celular = new List<Celular>
            //{
            //    new Iphone(),
            //    new Samsung()
            //};
            //foreach (var celulares in celular)
            //{
            //    Console.WriteLine(celulares.Assistente());
            //}
        }
    }
}
