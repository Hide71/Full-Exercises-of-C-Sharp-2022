using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var diretorioCurso = @"~/source/repos/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(diretorioCurso);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.Parent.Parent);
            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Name);
        }
    }
}
