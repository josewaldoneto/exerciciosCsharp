using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// O professor aplicou a avaliação em sua turma e deseja mostrar se o aluno foi aprovado (nota maior ou igual a 5) ou reprovado(nota menor que 5). 
// Desenvolva o programa que leia a nota do aluno e gere a tela de saída com as informações solicitadas.

namespace exerciciosC_
{
    internal class questao09avaliacao
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva a nota do aluno.");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 5)
            {
                Console.WriteLine("Você foi Aprovado!");
            }
            else
            {
                Console.WriteLine("Você foi Reprovado!");
            }
        }
    }
}
