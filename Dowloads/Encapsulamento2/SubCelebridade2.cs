using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento2
{
    public class SubCelebridade2
    {
        public string nivel1 = "Todo mundo acessa";
        protected string nivel2 = "Só por Herança";
        internal string nivel3 = "Mesmo Projeto";
        internal protected string nivel4 = "Somente herança e mesmo Projeto";
        private protected string nivel5 = "Mesma classe ou Herança no mesmo projeto";
        private bool nivel6 = true;

        public void Acessar()
        {
            Console.WriteLine("Subcelebridade 2 ...");
            Console.WriteLine("-----------------------");
            Console.WriteLine(nivel1);
            Console.WriteLine(nivel2);
            Console.WriteLine(nivel3);
            Console.WriteLine(nivel4);
            Console.WriteLine(nivel5);
            Console.WriteLine(nivel6);
            Console.WriteLine("-------------------------");
        }
    }
}    

