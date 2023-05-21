

using Ex001.Entities;
using Ex001.Entities.Enums;

Console.Write("Enter department's name: ");
string department = Console.ReadLine();

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double salary = double.Parse(Console.ReadLine());

Worker worker = new Worker(name, salary, level, department);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEnter #{i+1} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract= new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
string[] dateIncome = Console.ReadLine().Split("/");
int month = int.Parse(dateIncome[0]);
int year = int.Parse(dateIncome[1]);

Console.Write("Name: ");
Console.WriteLine(worker.Name);
Console.Write("Departament: ");
Console.WriteLine(worker.Department.Name);
Console.Write($"Income for {month}/{year}: R$");
Console.WriteLine(worker.Income(year, month));





