using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crie uma matriz 4x4 de decimais, preencha a matriz e depois: 
//  a) Exiba os valores da sua diagonal principal;
//  b) Exiba os valores da sua diagonal secundária;
//  c) A sua matriz transposta. 


namespace exerciciosC_
{
    internal class questao37matriz3
    {
        public static void Main1()
        {
            int n = 4;

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Escreva valor da posição ({i},{j}).");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Diagonal Secundária:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(matriz[i, 3 - i] + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Matriz Transposta:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
