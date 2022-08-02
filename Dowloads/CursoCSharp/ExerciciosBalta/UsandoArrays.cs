using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExerciciosBalta
{
    internal class UsandoArrays
    {
        struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        

        public static void Executar()
        {
            int[] numeros = new int[] { 65, 12, 26, 99, 55 };
            numeros[0] = 24;
            //Console.WriteLine(numeros[0]);
            //Console.WriteLine(numeros[1]);
            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(numeros[3]);
            foreach(var itens in numeros)
                Console.WriteLine(itens);

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2345, Nome = "José" };
            funcionarios[1] = new Funcionario() { Id = 2424, Nome = "Maria" };
            funcionarios[2] = new Funcionario() { Id = 2121, Nome = "Carlos" };
            funcionarios[3] = new Funcionario() { Id = 0007, Nome = "James" };
            funcionarios[4] = new Funcionario() { Id = 2346, Nome = "Olivia" };

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }




        }
    }
}
