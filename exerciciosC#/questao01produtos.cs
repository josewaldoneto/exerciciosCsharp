using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Produtos:
// Computador, cujo preço é R$ 2.100,00
// Mesa de escritório, cujo preço é R$ 650,50
// Registro: 30 anos, código 5290 e gênero: F
// Medida com oito casas decimais: 53,23456700
// Cercado(três casas decimais): 53.235
// Ponto decimal dos EUA: 53,235

namespace exerciciosC_
{
    internal class questao01produtos
    {
        public static void Main1()
        {
            String product1 = "Computer";
            String product2 = "Office desk";

            int age = 30;
            int code = 5290;
            string gender = "F";

            double price1 = 2100.0;
            double price2 = 650.0;
            double measure = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{product1}, cujo preço é {price1.ToString("C")}");
            Console.WriteLine($"{product2}, cujo preço é {price2.ToString("C")}");
            Console.WriteLine($"Registro: {age} anos, código {code} e gênero: {gender}");
            Console.WriteLine($"Medida com oito casas decimais: {Convert.ToDecimal(measure).ToString("0.00000000")}");
            Console.WriteLine($"Cercado(três casas decimais): {Convert.ToDecimal(measure).ToString("0.000")}");
            Console.WriteLine($"Ponto decimal dos EUA: {measure.ToString(CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}
