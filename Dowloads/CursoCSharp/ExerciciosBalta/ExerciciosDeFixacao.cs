using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    public static  class ExtensaoArquivo
    {
        public static string ParseH(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.
                Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("Home") :
                    Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }

    }
    public class ExerciciosDeFixacao
    {
        public static void Executar()
        {
            string path = @"~/pasta_numero1.txt".ParseH();
            if (!File.Exists(path))
            {
                using (StreamWriter escrever = File.CreateText(path))
                {
                    escrever.WriteLine("Olá");
                    escrever.WriteLine("Mundo");
                    escrever.WriteLine("Hello");
                    escrever.WriteLine("World");
                    escrever.WriteLine("1,2,3...Testando");

                }

            }
            using (StreamWriter escrever = File.AppendText(path))
            {
                escrever.WriteLine("Adicionando mais palavras");
                escrever.WriteLine("para fazer o teste");
                escrever.WriteLine("e ver se ta ");
                escrever.WriteLine("funconando perfeitamente");
            }
            string texto = "Segundo teste na pasta 2 para saber se foi criada";
            path = @"~/nova_pasta2.txt".ParseH();
            if (!File.Exists(path))
            {
                using(StreamWriter arquivo = new StreamWriter(path))
                {
                    arquivo.WriteLine(texto);
                    arquivo.WriteLine("Hideraldo");
                }
            }
            using (StreamWriter arquivo = File.AppendText(path))
            {
                arquivo.WriteLine("Adicionais");
                arquivo.WriteLine("Mais mais");
                arquivo.WriteLine("Adicionais");
            }
            using(StreamReader arquivo = new StreamReader(path))
            {
                var tex = arquivo.ReadToEnd();
                Console.WriteLine(tex);
            }

        }
    }
}
