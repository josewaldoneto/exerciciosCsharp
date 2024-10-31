using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um programa que leia N números reais e armazene-os em um vetor.
// Em seguida, mostrar na tela o maior número do vetor (supor não haver empates).
// Mostrar também a posição do maior elemento, considerando a primeira posição como 0 (zero).

namespace exerciciosC_
{
    internal class questao33vetor4
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o tamanho do vetor.");
            int n = int.Parse(Console.ReadLine());

            double[] reais = new double[n];
            double? maior = null;
            int posicaoMaior = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escreva um número real.");
                reais[i] = double.Parse(Console.ReadLine());
                
                if (maior == null || reais[i] > maior)
                {
                    maior = reais[i];
                    posicaoMaior = i;
                }
            }
            if (maior == null)
            {
                Console.WriteLine("Não há valores no vetor.");
            }
            else
            {
                Console.WriteLine($"O maior valor é {maior} na posição {posicaoMaior}.");
            }
        }
    }
}
