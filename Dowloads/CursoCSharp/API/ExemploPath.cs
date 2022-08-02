using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploPath
    {
        public static void Executar()
        {
            var novoArq = @"~/novo_arquivo.txt".ParseHome();
            var novaPasta = @"~/nova_pasta".ParseHome();
            if (!File.Exists(novoArq))
            {
                using (StreamWriter arquivo = File.CreateText(novoArq))
                {
                    arquivo.WriteLine("Arquivo criado");

                }

            }
            if (!Directory.Exists(novaPasta))
            {
                Directory.CreateDirectory(novaPasta);
            }
            Console.WriteLine("Arquivos ");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Path.GetExtension(novoArq));
            Console.WriteLine(Path.GetFileNameWithoutExtension(novoArq));
            Console.WriteLine(Path.GetFileName(novoArq));
            Console.WriteLine(Path.GetPathRoot(novoArq));
            Console.WriteLine(Path.GetDirectoryName(novoArq));

            Console.WriteLine("Pastas");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Path.GetExtension(novaPasta));
            Console.WriteLine(Path.GetFileNameWithoutExtension(novaPasta));
            Console.WriteLine(Path.GetFileName(novaPasta));
            Console.WriteLine(Path.GetPathRoot(novaPasta));
            Console.WriteLine(Path.GetDirectoryName(novaPasta));
        }
    }
}
