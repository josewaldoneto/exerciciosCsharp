﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

// Ler um número inteiro N e calcular todos os seus divisores.

namespace exerciciosC_
{
    internal class questao21for3
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva um valor inteiro.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
