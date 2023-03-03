using System;
using System.Globalization;

double pi = 3.14159;

Console.WriteLine("Digite o valor do raio do cículo :");

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = Math.Pow(raio,2) * pi;

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));