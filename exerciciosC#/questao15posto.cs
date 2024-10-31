using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
// Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim).
// Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido).
// O programa será encerrado quando o código informado for o número 4.
// Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.


namespace exerciciosC_
{
    internal class questao15posto
    {
        public static void Main1()
        {
            int combustivel = 0;
            int totalAlcool = 0;
            int totalGasolina = 0;
            int totalDiesel = 0;

            while (combustivel != 4)
            {
                Console.WriteLine("Escreva o tipo de combustível.");
                Console.WriteLine("1. Álcool\n2. Gasolina\n3. Diesel\n4. Fim\n");
                combustivel = int.Parse(Console.ReadLine());
                switch (combustivel)
                {
                    case 1:
                        Console.WriteLine("Álcool +1\n");
                        totalAlcool += 1;
                        break;
                    case 2:
                        Console.WriteLine("Gasolina +1\n");
                        totalGasolina += 1;
                        break;
                    case 3:
                        Console.WriteLine("Diesel +1\n");
                        totalDiesel += 1;
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Código inválido\n");
                        break;
                }
            }
            Console.WriteLine($"MUITO OBRIGADO!\n{totalAlcool} clientes abasteceram com álcool\n{totalGasolina} clientes abasteceram com gasolina\n{totalDiesel} clientes abasteceram com diesel");
        }
    }
}
