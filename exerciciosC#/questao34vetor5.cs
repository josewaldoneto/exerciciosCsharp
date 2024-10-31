using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades.
// Os nomes devem ser armazenados em um vetor, e as idades em um outro vetor.
// Depois, mostrar na tela o nome da pessoa mais velha.  

namespace exerciciosC_
{
    internal class questao34vetor5
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o tamanho do vetor.");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            int? maisVelha = null;
            int posicaoVelha = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Escreva o nome da pessoa.");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Escreva a idade da pessoa.");
                idades[i] = int.Parse(Console.ReadLine());

                if (maisVelha == null || idades[i] > maisVelha)
                {
                    maisVelha = idades[i];
                    posicaoVelha = i;
                }
            }
            if (maisVelha == null)
            {
                Console.WriteLine("Não há elementos no vetor.");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {nomes[posicaoVelha]} com {maisVelha} anos.");
            }
        }
    }
}
