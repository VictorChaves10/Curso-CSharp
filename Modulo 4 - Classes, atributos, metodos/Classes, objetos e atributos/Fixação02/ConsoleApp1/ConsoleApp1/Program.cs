using System;
using System.Globalization;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employe func1 = new Employe();
            Employe func2 = new Employe();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (func1.Salary + func2.Salary) / 2;

            Console.WriteLine("Salário médio = " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
