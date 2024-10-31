using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um programa que leia um número inteiro positivo N (máximo = 10) e depois N números inteiros e armazene-os em um vetor. 
// Em seguida, mostrar na tela todos os números negativos lidos.  

namespace exerciciosC_
{
    internal class questao31vetor2
    {
        public static void Main1()
        {
            int n = 0;
            while (true) 
            {
                Console.WriteLine("Escreva a quantidade de números inteiros. (Máximo 10)");
                n = int.Parse(Console.ReadLine());
                if (n > 10 || n <= 0)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    break;
                }
            }
            int[] inteiros = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escreva um número para inserir no vetor.");
                inteiros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nOs números negativos são: ");
            for (int i = 0; i < n; i++)
            {
                if (inteiros[i] < 0 )
                {
                    Console.Write($"{inteiros[i]}, ");
                }
            }
        }
    }
}
