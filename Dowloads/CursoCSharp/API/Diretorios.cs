using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var moverDir = @"~/PastaCSharpDestino".ParseHome();
            var meuDir = @"~/source/repos/cursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(moverDir))
            {
                Directory.Delete(moverDir, true);
            }

            Console.WriteLine("Pastas");
            Console.WriteLine("---------------");
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            var pastas = Directory.GetDirectories(meuDir);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("Arquivos");
            Console.WriteLine("--------------------");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            var arquivos = Directory.GetFiles(meuDir);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("RAIZ");
            Console.WriteLine("-----------------------");
            var raiz = Directory.GetDirectoryRoot(meuDir);
            Console.WriteLine(raiz);
            Console.ResetColor();

            Directory.Move(novoDir, moverDir);
        }

    }
}
