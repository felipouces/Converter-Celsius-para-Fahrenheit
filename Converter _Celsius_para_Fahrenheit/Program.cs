using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programinha para converter temperatura de Fahrenheit para  Graus Celsius

namespace Converter__Celsius_para_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 0.0f;
            double temp2 = 0.0f;
            Console.WriteLine("Indique a temperatura em Fahrenheit\n");
            temp = double.Parse(Console.ReadLine()); // converter para texto usando float.Parse
            Console.WriteLine();
            Console.WriteLine("Indique a temperatura em graus Celsius\n");
            temp2 = double.Parse(Console.ReadLine()); // converter para texto usando float.Parse
            Console.WriteLine();

            double c = (temp - 32) / 1.8;
            double f = (temp2 * 1.8) + 32;

            Console.WriteLine($" A temperatura convertida em graus celsius é {c:f1} .");
            Console.WriteLine();
            Console.WriteLine($" A temperatura convertida em Fahrenheit é {f:f1} .");
        }
    }
}
