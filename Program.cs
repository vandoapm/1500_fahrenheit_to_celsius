using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1500_fahrenheit_to_celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Converter temperatura medida em graus Fahrenheit para Celsius");

            Console.WriteLine();

            Console.Write("Digite a temperatura em ºF: ");
            float f = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("A temperatura de " + f + "ºF é igual a " + ((f - 32) * 5)/9 + "ºC");

            Console.ReadLine();

        }
    }
}
