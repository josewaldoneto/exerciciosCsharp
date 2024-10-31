using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um algoritmo que preencha uma matriz 3x3 de inteiros e escreva: 
//  a) a soma dos números ímpares fornecidos;
//  b) a soma de cada uma das 3 colunas;
//  c) a soma de cada uma das 3 linhas. 

namespace exerciciosC_
{
    internal class questao36matriz2
    {
        public static void Main1()
        {
            int n = 3;
            int somaImpares = 0;
            int sum = 0;

            int[,] matriz = new int[n, n];
            int[] somaColunas = new int[3];
            int[] somaLinhas = new int[3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Escreva valor da posição ({i},{j}).");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] % 2 == 1)
                    {
                        somaImpares += matriz[i, j];
                    }
                    somaColunas[j] += matriz[i, j];

                    somaLinhas[i] += matriz[i, j];
                }
            }
            Console.WriteLine($"\na) A soma dos números ímpares presentes na matriz é {somaImpares}.");

            Console.WriteLine("b) Soma de cada coluna:");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Coluna {j + 1}: {somaColunas[j]}");
            }

            Console.WriteLine("c) Soma de cada linha:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Linha {i + 1}: {somaLinhas[i]}");
            }
        }
    }
}