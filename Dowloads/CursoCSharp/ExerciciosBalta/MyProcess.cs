using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using VideoLibrary;

namespace CursoCSharp.ExerciciosBalta
{
    internal class MyProcess
    {
        public static void Executar()
        {
            var source = @"~/source/repos/".ParseH();
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo("https://www.youtube.com/watch?v=UXNE-POJBGI&list=PLU6OP4VGWDw4at8_b1PbcW6O8EGbXyRg_&index=11");
            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

            MediaFile inputFile = new MediaFile { Filename = source + AudioFormat.Unknown };
            MediaFile outputFile = new MediaFile { Filename = $"{source + AudioFormat.Unknown}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
          Console.WriteLine("Acabou!!!");
        }
    }
}
