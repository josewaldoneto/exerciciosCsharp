using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler um número inteiro positivo N.
// O programa deve então mostrar na tela N linhas, começando de 1 até N. 
// Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.

namespace exerciciosC_
{
    internal class questao23for5
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva um valor inteiro.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
