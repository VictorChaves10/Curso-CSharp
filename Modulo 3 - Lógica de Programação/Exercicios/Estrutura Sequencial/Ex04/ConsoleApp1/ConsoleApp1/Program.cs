
using System.Globalization;


Console.Write("Digite o número de identificação do funcionário: ");

int employe = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de horas trabalhadas: ");

int hoursWorked = int.Parse(Console.ReadLine());

Console.Write("Digite o valor da hora trabalhada: ");

double payHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salary = hoursWorked * payHours;

Console.WriteLine("NUMBER = " + employe);
Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));