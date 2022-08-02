using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um Instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo Projeto(Assembly)
        internal ulong NumeroCelular = 5521992906784;

        //Herança ou Mesmo Projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias!";

        //Mesma Classe ou Herança no mesmo projeto
        private protected string SegredoFamilia = "Bla bla ";

        //Private é o Padrão
        bool UsaMuitoFotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoFotoshop);
        }

    }
}
