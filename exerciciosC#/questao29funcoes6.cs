using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que receba uma string e remova todas as vogais. 
// Informe ao usuário o resultado.

namespace exerciciosC_
{
    internal class questao29funcoes6
    {
        public static string desVogal(string palavra)
        {
            string[] vogais = ["a", "e", "i", "o", "u"];
            string palavraDesvogalizada = palavra;
            for (int i = 0; i < 5; i++)
            {
                palavraDesvogalizada = palavraDesvogalizada.Replace(vogais[i], "");
            }
            return palavraDesvogalizada;
        }
        public static void Main1()
        {
            Console.WriteLine("Escreva uma string.");
            string s = Console.ReadLine();
            Console.WriteLine(desVogal(s));
        }
    }
}
