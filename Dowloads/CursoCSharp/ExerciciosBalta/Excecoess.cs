using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class Excecoess
    {
        public class MinhaExcessao: Exception
        {
            public MinhaExcessao(DateTime data)
            {
                QuandoAconteceu = data;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
        public static void Salvar(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                //throw new Exception("O texto não pode ser nulo ou vazio");
                throw new MinhaExcessao(DateTime.Now);
            }
        }
        public static void Executar()
        {
            //string[] nomes = new string[] { "Carlos", "Marcos", "José", "Ari", "Antonio", "Marcelo" };
            //try
            //{
            //    for (int c = 0; c <= nomes.Length; c++)
            //    {
            //        Console.WriteLine(nomes[c]);
            //    }

            //}
            //catch(IndexOutOfRangeException erro)
            //{
            //    Console.WriteLine(erro.InnerException);
            //    Console.WriteLine(erro.Message);
            //    Console.WriteLine("Fora do range");
            //}
            //catch(Exception ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Erro!");
            //}
            try
            {
                Salvar("");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não é possivel cadastrar nulo");
            }
            catch (MinhaExcessao ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Excessão customizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("ERRO!");
            }
            finally
            {
                Console.WriteLine("Finalizado!!");
            }
        }  
    }
}
