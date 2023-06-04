using Desafio.Entities;
using Desafio.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime dateBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);

Client client = new Client(name,email,dateBirth);

Console.WriteLine("\nEnter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(DateTime.Now, status,client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for(int i= 0; i < n; i++)
{
    Console.WriteLine($"\nEnter #{i+1} item data: ");

    Console.Write("Product name: ");
    string namePdct = Console.ReadLine();    

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine());

    Product product = new Product(namePdct, price);

       
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(product, quantity);

    order.AddItem(orderItem);
}



Console.WriteLine(order);