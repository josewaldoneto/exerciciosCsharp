using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Criem um programa que recebe o número X e imprime se o número é maior que dois , menor que dois ou igual a dois 

namespace exerciciosC_
{
    internal class questao6maiormMenor
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o valor de X.");
            double X = double.Parse(Console.ReadLine());

            if (X == 2)
            {
                Console.WriteLine("X é igual a dois");
            }
            else if (X > 2)
            {
                Console.WriteLine("X é maior que dois");
            }
            else 
            {
                Console.WriteLine("X é menor que dois");
            }
        }
    }
}
