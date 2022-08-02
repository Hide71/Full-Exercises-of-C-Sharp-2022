using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    public class Filho : SubCelebridade2
    {
        public new void Acessar()
        {
            Console.WriteLine("Filho ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine(nivel1);
            Console.WriteLine(nivel2);
            Console.WriteLine(nivel3);
            Console.WriteLine(nivel4);
            Console.WriteLine(nivel5);
            //Console.WriteLine(nivel6);
            Console.WriteLine("---------------------------");
        }
    } 
}
