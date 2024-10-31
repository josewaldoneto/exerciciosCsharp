using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

// Faça uma função que aceita 2 inteiros e retorna a multiplicação.

namespace exerciciosC_
{
    internal class questao24funcoes1
    {
        public static int mult(int x, int y) 
        {
            return x * y;
        }
        public static void Main1()
        {
            Console.WriteLine("Escreva o primeiro valor inteiro.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor inteiro.");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da multiplicacao é {mult(x, y)}");
        }
    }
}
