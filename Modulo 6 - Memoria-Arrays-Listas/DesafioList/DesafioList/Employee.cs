internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public double Salary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void IncreaseSlary(double porcentage)
    {
        Salary += (porcentage * Salary) / 100.00;
    }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Salary.ToString("F2")}";
    }
}


