namespace CursoCSharp.ExerciciosBalta
{
    internal class ExerciciosC
    {
        public static Action<int> NomeEx = ExerciciosA.Cabecalho;
        public static void Executar()
        {
            Console.Clear();

            //NomeEx(29);
            //FileInfo a = new FileInfo("C:/Users/UNIVESP-22/Desktop/arquivo teste/teste.txt");
            //Console.WriteLine("O tamanho do arquivo é: {0} bytes",a.Length.ToString());


            //NomeEx(30);
            //string numeroHexadecimal = "4B0";
            //int convertParaDecimal = int.Parse(numeroHexadecimal, NumberStyles.HexNumber);
            //Console.WriteLine("Converter o numero Hexadecimal {0} em Decimal temos: {1} ",
            //    numeroHexadecimal, convertParaDecimal);

            //NomeEx(31);
            //int[] primeiroArray = { 3, 4, 7, -8, -6 };
            //int[] segundoArray = { 7, 5, 2, -6, 10 };
            //Console.WriteLine("Array 1: [{0}]", string.Join(",",primeiroArray));
            //Console.WriteLine("Array 2: [{0}]", string.Join(",", segundoArray));
            //for(int i = 0; i <= primeiroArray.Length - 1; i++)
            //{
            //    Console.WriteLine(primeiroArray[i] * segundoArray[i]);
            //}

            //NomeEx(32);
            //Console.WriteLine("Escreva qualquer coisa: ");
            //string palavras = Console.ReadLine();
            ////string novaPalavra = " ";

            ////for (int i = palavras.Length - 4; i <= palavras.Length - 1; i++)
            ////{
            ////    novaPalavra += palavras[i];

            ////}
            ////Console.WriteLine($"{novaPalavra}.{novaPalavra}.{novaPalavra}.{novaPalavra}");
            //if(palavras.Length > 4)
            //{
            //    Console.WriteLine(palavras.Length < 4? palavras + palavras + palavras + palavras :
            //        palavras.Substring(palavras.Length -4) + palavras.Substring(palavras.Length - 4)
            //        + palavras.Substring(palavras.Length - 4)+ palavras.Substring(palavras.Length - 4));
            //}

            //NomeEx(33);
            //Console.WriteLine("Digite um numero");
            //int.TryParse(Console.ReadLine(), out int numero);
            //if (numero > 0)
            //    Console.WriteLine(numero % 3 == 0 || numero % 7 == 0);
            //else
            //    Console.WriteLine("Valor inválido");

            //NomeEx(34);
            //Console.WriteLine("Digite uma frase: ");
            //string frase = Console.ReadLine();
            // string resultado = "Ola ".ToLower();

            //Console.WriteLine(frase.Substring(0, 4) == resultado);

            //NomeEx(35);
            //Console.Write("Informe um numero (< 100): ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Informe o segundo numero (> 200): ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numero1 < 100 && numero2 > 200);


            //NomeEx(36);
            //Console.WriteLine("Informe um valor : ");
            //int valor1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Informe um segundo valor: ");
            //int valor2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(((valor1 >= -10 && valor1 <= 10)) || ((valor2 >= -10 && valor2 <= 10)));


            //NomeEx(37);
            //string nome = "PHP Tutorial";
            //Console.WriteLine(nome.Substring(1, 2).Equals("HP") ? nome.Remove(1, 2) : nome);

            //NomeEx(38);

            //string frase = "PHP tutorial";
            //string resultado = "";
            //if(frase.Length >= 1 && frase[0] == 'P')
            //{
            //    resultado += frase[0];
            //}
            //if (frase.Length >= 2 && frase[1] == 'H')
            //{
            //    resultado += frase[1];
            //}
            //Console.WriteLine(resultado);

            //NomeEx(39);
            //Console.WriteLine("Digite um numero: ");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite outro numero: ");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite mais um numero: ");
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero1, numero3);
            //else
            //    if (numero1 > numero2 && numero1 > numero3 && numero3 > numero2)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero1, numero2);
            //else
            //    if (numero2 > numero1 && numero2 > numero3 && numero1 > numero3)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero2, numero3);
            //else
            //    if (numero2 > numero1 && numero2 > numero3 && numero1 > numero3)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero2, numero3);
            //else
            //    if (numero2 > numero1 && numero2 > numero3 && numero3 > numero1)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero2, numero1);
            //else
            //    if (numero3 > numero1 && numero3 > numero2 && numero2 > numero1)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero3, numero1);
            //else
            //    if (numero3 > numero1 && numero3 > numero2 && numero1 > numero2)
            //    Console.WriteLine("Maior: {0}\nMenor {1}", numero3, numero2);

            //Console.WriteLine("Maior de três: " + Math.Max(numero1, Math.Max(numero2, numero3)));
            //Console.WriteLine("Menor de três: " + Math.Min(numero1, Math.Min(numero2, numero3)));

            //NomeEx(40);
            //Console.WriteLine("Digite um valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite outro valor: ");
            //int valor2 = int.Parse(Console.ReadLine());
            //int nulo = 0;
            //if(valor1 > valor2 && valor1 <=20)
            //    Console.WriteLine(valor1);
            //else
            //    if(valor2 > valor1 && valor2 <= 20)
            //    Console.WriteLine(valor2);
            //else
            //    if(valor1 == valor2)
            //    Console.WriteLine(nulo);
            //else
            //    if (valor1 >20)
            //    Console.WriteLine(valor2);
            //else
            //    if (valor2 >20)
            //    Console.WriteLine(valor1);
            //int x = Math.Abs(valor1 - 20);
            //int y = Math.Abs(valor2 - 20);
            //Console.WriteLine(valor1 == valor2 ? 0 : (x < y? valor1: valor2));

            //NomeEx(41);
            //string frase = "wild world web".ToLower();
            //int a = frase.Count(b => b == 'w');
            //Console.WriteLine(a >=1 && a <= 3);

            //string nome = "hideraldo rodrigues marciano";
            //int z = nome.Count(s => s == 'o');
            //Console.WriteLine(z);
            //NomeEx(42);
            //Console.WriteLine("Escreva uma string: ");
            //string palavra = Console.ReadLine();
            //if (palavra.Length <= 3)
            //    Console.WriteLine(palavra.ToUpper());

            //if (palavra.Length > 3)
            //{
            //    Console.WriteLine(palavra.Substring(0, 3).ToLower() + palavra.Substring(3).ToUpper());
            //}
            int palpite = 0;
            Random random = new Random();
            int valorSecreto = random.Next(1, 16);
            bool acertou = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            while (tentativasRestantes > 0 && !acertou)
            {
                Console.Write("Tente acertar o numero de 1 a 15: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;
                tentativasRestantes--;
                if (valorSecreto == palpite)
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns você acertou!Com {tentativas} Tentativas");

                }
                else
                    if (valorSecreto < palpite)
                {
                    Console.WriteLine("Menor! Você ainda tem {} tentativas", tentativasRestantes);
                }
                else
                    Console.WriteLine("Maior! Você ainda tem {} tentativas", tentativasRestantes);

            }

        }
    }
}
