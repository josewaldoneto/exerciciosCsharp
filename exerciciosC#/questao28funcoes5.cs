using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Solicite ao usuário uma string e substitua todas as ocorrências de uma letra por outra informada pelo usuário.

namespace exerciciosC_
{
    internal class questao28funcoes5
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva uma string.");
            string s = Console.ReadLine();
            Console.WriteLine("Escreva letra para ser trocada.");
            char letraInicial = char.Parse(Console.ReadLine());
            Console.WriteLine("Escreva qual letra deve substitui-la.");
            char letraTrocada = char.Parse(Console.ReadLine());

            Console.WriteLine(s.Replace(letraInicial, letraTrocada));
        }
    }
}
