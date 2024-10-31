using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cria um Algoritmo que verifica se um número é PAR ou IMPAR:

namespace exerciciosC_
{
    internal class questao08parImpar
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva um número inteiro.");
            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                Console.WriteLine($"{X} é par");
            }
            else
            {
                Console.WriteLine($"{X} é ímpar");
            }
        }
    }
}
