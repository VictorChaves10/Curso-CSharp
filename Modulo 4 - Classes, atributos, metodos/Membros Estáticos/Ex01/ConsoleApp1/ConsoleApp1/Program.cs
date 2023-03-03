using ConsoleApp1;
using System.Globalization;


Console.Write("Qual a cotação do dólar? ");
double cotação = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double ValorFinal = ConversorDeDolar.Conversor(cotação, quantidade);

Console.WriteLine("Valor a ser pago em reais = "+ ValorFinal.ToString("F2",CultureInfo.InvariantCulture));
