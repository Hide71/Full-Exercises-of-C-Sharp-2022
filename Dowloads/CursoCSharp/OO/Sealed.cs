using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaHeranca()
        {
            return 1_234_567_890.00;
        }
    }
    //class SouFilho : SemFilho
    //{

    //}
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class Pai: Avo
    {
        public override sealed bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde: Pai
    {
    //    public override bool HonrarNomeFamilia()
    //    {
    //        return true;
    //    }
    }
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho filho =  new SemFilho();
            Console.WriteLine(filho.ValorDaHeranca());
            FilhoRebelde filho2 = new FilhoRebelde();
            Console.WriteLine(filho2.HonrarNomeFamilia());
        }
    }
}
