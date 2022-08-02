using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "José";
            alunos[1] = "Marcia";
            alunos[2] = "Angela";
            alunos[3] = "Simone";
            alunos[4] = "Priscila";
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            double somatorio = 0;
            foreach (var nota in notas)
            {
                somatorio += nota;
            
            }
            var media = somatorio / notas.Length;
            Console.WriteLine(media);
            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
