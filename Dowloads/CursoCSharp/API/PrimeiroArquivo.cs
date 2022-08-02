using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CursoCSharp.API
{
    public static class ExtencaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform  == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Funcionou");
                    sw.WriteLine("o meu ");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("Arquivo criado");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("É possivel");
                sw.WriteLine("Adicionnar");
                sw.WriteLine("Mais textos");
            }
        }
    }
}
