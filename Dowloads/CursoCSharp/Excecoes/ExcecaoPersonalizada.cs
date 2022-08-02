using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class NegativoEx : Exception
    {
        public NegativoEx() { }
        public NegativoEx(string message) : base(message) { }
        public NegativoEx(string message, Exception inner):base(message, inner) { }
    }
    public class ImparEx: Exception
    {
        public ImparEx(string message): base(message) { }
    }
    internal class ExcecaoPersonalizada
    {
        public static int PositivoPar()
        {

            Random par = new Random();
            {
                int valor = par.Next(-30, 30);
                if (valor < 0)
                {
                    throw new NegativoEx("Numero Negativo!!");
                }
                if (valor % 2 == 1)
                {
                    throw new ImparEx("Numero Impar!!!");
                }
                return valor;
            }

        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());

            }
            catch(NegativoEx ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ImparEx ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }

        }
    }
}
