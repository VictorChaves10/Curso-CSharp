Console.Write("Digite as cordenadas: ");
string[] cordenadas = Console.ReadLine().Split(' ');

int x = int.Parse(cordenadas[0]);
int y = int.Parse(cordenadas[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro");
    }
    else
    {
        Console.WriteLine("Quarto");

    }

    cordenadas = Console.ReadLine().Split(' ');

    x = int.Parse(cordenadas[0]);
    y = int.Parse(cordenadas[1]);
}