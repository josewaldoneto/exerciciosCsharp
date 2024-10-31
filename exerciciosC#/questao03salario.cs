using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.
// A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

// Entrada:     Saída:
// 25           Funcionários = 25
// 100          Salário = U$ 550.00
// 5,50


namespace exerciciosC_
{
    internal class questao03salario
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o número do funcionário.");
            int funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o número de horas trabalhadas.");
            double horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor por hora.");
            double valorHora = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário = {funcionario}");
            Console.WriteLine($"Salário = {(horasTrabalhadas * valorHora).ToString("C")}");
        }
    }
}
