using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros.
// Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.

namespace exerciciosC_
{
    internal class questao35matriz1
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o tamanho da matriz quadrada.");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Escreva valor da posição ({i},{j}).");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("A diagonal principal é composta por: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        Console.Write($"{matriz[i,j]}  ");
                    }
                }
            }
            int nNegativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        nNegativos++;
                    }
                }
            }
            Console.WriteLine($"\nA matriz possui {nNegativos} números negativos.");
        }
    }
}
