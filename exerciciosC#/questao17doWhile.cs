using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um algoritmo que solicita ao usuário valores inteiros positivos N e conta a quantidade de números pares e ímpares digitados.
// Quando o usuário digitar o valor -1 o programa deve parar.
// O algoritmo deve mostrar ao final o total de números pares e ímpares digitados. 
// (Usando do ... while)

namespace exerciciosC_
{
    internal class questao17doWhile
    {
        public static void Main1()
        {
            int pares = 0;
            int impares = 0;
            int input;

            Console.WriteLine("Digite números inteiros positivos\n(Digite -1 para encerrar)");

            do
            {
                input = int.Parse(Console.ReadLine());

                if (input >= 0)
                {
                    if (input % 2 == 0)
                    {
                        pares += 1;
                    }

                    if (input % 2 != 0)
                    {
                        impares += 1;
                    }
                }
                else
                {
                    if (input != -1)
                    {
                        Console.WriteLine($"{input} não é um número positivo");
                        continue;
                    }
                }
            } while (input != -1);

            if (pares != 0 || impares != 0)
            {
                Console.WriteLine($"Foram inseridos {pares} números pares");
                Console.WriteLine($"Foram inseridos {impares} números ímpares");
            }
            else
            {
                Console.WriteLine("Nenhum número positivo foi inserido.");
            }
        }
    }
}
