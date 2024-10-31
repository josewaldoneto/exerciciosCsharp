using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Criem um programa que recebe o número X e se o número não for  10 ele vai transformá lo em 10  

namespace exerciciosC_
{
    internal class questao7x_10
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o valor de X.");
            double X = double.Parse(Console.ReadLine());

            if (X != 10)
            {
                Console.WriteLine($"X é igual a {X}");
                X = 10;
                Console.WriteLine($"Agora X é igual a {X}");
            }
            else 
            {
                Console.WriteLine($"X é igual a {X}");
            }
        }
    }
}
