using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um programa que retorna a hora que for digitada e cumprimente de acordo com o horário.
// 0 <= madrugada < 6
// 6 <= dia < 12
// 12 <= tarde < 18
// 18 <= noite <= 24

namespace exerciciosC_
{
    internal class questao11horario
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva a hora.");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 0)
            {
                Console.WriteLine($"Não existe {hora} horas.");
            }
            else if (hora < 6)
            {
                Console.WriteLine($"Agora são {hora} horas. Boa Madrugada!");
            }
            else if (hora < 12)
            {
                Console.WriteLine($"Agora são {hora} horas. Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine($"Agora são {hora} horas. Boa tarde!");
            }
            else if (hora > 24)
            {
                Console.WriteLine($"Não existe {hora} horas.");
            }
            else
            {
                Console.WriteLine($"Agora são {hora} horas. Boa noite!");
            }
        }
    }
}
