using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler quatro valores inteiros A, B, C e D. 
// A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

namespace exerciciosC_
{
    internal class questao05diferenca
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o valor de A.");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de B.");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de C.");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de D.");
            int D = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diferença = {(A*B)-(C*D)}");
        }
    }
}
