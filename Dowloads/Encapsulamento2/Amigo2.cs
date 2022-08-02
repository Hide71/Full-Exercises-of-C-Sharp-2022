using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    public  class Amigo2
    {
        SubCelebridade2 amigo = new();
        public  void Acessar()
        {
            Console.WriteLine("Amigo...");
            Console.WriteLine("-----------------");
            Console.WriteLine(amigo.nivel1);
            //Console.WriteLine(amigo.nivel2);
            Console.WriteLine(amigo.nivel3);
            Console.WriteLine(amigo.nivel4);
            //Console.WriteLine(amigo.nivel5);
            //Console.WriteLine(amigo.nivel6);
            Console.WriteLine("-------------------");
        }
        
    }
}
