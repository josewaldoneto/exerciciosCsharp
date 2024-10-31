using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Faça uma função que receba um inteiro e mostre na tela se ele for múltiplo de 2.

namespace exerciciosC_
{
    internal class questao25funcoes2
    {
        public static void isPair(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Esse valor é múltiplo de 2.");
            }
            else
            {
                Console.WriteLine("Esse valor não é múltiplo de 2.");
            }
        }
        public static void Main1()
        {
            Console.WriteLine("Escreva um valor inteiro.");
            int x = int.Parse(Console.ReadLine());
            isPair(x);
        }
    }
}
