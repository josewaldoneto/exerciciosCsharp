using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um algoritmo que solicita ao usuário dois operandos e um código de operação (1 - Soma, 2 - Subtração, 3 - Divisão ou 4 - Multiplicação) 
// e realiza a operação correspondente sobre os operandos fornecidos pelo usuário.

namespace exerciciosC_
{
    internal class questao12calculadora
    {
        public static void Main1()
        {
            int op;
            Console.WriteLine("Escreva o primeiro valor.");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor.");
            double Y = double.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Escreva o código da operação.");
                Console.WriteLine("1 - Soma\n2 - Subtracao\n3 - Divisao\n4 - Multiplicacao");
                op = int.Parse(Console.ReadLine());
                if (op <= 0 || op > 4) {
                    Console.WriteLine("Valor inválido.\n");
                    continue;
                }
                break;
            }

            switch (op) 
            {
                case 1:
                    Console.WriteLine($"O resultado da operação é {X + Y}");
                    break;
                case 2:
                    Console.WriteLine($"O resultado da operação é {X - Y}");
                    break;
                case 3:
                    Console.WriteLine($"O resultado da operação é {X / Y}");
                    break;
                case 4:
                    Console.WriteLine($"O resultado da operação é {X * Y}");
                    break;
            }
        }
    }
}
