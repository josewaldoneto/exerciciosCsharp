using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crie uma matriz 3x3 de inteiros, preencha a matriz e verifique se a matriz é um quadrado mágico.
//Diz-se que uma matriz é um quadrado mágico quando a soma de todas as suas linhas, 
//todas as suas colunas, sua diagonal principal e sua diagonal secundária resultam no mesmo valor.


namespace exerciciosC_
{
    internal class questao38matriz4
    {
        public static void Main()
        {
            int n = 3;

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Escreva valor da posição ({i},{j}).");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int somaMagica = 0;

            for (int j = 0; j < 3; j++)
            {
                somaMagica += matriz[0, j];
            }

            for (int i = 1; i < 3; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaLinha += matriz[i, j];
                }
                if (somaLinha != somaMagica)
                {
                    Console.WriteLine("A matriz não é um quadrado mágico.");
                    return;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < 3; i++)
                {
                    somaColuna += matriz[i, j];
                }
                if (somaColuna != somaMagica)
                {
                    Console.WriteLine("A matriz não é um quadrado mágico.");
                    return;
                }
            }
            int diagonalPrincipalSoma = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
            if (diagonalPrincipalSoma != somaMagica)
            {
                Console.WriteLine("A matriz não é um quadrado mágico.");
                return;
            }

            int diagonalSecundariaSoma = matriz[0, 2] + matriz[1, 1] + matriz[2, 0];
            if (diagonalSecundariaSoma != somaMagica)
            {
                Console.WriteLine("A matriz não é um quadrado mágico.");
                return;
            }

            Console.WriteLine("A matriz é um quadrado mágico.");
        }
    }
}
