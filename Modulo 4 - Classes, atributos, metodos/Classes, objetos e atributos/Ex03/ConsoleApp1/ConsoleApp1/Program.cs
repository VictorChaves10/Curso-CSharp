using ConsoleApp1;
using System.Globalization;


Aluno estudant = new Aluno();

Console.Write("Nome do aluno: ");
estudant.Name = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");

estudant.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (estudant.Grade1 > 30 || estudant.Grade1 < 0)
{
    Console.WriteLine("\nValor inválido! Digite Novamente: \n");
    estudant.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

estudant.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (estudant.Grade2 > 35 || estudant.Grade2 < 0)
{
    Console.WriteLine("\nValor inválido! Digite Novamente: \n");
    estudant.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
estudant.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (estudant.Grade3 > 35 || estudant.Grade3 < 0)

{
    Console.WriteLine("\nValor inválido! Digite Novamente:\n");
    estudant.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine("NOTA FINAL = "+ estudant.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if(estudant.NotaFinal() >= 60.00)
{
    Console.WriteLine("AROVADO");
}
else
{
    double diferenca = 60.00 - estudant.NotaFinal();
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + diferenca.ToString("F2", CultureInfo.InvariantCulture)+" PONTOS");
}





