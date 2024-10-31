using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Achar o maior e o menor número de uma série de números inteiros positivos fornecidos pelo usuário via teclado.
// O programa deve solicitar valores até que o usuário entre com -1.
// (Usando while e condicionais)


namespace exerciciosC_
{
    internal class questao16maiorMenor
    {
        public static void Main1()
        {
            int? maior = null;
            int? menor = null;
            int input;

            Console.WriteLine("Digite números inteiros positivos\n(Digite -1 para encerrar)");

            while (true)
            {
                input = int.Parse(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }

                if (input < 0)
                {
                    Console.WriteLine($"{input} não é um número positivo");
                    continue;
                }

                if (maior == null || input > maior)
                {
                    maior = input;
                }

                if (menor == null || input < menor)
                {
                    menor = input;
                }
            }

            if (maior.HasValue && menor.HasValue)
            {
                Console.WriteLine($"O maior número é: {maior}");
                Console.WriteLine($"O menor número é: {menor}");
            }
            else
            {
                Console.WriteLine("Nenhum número positivo foi inserido.");
            }
        }
    }
}
