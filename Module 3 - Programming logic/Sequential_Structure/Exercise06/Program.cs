using System.Globalization;
using System;

double pi = 3.14159;

Console.Write("Digite três valores com ponto flutuante: ");

string[] value = Console.ReadLine().Split(' ');

double valA = double.Parse(value[0]);
double valB = double.Parse(value[1]);
double valC = double.Parse(value[2]);

double areaTriangle = (valA * valC) / 2;

double areaCircle = Math.Pow(valC, 2) * pi;

double areaTrapezio = ((valA + valB) * valC) / 2;

double areaSquare = valB * valB;

double areaRetangle = valA * valB;

Console.WriteLine("TRIANGULO: " + areaTriangle.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + areaCircle.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + areaSquare.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + areaRetangle.ToString("F3", CultureInfo.InvariantCulture));
