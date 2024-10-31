using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça um código que calcule a área de um trapézio e mostre o resultado com duas casas decimais. 

namespace exerciciosC_
{
    internal class questao02trapezio
    {
        public static void Main1()
        {
            double baseMaior = 10;
            double baseMenor = 7;
            double altura = 5;

            Console.WriteLine($"A área do trapézio é: {Convert.ToDecimal((baseMaior + baseMenor) * altura / 2).ToString("0.00")}");
        }
    }
}
