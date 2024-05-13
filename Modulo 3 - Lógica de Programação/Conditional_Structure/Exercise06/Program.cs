double salary = double.Parse(Console.ReadLine());
double imposto = 0;


if (salary <= 2000.00)
{
    Console.WriteLine("Isento");
}
else if (salary <= 3000.00)
{
    imposto = ((salary - 2000.00) * 8.00) / 100.00;

}
else if (salary > 3000.00 && salary < 4500.00)
{
    imposto = ((salary - 3000.00) * 18.00 / 100.00) + 80.00;
}
else
{
    imposto = ((salary - 4500.00) * 28.00 / 100.00) + 350.00;
}
Console.WriteLine("R$ " + imposto.ToString("F2"));