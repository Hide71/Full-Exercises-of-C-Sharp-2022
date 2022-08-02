using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
     //public class Carro
     //{
     //   public string Marca;
     //   public string Modelo;
     //   public int Ano;
     //   public Carro(string marca, string modelo, int ano)
     //   {
     //       Marca = marca;
     //       Modelo = modelo;
     //       Ano = ano;
     //   }
     //   public Carro()
     //   {

     //   }
     //}
     public class Calculadora
     {
        public double Soma(double a, double b)
        {
            return a + b;
        }
        public double Subtracao(double a, double b)
        {
            return a - b;
        }
        public double Divisao(double a, double b)
        {
            return a / b;
        }
        public double Multiplicacao(double a, double b)
        {
            return a * b;
        }
     }
     internal class Comentarios
     {
        /// <summary>
        /// 
        /// </summary>
        public static void Executar()
        {
            //Evite comentários desnecessários
            Console.WriteLine("Codigo claro é sempre melhor");
            Console.WriteLine("O C# tem o XML Comments ");
            /*Esse é um comentário
             * de multiplas linhas
             */
            Console.Clear();
            //Carro carro1 = new ();
            //carro1.Marca = "Volkswaggen";
            //carro1.Modelo = "Voyage";
            //carro1.Ano = 1986;
            //Console.WriteLine($"{carro1.Marca} { carro1.Modelo} { carro1.Ano}");
            //Carro carro2 = new Carro("Fiat","Palio EDX", 1996); 
            //Console.WriteLine($"{carro2.Marca} { carro2.Modelo} { carro2.Ano}");
            //Carro carro3 = new Carro()
            //{
            //    Modelo = "Onix",
            //    Marca = "Chevrolet",
            //    Ano = 2004

            //};
            //Console.WriteLine($"{carro3.Marca} {carro3.Modelo} {carro3.Ano}");
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Soma(2, 5));
            
            
        }
        
     }
}
