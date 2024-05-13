using System.Globalization;

Console.WriteLine("Digite a quantidade de vezes que ira realizar o cálculo: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigite os números que serão dividos: ");
for (int i = 1; n >= i; i++)
{
    string[] numb = Console.ReadLine().Split(' ');

    double divisor = double.Parse(numb[0], CultureInfo.InvariantCulture);
    double denominador = double.Parse(numb[1], CultureInfo.InvariantCulture);

    if (denominador != 0)
    {
        double calc = divisor / denominador;
        Console.WriteLine(calc.ToString("F1", CultureInfo.InvariantCulture));
    }
    else
    {
        Console.WriteLine("Divisão Impossível!");
    }
}