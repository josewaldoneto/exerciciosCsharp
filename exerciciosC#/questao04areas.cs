using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
// a) a área do triângulo retângulo que tem A por base e C por altura. 
// b) a área do círculo de raio C. (pi = 3.14159) 
// c) a área do trapézio que tem A e B por bases e C por altura. 
// d) a área do quadrado que tem lado B.
// e) a área do retângulo que tem lados A e B

namespace exerciciosC_
{
    internal class questao04areas
    {
        public static void Main1()
        {
            Console.WriteLine("Escreva o valor de A.");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de B.");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de C.");
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine($"Triângulo = {(A*C/2).ToString("0.000")}");
            Console.WriteLine($"Círculo = {(C *C*3.14159).ToString("0.000")}");
            Console.WriteLine($"Trapézio = {((A+B)*C/2).ToString("0.000")}");
            Console.WriteLine($"Quadrado = {(B *B).ToString("0.000")}");
            Console.WriteLine($"Retângulo = {(A * B).ToString("0.000")}");
        }
    }
}
