using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler uma temperatura em Celsius e mostrar o equivalente em Fahrenheit. 
// Perguntar se o usuário deseja repetir (s/n).
// Caso o usuário digite "s", repetir o programa. 
// Fórmula: = 9C / 5 + 32

namespace exerciciosC_
{
    internal class questao18temperatura
    {
        public static void Main1()
        {
            double celsius;
            string? input = null;

            do
            {
                Console.WriteLine("Digite a temperatura em celsius.");
                celsius = double.Parse(Console.ReadLine());

                Console.WriteLine($"Equivalente em Fahrenheit: {(9 * celsius / 5) + 32}");

                while (true)
                {
                    Console.WriteLine("\nDeseja repetir o programa? (s/n)");
                    input = Console.ReadLine();

                    if (input == "s" || input == "n")
                    {
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Input inválido");
                    }
                }
            } while (input != "n");
        }
    }
}
