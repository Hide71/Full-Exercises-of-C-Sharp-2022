using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            bool fezServico1 = false;
            bool fezServico2 = false;
            bool comprouTv50 = fezServico1 && fezServico2;
            bool comprouSorvete = fezServico1 || fezServico2;
            bool comprouTv29 = fezServico1 ^ fezServico2;
            bool maisSaudavel = !comprouSorvete;
            Console.WriteLine("Comprou tv de 50?`{0}", comprouTv50);
            Console.WriteLine("Comprou tv de 29? {0}", comprouTv29);
            Console.WriteLine("Fez os dois serviços? {0}", fezServico1 && fezServico2);
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);
            Console.WriteLine("É mais saudavel? {0}" , maisSaudavel);
        }
    }
}
