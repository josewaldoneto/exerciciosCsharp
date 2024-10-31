using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que repita a leitura de uma senha até que ela seja válida.
// Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Inválida".
// Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.
// Considere que a senha correta é o valor 2002.

namespace exerciciosC_
{
    internal class questao14senha
    {
        public static void Main1()
        {
            int senha = 2002;
            int tentativa = 0;

            while (tentativa != senha)
            {
                Console.WriteLine("Escreva a senha.");
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa == senha)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
        }
    }
}