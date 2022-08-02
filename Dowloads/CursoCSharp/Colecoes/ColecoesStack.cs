using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();
            pilha.Push("a");
            pilha.Push(false);
            pilha.Push(3.15f);
            pilha.Push(true);
            Console.WriteLine(pilha.Peek());
            foreach(var lista in pilha)
            {
                Console.WriteLine(lista);
            }
        }
    }
}
