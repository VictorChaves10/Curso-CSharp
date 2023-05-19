
using System.Collections.Generic;


List<Employee> employees = new List<Employee>();
Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEmploye #{i + 1}:");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine());

    employees.Add(new Employee(id, name, salary));

}

Console.Write("\n\nEnter the employee id that will have salary increase: ");
int findId = int.Parse(Console.ReadLine());


Employee result = employees.Find(x => x.Id == findId);

if (result != null)
{
    Console.Write("Enter the percentage: ");
    double position = double.Parse(Console.ReadLine());
    result.IncreaseSlary(position);

}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine("\nUpdate list of employees:");

foreach (Employee obj in employees)
{
    Console.WriteLine(obj);
}