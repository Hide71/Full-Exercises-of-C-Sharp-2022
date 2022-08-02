using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class EditorDeTexto
    {
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma Opção: ");
            Console.WriteLine("-------------------");
            Console.WriteLine("[1]- Abrir Arquivo");
            Console.WriteLine("[2]- Criar novo Arquivo");
            Console.WriteLine("[3]- Sair");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1: Abrir(); break;
                case 2: Editar();break;
                case 3: Environment.Exit(0);break;
                default: Menu(); break;
            }
        }
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Caminho do arquivo ");
            var caminho = Console.ReadLine();
            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }
        }
        static void Editar()
        {

            Console.WriteLine("Digite seu texto abaixo (Utilize ESC para sair): ");
            Console.WriteLine("--------------------------------");
            string texto = "";
            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(texto);

        }
        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Salvar o arquivo em: ");
            var caminho = Console.ReadLine();
            using (var arquivo = new StreamWriter(caminho)) 
            {
                arquivo.Write(texto);
            }
                Console.WriteLine($"Arquivo  {caminho} salvo com sucesso");
            Console.ReadLine();
            Menu();
        }
        public static void Executar()
        {
            Menu();
        }
    }
}
