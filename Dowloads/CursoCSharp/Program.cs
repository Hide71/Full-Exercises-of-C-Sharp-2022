using System;
using System.Collections.Generic;
using CursoCSharp.ExerciciosBalta;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Exercicios Balta.io
                {"Youtube para Mp3 - Exercicios Balta.io", MyProcess.Executar},
                {"Exercicio de fixação - Exercicios Balta.io", ExerciciosDeFixacao.Executar},
                {"Polimorfismo2 - Exercicios Balta.io", ExerciciosBalta.Polimorf.Executar},
                {"Encapsulamento2 - Exercicios Balta.io", ExerciciosBalta.Encapsulamento2.Executar},
                {"O O 3 - Exercicios Balta.io", OO3.Executar},
                {"O O 2 - Exercicios Balta.io", OO2.Executar},
                {"Orientação Objeto - Exercicios Balta.io", OrientacaoObjeto1.Executar},
                {"Só Strings - Exercicios Balta.io", SoStrings.Executar},
                {"Exercicios 22/06/2022- Exercicios Balta.io", Exercicios22062022.Executar},
                {"Params2 - Exercicios Balta.io", Params2.Executar},
                {"Cadeias - Exercicios Balta.io", Cadeias.Executar},
                {"Calculadora2 - Exercicios Balta.io", Calculadora2.Executar},
                {"Calculator - Exercicios Balta.io", Calculator.Executar},
                {"Cronômetro - Exercicios Balta.io", Cronometro.Executar},
                {"Editor de Texto - Exercicios Balta.io", EditorDeTexto.Executar},
                {"Editor HTML - Exercicios Balta.io", EditorHtml.Executar},
                {"Data - Exercicios Balta.io", Data.Executar},
                {"Usando Moedas - Exercicios Balta.io", UsandoMoedas.Executar},
                {"Arrays - Exercicios Balta.io", UsandoArrays.Executar},
                {"Exceções - Exercicios Balta.io", Excecoess.Executar},
                {"Exercicios - Exercicios Balta.io", ExerciciosA.Executar},
                {"Exercicios dia 2 - Exercicios Balta.io", ExerciciosB.Executar},
                {"Exercicios dia 4 - Exercicios Balta.io", ExerciciosC.Executar},
                {"Exercicios dia 5 - Exercicios Balta.io", ExerciciosD.Executar},
                
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                // Estruturas de Controle;

                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else iF - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                {"Estrutura Break - Estruturas de Controle", EstruturaBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                
                
                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Métodos", MetodoComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"ReadOnly - Classes e Métodos", ReadOnly.Executar},
                {"Generos - Classes e Métodos", ExemploGenero.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"Lista - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", ExemploIgualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções",ExemploLambda.Executar},
                {"Lambda com Delegate - Metodos e Funções",LambdaComDelegate.Executar},
                {"Usando Delegate - Metodos e Funções",UsandoDelegate.Executar},
                {"Delegate com Função Anonima - Metodos e Funções",DelegateFuncAnonima.Executar},
                {"Delegate como Parametro - Metodos e Funções",DelegateComoParametro.Executar},
                {"Metodo de Extensão - Metodos e Funções",MetodosDeExtencao.Executar},
                
                // Exceções
                {"Primeira Exceção - Exceções",PrimeiraExcecao.Executar},
                {"Exceção Personalizada - Exceções",ExcecaoPersonalizada.Executar},

                //Explorando API
                {"Primeiro Arquivo - Explorando API",PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Explorando API",LendoArquivos.Executar},
                {"Exemplo FileInfo - Explorando API",ExemploFileInfo.Executar},
                {"Diretorios - Explorando API",Diretorios.Executar},
                {"Exemplo Diretory.Info - Explorando API",ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Explorando API",ExemploPath.Executar},
                {"Exemplo DateTime - Explorando API",ExemploDateTime.Executar},
                {"Exemplo TimeSpam - Explorando API",ExemploTimeSpam.Executar},
                {"LINQ1 - Tópicos Avançados",Linq1.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}