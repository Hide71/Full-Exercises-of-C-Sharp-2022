using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double x)
        {
            if(x > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= x;
        }
    }

    internal class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);
            try
            {
               // int.Parse("abc");
                conta.Sacar(1000);
                Console.WriteLine("Saldo retirado com sucesso!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigdo!!");
            }
        }
    }
}
