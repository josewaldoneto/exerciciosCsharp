using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

namespace exerciciosC_
{
    internal class questao19for1
    {
        public static void Main1()
        {
            int dentro = 0;
            int fora = 0;

            Console.WriteLine("Escreva a quantidade de valores inteiros.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o número:");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} números estão dentro do intervalo [10,20].");
            Console.WriteLine($"{fora} números estão fora do intervalo [10,20].");
        }
    }
}
