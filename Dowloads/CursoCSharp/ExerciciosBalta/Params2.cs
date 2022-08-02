using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    public class Registro
    {
        public string Nome;
        public DateTime Nascimento;

        public Registro(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public Registro()
        {

        }
        public string Formatado()
        {
            //return string.Format("{0:dd * MM * yyyy}", Nascimento);
            return Nascimento.ToString("D");
        }
    }
    internal class Params2
    {
        //    public void Recepcionar(params string[] pessoas)
        //    {
        //        foreach (var pessoa in pessoas)
        //        {
        //            Console.WriteLine($"Olá {pessoa}!, Muito prazer.");
        //        }
        //    }
        public static void Executar()
        {
            //        Params2 recep = new();
            //        recep.Recepcionar("Carlos", "Manuel", "Joaquim");

            Registro registro = new Registro("José", new DateTime(1971, 12, 15));
            Console.WriteLine(registro.Nome);
            Console.WriteLine(registro.Nascimento);
            registro.Nascimento = new DateTime(1910, 6, 12);

            Console.WriteLine(registro.Nome);
            Console.WriteLine(registro.Nascimento);

            Registro registro2 = new Registro("Maria", new DateTime(1900, 1, 25));
            Console.WriteLine(registro2.Nome);
            Console.WriteLine(registro2.Nascimento);
            Console.WriteLine(registro2.Formatado());
        }

    }       
}
