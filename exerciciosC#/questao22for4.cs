using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

// Ler um valor N. 
// Calcular e escrever seu respectivo fatorial. 
// Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. 
// Lembrando que, por definição, fatorial de 0 é 1.

namespace exerciciosC_
{
    internal class questao22for4
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva um valor inteiro.");
            int n = int.Parse(Console.ReadLine());
            int total = n;

            if (n != 0)
            {
                for (int i = n-1; i > 0; i--)
                {
                    total *= i;
                }
                Console.WriteLine(total);
            } 
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
