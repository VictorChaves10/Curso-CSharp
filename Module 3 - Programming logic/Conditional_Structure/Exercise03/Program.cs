double hotDog = 4.00;
double xSalad = 4.50;
double xBacon = 5.00;
double simpleToast = 2.00;
double refriCola = 1.50;

double total = 0;

string[] menu = Console.ReadLine().Split(' ');

int option = int.Parse(menu[0]);

int quanty = int.Parse(menu[1]);

if (option == 1)
{
    total = hotDog * quanty;

}
else if (option == 2)
{
    total = xSalad * quanty;

}
else if (option == 3)
{
    total = xBacon * quanty;

}
else if (option == 4)
{
    total = simpleToast * quanty;

}
else if (option == 5)
{
    total = refriCola * quanty;

}
else
{
    Console.WriteLine("Erro no pedido");
}

Console.WriteLine($"Total: R$ {total:F2}");
