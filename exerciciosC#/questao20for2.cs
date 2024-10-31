using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Leia um valor inteiro X.
// Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

namespace exerciciosC_
{
    internal class questao20for2
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva um valor inteiro.");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
