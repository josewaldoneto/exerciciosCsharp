using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

// Faça uma função que calcule a média aritmética de N números.

namespace exerciciosC_
{
    internal class questao26funcoes3
    {
        public static int media(int[] lista)
        {
            int i = 0;
            int soma = 0;
            foreach (int n in lista)
            {
                soma += n;
                i++;
            }
            return soma/i;
        }
        public static void Main1()
        {
            int[] valores = [5,5,4,4,3,3];
            Console.WriteLine(media(valores));
        }
    }
}
