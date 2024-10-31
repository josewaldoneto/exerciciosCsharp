using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Elabore uma função que receba três notas de um aluno como parâmetro e uma letra.
// Se a letra for ‘A’ / ‘a’, a função deve calcular a média aritmética das notas do aluno.
// Se a letra for ‘P’ / ‘p’, deverá calcular a média ponderada, com pesos 5, 3 e 2, respectivamente com as notas 1, 2, 3.
// Retorne a média calculada para o programa principal.

namespace exerciciosC_
{
    internal class questao27funcoes4
    {
        public static double media(int[] lista, string metodo)
        {
            int i = 0;
            int soma = 0;
            metodo = metodo.ToLower();
            if (metodo == "a")
            {
                foreach (int n in lista)
                {
                    soma += n;
                    i++;
                }
                return soma / i;
            }
            else if (metodo == "p")
            {
                return (lista[0] * 5/3) + (lista[1] * 3/3) + (lista[2] * 2/3);
            }
            else
            {
                return -1;
            }
        }
        public static void Main1()
        {
            int[] notas = [2,2,3];
            string metodo = "p";

            Console.WriteLine(media(notas, metodo));
        }
    }
}
