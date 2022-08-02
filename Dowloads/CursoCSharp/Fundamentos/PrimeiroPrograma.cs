using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class Individuo
    {
        public string Nome;
        public int Idade;
        public int Nascimento;

        public string Apresentacao()
        {
            return string.Format($"Olá!, Me chamo {Nome},tenho {Idade} anos , e nasci em {Nascimento}.");
        }
        public void Noconsole()
        {
            Console.WriteLine(Apresentacao());
        }
        public void Zerar()
        {
            Nome = null;
            Idade = 0;
            Nascimento = 0;
        }
    }
    internal class PrimeiroPrograma
    {
        //public static string Convertendo(string frase)
        //{
        //    return frase.ToLower();
        //}

        //public static bool Ret20 (int a, int b)
        //{
        //    return a + b == 20 || a == 20 || b == 20;
        //}
        //public static void Diferenca(int a, int b)
        //{
        //    Console.WriteLine( a > b ? (a - b) * 2 : a - b);
        //}

        //public static int Triplo(int a, int b)
        //{
        //    return a == b ? (a + b) * 3 : a + b;
        //}

        //public static string Remover(string a, int b)
        //{
        //    return a.Remove(b, 1);
        //}
        public static void Executar()
        {
            //Console.Write("Primeiro ");
            //Console.WriteLine("Programa");
            //Console.WriteLine("Terminou!");

            //Console.WriteLine("Olá: ");
            //Console.WriteLine("Hideraldo Rodrigues Marciano");
            //Console.Write("Digite um valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("A soma entre {0} e {1} é: {2}",valor1, valor2, valor1 + valor2);
            //Console.Write("Digite um valor: ");
            //int divisor = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int dividendo = int.Parse(Console.ReadLine());
            //int resultado = divisor / dividendo;
            //Console.WriteLine("A divisão entre os numeros {0} e {1} é {2}", divisor, dividendo, resultado);
            //Console.WriteLine("Testar dados: ");
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 + -4 * 6 / 11);
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Trocando o numero 1 pelo numero 2: ");
            //Console.WriteLine("------------------------------------");
            //int troca = 0;
            //Console.Write("Digite um numero: ");
            //int numero1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro numero: ");
            //int numero2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Depois da troca: ");
            //troca = numero1;
            //numero1 = numero2;
            //numero2 = troca;
            //Console.WriteLine(numero1);
            //Console.WriteLine(numero2);
            Console.Clear();
            //Console.WriteLine("Insira o primeiro numero a multiplicar: ");
            //int primeiro = int.Parse(Console.ReadLine());
            //Console.WriteLine("Insira o segundo numero a multiplicar: ");
            //int segundo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o ultimo numero a multiplicar: ");
            //int ultimo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Resultado: ");
            //Console.WriteLine(primeiro * segundo * ultimo);
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Valores das variáveis e constantes");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(byte.MaxValue);
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(sbyte.MaxValue);
            //Console.WriteLine(sbyte.MinValue);
            //Console.WriteLine(short.MaxValue);
            //Console.WriteLine(short.MinValue);
            //Console.WriteLine(uint.MaxValue);
            //Console.WriteLine(uint.MinValue);
            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(ulong.MaxValue);
            //Console.WriteLine(ulong.MinValue);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(decimal.MinValue);
            //const double pi = 3.14;
            //pi = 3.15;
            //Console.WriteLine(pi);
            //Console.WriteLine($"5 + 4 = {5 + 4}");
            //Console.Write("Digite um valor: ");
            //int valor1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int valor2 = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("----------");
            //Console.WriteLine("Resultado");
            //Console.WriteLine("----------");
            //Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            //Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
            //Console.WriteLine($"{valor1} x {valor2} = {valor1 * valor2}");
            //Console.WriteLine($"{valor1} : {valor2} = {valor1 / valor2}");
            //Console.WriteLine($"{valor1} : {valor2} resto = {valor1 % valor2}");
            //Console.WriteLine("--------------------");
            //Console.WriteLine(" Criador de Tabuada ");
            //Console.WriteLine("--------------------");
            //Console.Write("Digite a tabuada: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} X 0 = {1}",numero, numero * 0 );
            //Console.WriteLine("{0} X 1 = {1}",numero, numero * 1 );
            //Console.WriteLine("{0} X 2 = {1}",numero, numero * 2 );
            //Console.WriteLine("{0} X 3 = {1}",numero, numero * 3 );
            //Console.WriteLine("{0} X 4 = {1}",numero, numero * 4 );
            //Console.WriteLine("{0} X 5 = {1}",numero, numero * 5 );
            //Console.WriteLine("{0} X 6 = {1}",numero, numero * 6 );
            //Console.WriteLine("{0} X 7 = {1}",numero, numero * 7 );
            //Console.WriteLine("{0} X 8 = {1}",numero, numero * 8 );
            //Console.WriteLine("{0} X 9 = {1}",numero, numero * 9 );
            //Console.WriteLine("{0} X 10 = {1}",numero, numero * 10 );
            //double numero1, numero2, numero3, numero4;
            //Console.Write("Digite o primeiro numero: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Digite o terceiro numero: ");
            //numero3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Digite o ultimo numero: ");
            //numero4 = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //double media = (numero1 + numero2 + numero3 + numero4) / 4;
            //Console.WriteLine("A media entre os numeros {0}, {1}, {2} e {3} é: {4}", numero1, numero2
            //    , numero3, numero4, media);
            //Console.Write("Digite um valor: ");
            //string valor = Console.ReadLine();
            //int valorNumerico = int.Parse(valor);
            //Console.WriteLine(valorNumerico.ToString("P"));
            //CultureInfo dollar = new CultureInfo("en-US");
            //Console.WriteLine(valorNumerico.ToString("C2", dollar));
            //Console.Write("Digite um numero: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite mais um numero: ");
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($" ({x} + {y}) x {z} é {(x+y)*z} e {x} x {y} + {y} x {z} é {x*y + y * z}");
            //Console.Write("Digite sua idade: ");
            //int idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Você parece ter mais de " + idade + " anos!");
            //Console.Write("Digite um valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{valor} {valor} {valor} {valor}");
            //Console.WriteLine($"{valor}{valor}{valor}");
            //Console.WriteLine($"{valor} {valor} {valor} {valor}");
            //Console.WriteLine($"{valor}{valor}{valor}");
            //Console.Write("Digite um numero: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}{0}{0}", x);
            //Console.WriteLine("{0}  {0}", x);
            //Console.WriteLine("{0}  {0}", x);
            //Console.WriteLine("{0}  {0}", x);
            //Console.WriteLine("{0}{0}{0}", x);
            //Console.WriteLine(Remover("W3Resource", 1));
            //Console.WriteLine(Remover("W3Resource", 9));
            //Console.WriteLine(Remover("W3Resource", 0));
            //Console.WriteLine("hideraldo".Remove(1,1));
            //Console.WriteLine("hideraldo".Substring(4));
            //string nome = "Python";
            //Console.WriteLine(nome.Substring(nome.Length -1) + nome.Substring(1, nome.Length -2) + 
            //    nome.Substring(0, 1));
            //Console.WriteLine("Digite uma palavra qualquer: ");
            //string palavra = Console.ReadLine();
            //if (palavra == "avestruz")
            //    Console.WriteLine("Você digitou {0}", palavra);
            //else
            //    Console.WriteLine("Tente acertar");
            //Console.WriteLine("Digite uma frase: ");
            //string frase = Console.ReadLine();
            //int p = frase.Length -1 ;
            //int q = frase.Length -1;
            //string r = frase.Substring(p - q, 1);
            //if (frase.Length >= 1)
            //    Console.WriteLine( r +  frase + r);
            //else
            //    Console.WriteLine(frase);
            //Console.Write("Digite um numero: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite outro numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //if(numero1 <0 && numero2 >=0)
            //    Console.WriteLine("Certo");
            //else
            //    if(numero1>=0 && numero2<0)
            //    Console.WriteLine("Certo");
            //else
            //    Console.WriteLine("Errado");
            //Console.WriteLine((numero1 >= 0 && numero2< 0) || (numero1 <0 && numero2>= 0));
            //Console.WriteLine("Digite uma nota: ");
            //double nota = double.Parse(Console.ReadLine());
            //double limite = 7.0; 
            //string resultado = nota >= limite ?  "Aprovado" : "Reprovado";
            //Console.WriteLine(resultado);
            //if(nota>= 7)
            //{
            //    Console.WriteLine("Aprovado");
            //    Console.WriteLine("Não fez mais que a obrigação!");
            //}
            //else
            //    Console.WriteLine("Recuperação!");
            //Console.WriteLine("Finalizado!!");
            //Console.Write("Digite uma nota: ");
            //Double.TryParse(Console.ReadLine(), out double nota);
            //if(nota >= 9)
            //{
            //    Console.WriteLine("Honra ao mérito!!");

            //}
            //else
            //    if(nota >= 7)
            //{
            //    Console.WriteLine("Aprovado!!");
            //}
            //else
            //    if(nota >= 5)
            //{
            //    Console.WriteLine("Recuperação!");
            //}
            //else
            //    Console.WriteLine("Te vejo na proxima!!"); 
            //Console.Write("Digite um numero: ");
            //int.TryParse(Console.ReadLine(), out int numero1);
            //Console.Write("Digite outro numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int resultado = numero1 == numero2 ? (numero1 + numero2) * 3 : numero1 + numero2;
            //Console.WriteLine(resultado);
            //Console.WriteLine(Triplo(2, 2));
            //Console.WriteLine(Triplo(5, 4));
            //Console.WriteLine(Triplo(4, 4));
            //Console.WriteLine(Triplo(-3, 4));
            //Console.WriteLine(Triplo(5, 67));
            //Console.WriteLine(Triplo(44, 44));
            //Console.WriteLine(Triplo(15, 4));
            //Console.Clear();
            //Diferenca(6, 5);
            //Diferenca(6, 6);
            //Diferenca(34, 35);
            //Diferenca(5, 44);
            //Diferenca(60, 45);
            //Diferenca(12, 5);
            //Console.WriteLine(Ret20(20, 5));
            //Console.WriteLine(Ret20(10, 20));
            //Console.WriteLine(Ret20(35, 15));
            //Console.WriteLine(Ret20(6, 10));
            //Console.WriteLine(Ret20(10, 10));
            //Console.WriteLine(Convertendo("O RATO ROEU A ROUPA DO REI DE ROMA"));
            //Console.WriteLine(Convertendo("MAIS VALE UM PÁSSARO NA MÃO DO QUE DOIS VOANDO"));
            //Console.WriteLine(Convertendo("QUEM COM FERRO FERE, COM FERRO SERÁ FERIDO"));
            //Console.WriteLine(Convertendo("AGUA MOLE EM PEDRA DURA, TANTO BATE ATÉ QUE FURA"));
            //Console.Write("Atribua uma nota de acordo com o atendimento: ");
            //int valor = int.Parse(Console.ReadLine());
            //switch (valor)
            //{
            //    case 0:
            //        Console.WriteLine("Péssimo");
            //        break;
            //    case 1:
            //        Console.WriteLine("Ruim");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Bom");
            //        break;
            //    case 4:
            //        Console.WriteLine("Otimo");
            //        break;
            //    case 5:
            //        Console.WriteLine("Exelente");
            //        Console.WriteLine("Parabéns");
            //        break;
            //    default:
            //        Console.WriteLine("Voce digitou errado!!");
            //        break;
            //}
            //Console.WriteLine("Obrigado pela votação");
            //Random random = new Random();
            //int valorSecreto = random.Next(1, 16);
            //int palpite = 0;
            //bool acertou = false;
            //int tentativasRestantes = 5;
            //int tentativas = 0;
            //while (tentativas < 5  && valorSecreto != palpite)
            //{
            //    Console.Write("Tente acertar o numero de 1 a 15: ");
            //    palpite = Convert.ToInt32(Console.ReadLine());
            //    tentativas++;
            //    tentativasRestantes --;
            //    if(valorSecreto == palpite)
            //    {
            //        acertou = true;
            //        Console.WriteLine($"Parabéns você acertou!Com {tentativas} Tentativas");

            //    }
            //    else if (palpite < valorSecreto)
            //    {
            //        Console.WriteLine("Mais! Tente novamente");
            //        Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Menos! continue tentando");
            //        Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);

            //    }
            //for (int numero = 0; numero <= 99; numero++) 
            //{
            //    if (numero % 2 != 0)
            //    Console.WriteLine(numero);
            //}
            //string frase = "O Amor é uma palavra apenas";
            //string[] palavras = frase.Split();
            ////Console.WriteLine(palavras[0]);
            //int maiorPalavra = 0;
            //string palavraMaior = " ";
            //foreach (string palavra in palavras)
            //{
            //    if(palavra.Length >= maiorPalavra)
            //    {
            //        palavraMaior = palavra;
            //        maiorPalavra = palavra.Length;

            //    }
            //}
            //Console.WriteLine(palavraMaior);
            //int x = (int)Math.Floor(Math.Sqrt(9));
            //Console.WriteLine(x);
            //Console.WriteLine("Insira um numero inteiro: ");
            //double numero = Convert.ToDouble(Console.ReadLine());
            //double soma = numero % 10 + (int)numero / 10; 
            //Console.WriteLine(soma);
            //Console.Write("Digite uma frase: ");
            //string frase = Console.ReadLine();
            //string[] novaFrase = frase.Split(" ");
            //for(int i = novaFrase.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(novaFrase[i] + " ");
            //}
            //string valorHexa = "4B0";
            //int valorInt = int.Parse(valorHexa, NumberStyles.HexNumber);
            //Console.WriteLine(valorInt);
            //int[] lista1 = { 1, 5, 12, -5 };
            //int[] lista2 = { 2, 4, 5, - 13 };
            //int max = lista2.Length -1 ;
            //for(int c = 0; c <= max;c ++)
            //{
            //    Console.Write(lista1[c] * lista2[c] + " ");
            //}
            //Console.Write("Digite uma palavra: ");
            //string palavra = Console.ReadLine();
            //if(palavra.Length > 4)


            //    Console.WriteLine(palavra.Length > 4 ?palavra+ palavra+ palavra: palavra.Substring(palavra.Length -4) + " " + palavra.Substring(palavra.Length - 4) + " " + palavra.Substring(palavra.Length - 4) + " " + palavra.Substring(palavra.Length - 4));
            //string entrada;
            //do
            //{
            //    Console.Write("Qual é o seu nome?: ");
            //    entrada = Console.ReadLine();
            //    Console.WriteLine("Muito Prazer, {0}", entrada);
            //    Console.WriteLine("Quer continuar? (S/N): ");
            //    entrada = Console.ReadLine();
            //    Console.Clear();


            //}
            //while (entrada == "s".ToLower());
            //Console.Write("Qual é o tamanho da turma?: ");
            //int.TryParse(Console.ReadLine(), out int alunos);
            //double soma = 0;
            //for(int i = 1;i<= alunos; i++)
            //{
            //    Console.Write($"Qual é a nota do {i} aluno?: ");
            //    double nota = Convert.ToDouble(Console.ReadLine());
            //    soma += nota;

            //}
            //double media = soma > 0 ? soma / alunos : 0 ;
            //Console.WriteLine("A media total da sala é: {0}", media);
            //string palavra = "Olá!";
            //foreach(char letra in palavra)
            //{
            //    Console.Write(letra + " ");
            //}
            //var alunos =  new string[]{"Ana", "Maria", "Joanna", "Marcia"};
            //foreach(string aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}
            //Random sorteioDoPc = new Random();
            //int numeroSorteado = sorteioDoPc.Next(1, 20);
            //Console.WriteLine("O numero sorteado foi: {0}", numeroSorteado);
            //for(int i = 1;i<= 30; i++)
            //{
            //    if(i == numeroSorteado)
            //    {
            //        Console.WriteLine($" O numero sorteado foi {i}?: Sim");
            //        break;
            //    }
            //    Console.WriteLine($"O numero sorteado foi {i}?: Não");
            //}
            //Console.WriteLine("Fim");
            //for(int i = 0;i<= 50; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //int[] alunos = new[]/*{"Maria", "José"};*/{ 1, 2, 3, 4 };
            //foreach(var aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}
            //Console.Write("Digite um valor positivo: ");
            //int.TryParse(Console.ReadLine(), out int valor);
            //Console.WriteLine(valor % 3 == 0 || valor % 7 == 0);
            //Console.Write("Digite um valor: ");
            //int valor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int valor2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(valor < 100 && valor2 > 200); 
            //Console.Write("Digite um numero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite outro numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(((numero <=10 && numero >= -10)) || ((numero2 <=10 && numero2 >= -10)));
            //string palavra = "PHP Tutorial";
            //string letras = palavra.Substring(1, 2);
            //if(letras == "HP")
            //{
            //    Console.WriteLine(palavra.Remove(1,2));
            //}
            //string palavraNova = "";
            //string palavra = "PHP teste";
            //if(palavra.Length >= 1 && palavra[0] == 'P')
            //{
            //    palavraNova += palavra[0]; 
            //}
            //if(palavra.Length >=2 && palavra[1] == 'H')
            //{
            //    palavraNova += palavra[1];
            //}
            //Console.WriteLine(palavraNova);
            //Console.Write("Digite um valor: ");
            //int valor1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int valor2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite o ultimo valor: ");
            //int valor3 = Convert.ToInt32(Console.ReadLine());
            //int maximo = Math.Max(valor1,Math.Max(valor2, valor3));
            Individuo fulano = new Individuo();
            fulano.Nome = "José";
            fulano.Idade = 18;
            fulano.Nascimento = 2004;
            Console.WriteLine($"{fulano.Nome} {fulano.Idade} {fulano.Nascimento}");
            Console.WriteLine(fulano.Apresentacao());
            var sicrano = new Individuo();
            sicrano.Nome = "Carlos";
            sicrano.Idade = 51;
            sicrano.Nascimento = 1971;
            sicrano.Noconsole();
            sicrano.Zerar();
            sicrano.Noconsole();
        }
    }
}
