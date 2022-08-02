using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            string path = @"~/lendo_arquivos.txt".ParseHome();
            if (!File.Exists(path))
            {
                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Qdade;");
                    sw.WriteLine("Caneta;5.6;12;");
                    sw.WriteLine("lapis;3.25;5;");
                    sw.WriteLine("Borracha;1.60;7;");
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
