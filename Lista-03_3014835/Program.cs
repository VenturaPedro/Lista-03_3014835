using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Lista03
{

    class Lista3
    {
        static void Exercicio1()
        {
            //Crie um programa que define um vetor de tamanho N, faz a leitura dos N números float
            //e apresenta, com base nos números digitados, o menor número, o maior número e a 
            //média aritmética dos números. 

            int ValorVetor;
            float Menor = 0, Maior = 0, Soma = 0;

            Console.WriteLine("Entre com o tamanho do vetor:");
            ValorVetor = int.Parse(Console.ReadLine());

            float ValorVetorFloat = ValorVetor;

            float[] ValorFloat = new float[ValorVetor];

            Console.WriteLine("Seu Vetor tem o tamanho {0} !", ValorVetor);

            for (int i = 0; i <= ValorVetor - 1; i++)
            {
                Console.WriteLine("Entre com o valor em float da Posição {0}:", i);
                float Transferencia = float.Parse(Console.ReadLine());
                ValorFloat[i] = Transferencia;
                Soma = Soma + Transferencia;

                if (Transferencia > Maior)
                {
                    Maior = Transferencia;
                }
            }
            Menor = Maior;
            for (int i = 0; i <= ValorVetor - 1; i++)
            {
                if (ValorFloat[i] < Menor)
                {
                    Menor = ValorFloat[i];
                }
            }
            float MediaAritimetica = Soma / ValorVetorFloat;
            Console.WriteLine("O menor numero em float é {0}", Menor);
            Console.WriteLine("O maior numero em float é {0}", Maior);
            Console.WriteLine("O menor numero em float é {0}", MediaAritimetica);
        }
        static void Exercicio2()
        {

            //Crie um programa que define um vetor de tamanho N, onde N é informado pelo usuário 
            //(você precisa garantir que o valor de N é maior que zero). Em seguida, faça a leitura dos 
            //N números e mostre ao final apenas os números contidos no vetor que são maiores ou 
            //iguais à média de todos os números digitados. 

            int TamanhoVetor = 0;
            float Total = 0;

            Console.WriteLine("Entre com o tamanho do Vetor [Não pode entrar com valores negativou ou zero]:");
            TamanhoVetor = int.Parse(Console.ReadLine());

            int[] Valor = new int[TamanhoVetor];

            if (TamanhoVetor <= 0)
            {
                Console.WriteLine("Numero inserido Menor ou Igual a zero! Por favor entre com um numero correspondente a atividade!");
                Exercicio2();
            }

            for (int i = 0; i <= TamanhoVetor - 1; i++)
            {
                Console.WriteLine("Entre com o valor em da Posição {0}:", i);
                int Transferencia = int.Parse(Console.ReadLine());
                Valor[i] = Transferencia;
                Total += Transferencia;
            }

            float Media = Total / TamanhoVetor;

            Console.Write("Os numeros Maiores que a média [{0}] são: ", Media);
            for (int i = 0; i <= TamanhoVetor - 1; i++)
            {
                if (Media <= Valor[i])
                {
                    Console.Write(Valor[i]);
                }
                Console.Write(" ");

            }
            Console.WriteLine();
        }
        static void Exercicio3()
        {

            // Utilizando o exercício anterior, altere seu programa para que a inclusão dos números seja 
            //feita automaticamente. Pesquise por geração de números aleatórios em C# 

            Random random = new Random();
            int TamanhoVetor = random.Next(0, 100);

            float Total = 0;

            int[] Valor = new int[TamanhoVetor];

            if (TamanhoVetor <= 0)
            {
                Console.WriteLine("Numero inserido Menor ou Igual a zero! Por favor entre com um numero correspondente a atividade!");
                Exercicio3();
            }

            for (int i = 0; i <= TamanhoVetor - 1; i++)
            {
                int Transferencia = random.Next(0, 100);
                Valor[i] = Transferencia;
                Total += Transferencia;
            }

            float Media = Total / TamanhoVetor;

            Console.Write("Os numeros Maiores que a média [{0}] são: ", Media);
            for (int i = 0; i <= TamanhoVetor - 1; i++)
            {
                if (Media <= Valor[i])
                {
                    Console.Write(Valor[i]);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static int Main(string[] args)
        {
            int ValorExercicios;
            do
            {


                Console.WriteLine("----------ESCOLHA O EXERCICIO------------- ");
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("------------------------------------------ ");
                Console.WriteLine("SAIR-------------------------------------- ");
                Console.WriteLine("Leitura float--------------------------- 1 ");
                Console.WriteLine("Verificação de N inteiro---------------- 2 ");
                Console.WriteLine("Usando ex 2 randomicamente-------------- 3 ");
                Console.WriteLine("------------------------------------------\n ");


                int v = int.Parse(Console.ReadLine());
                ValorExercicios = v;

                switch (ValorExercicios)
                {
                    case 0:
                        Console.WriteLine(" Até a próxima! ");
                        Console.ReadKey();
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;

                    default:
                        Console.WriteLine("O numero não corresponde a lista de exercicios");
                        Console.ReadKey();
                        break;
                }
            } while (ValorExercicios != 0);
            return 0;
        }
    }
}