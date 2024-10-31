using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um programa que leia N números reais e armazene-os em um vetor. 
// Em seguida: 
//    -Imprimir todos os elementos do vetor 
//    - Mostrar na tela a soma e a média dos elementos do vetor  

namespace exerciciosC_
{
    internal class questao32vetor3
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o tamanho do vetor.");
            int n = int.Parse(Console.ReadLine());
            double[] reais = new double[n];
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escreva um número real.");
                double alt = double.Parse(Console.ReadLine());
                reais[i] = alt;
                soma += alt;
            }
            Console.Write("\nOs elementos do vetor são: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{reais[i]}  ");
            }
            Console.WriteLine($"\n\nA soma dos números inseridos é {soma}");
            Console.WriteLine($"\nA média dos números inseridos é de {soma / n}");
        }
    }
}
