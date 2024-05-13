using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; n >= i; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0],CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1],CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2],CultureInfo.InvariantCulture);

                double result = (a * 2.0 + b * 3.0 + c * 5.0) / (2.0 + 3.0 + 5.0);
                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
