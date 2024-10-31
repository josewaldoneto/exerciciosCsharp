using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

// Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de telefone. 
// Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00. 
// Fazer um programa para ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago.

namespace exerciciosC_
{
    internal class questao10operadora
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva a quantidade de minutos consumida.");
            int minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100)
            {
                Console.WriteLine($"Valor a pagar: {(50).ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Valor a pagar: {(((minutos - 100) * 2) + 50).ToString("C")}");
            }
        }
    }
}
