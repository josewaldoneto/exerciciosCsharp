using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler um número inteiro N e a altura de N pessoas. 
// Armazene as N alturas em um vetor.
// Em seguida, mostrar a altura média dessas pessoas.

namespace exerciciosC_
{
    internal class questao30vetor1
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o tamanho do vetor.");
            int n = int.Parse(Console.ReadLine());
            int[] alturas = new int[n];
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Escreva a altura da pessoa {i+1}.");
                int alt = int.Parse(Console.ReadLine());
                alturas[i] = alt;
                soma += alt;
            }
            Console.WriteLine($"A média das alturas inseridas é de {soma / n}");
        }
    }
}
