using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Soma(double a, double b);
    delegate void Imprimir(double x, double y);
    internal class UsandoDelegate
    {

        static double MinhaSoma(double a, double b) => (a + b);
        static void MeuImprimir(double w, double e) => Console.WriteLine(w + e);
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));
            Imprimir op2 = MeuImprimir;
            op2(5.4, 8);
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(6, 7));
            Action<double, double> op4 = MeuImprimir;
            op4(20, 10);

                             
            Console.WriteLine(MinhaSoma(2, 3.9));
            MeuImprimir(5.4, 8);
            
        }
    }
}
