using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Televisao
    {
        public  int VolumeMaximo { get; set;}
        int VolumeInicial;

        public Televisao(int volumeMaximo)
        {
            VolumeMaximo = volumeMaximo;
        }
        protected int AlterarVolume(int a)
        {
            VolumeMaximo = 8;
            int novoVolume = VolumeInicial + a;
            if (novoVolume < 0)
            {
                VolumeInicial = 0;
            }
            else if (novoVolume > VolumeMaximo)
            {
                novoVolume = VolumeMaximo;
            }
            else
            {
                VolumeInicial = novoVolume;
            }    
                return VolumeInicial;
        }
        public virtual int AumentarVolume()
        {
            return AlterarVolume(1);
        }
        public int DiminuirVolume()
        {
            return AlterarVolume(-1);
        }
    }
    internal class Toshiba :Televisao
    {
        internal Toshiba(): base(20)
        {

        }
    }
    internal class Samsung : Televisao
    {
        public Samsung() : base(15)
        {

        }
        public override int AumentarVolume()
        {
            return AlterarVolume(2);
        }
    }
    public class OrientacaoObjeto1
    {
        public static void Executar()
        {
            Toshiba tv1 = new Toshiba();
            Samsung tv2 = new();
            Console.WriteLine(tv1.AumentarVolume());
            Console.WriteLine(tv1.AumentarVolume());
            Console.WriteLine(tv1.AumentarVolume());
            Console.WriteLine(tv1.AumentarVolume());
            Console.WriteLine(tv1.DiminuirVolume());
            Console.WriteLine(tv1.DiminuirVolume());
            Console.WriteLine(tv1.DiminuirVolume());
            Console.WriteLine(tv1.DiminuirVolume());
            Console.WriteLine(tv1.DiminuirVolume());
            Console.WriteLine(tv1.VolumeMaximo);

            Console.WriteLine(tv2.AumentarVolume());
            Console.WriteLine(tv2.AumentarVolume());
            Console.WriteLine(tv2.AumentarVolume());
            Console.WriteLine(tv2.AumentarVolume());
            Console.WriteLine(tv2.DiminuirVolume());
            Console.WriteLine(tv2.DiminuirVolume());
            Console.WriteLine(tv2.DiminuirVolume());
            Console.WriteLine(tv2.DiminuirVolume());
            Console.WriteLine(tv2.DiminuirVolume());
            Console.WriteLine(tv2.VolumeMaximo);
        }
    }
}
