using ConsoleApp1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

Funcionario f1 = new Funcionario();

Console.Write("Nome: ");
f1.Nome = Console.ReadLine();

Console.Write("Salário bruto: ");
f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
f1.Imposto  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("\nFuncionário: "+f1);

Console.Write("\nDigite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f1.AumentarSalario(porcentagem);

Console.WriteLine("\nDados Atualizados: " + f1);

