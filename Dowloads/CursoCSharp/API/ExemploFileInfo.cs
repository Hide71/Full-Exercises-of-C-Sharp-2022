using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(string caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            string arqivoOrigem = @"~/arq_origem.txt".ParseHome();
            string arquivoDestino = @"~/arq_destino.txt".ParseHome();
            string arquivoCopia = @"~/ arq_copia.txt".ParseHome();
            ExcluirSeExistir(arqivoOrigem, arquivoCopia, arquivoDestino);
            using (StreamWriter sw = new StreamWriter(arqivoOrigem))
            {
                sw.WriteLine("Novo arquivo Teste");
            }
            FileInfo origem = new FileInfo(arqivoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.IsReadOnly);
            origem.CopyTo(arquivoCopia);
            origem.MoveTo(arquivoDestino);
            
        }
    }
}
