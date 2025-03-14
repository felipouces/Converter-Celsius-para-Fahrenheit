using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programinha para converter temperatura de Fahrenheit para Celsius

namespace Converter__Celsius_para_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 0.0f;
            Console.WriteLine("Indique a temperatura em Fahrenheit\n");
            temp = double.Parse(Console.ReadLine()); // converter para texto usando float.Parse
            Console.WriteLine();

            double c = (temp - 32) / 1.8;

            Console.WriteLine($" A temperatura convertida em celsius é {c:f2} .");
        }
    }
}
