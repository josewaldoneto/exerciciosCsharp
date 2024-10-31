using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. 
// A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem  (x = y = 0).
// Se o ponto estiver na origem, escreva a mensagem “Origem”.
// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

namespace exerciciosC_
{
    internal class questao13coordenadas
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o valor de X.");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de Y.");
            double Y = double.Parse(Console.ReadLine());

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }

            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }

            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }

            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}
