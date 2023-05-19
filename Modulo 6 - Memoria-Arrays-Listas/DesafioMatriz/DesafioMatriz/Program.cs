


Console.Write("Informe a quantidade de linhas: ");
int r = int.Parse(Console.ReadLine());

Console.Write("Informe a quantidade de colunas: ");
int c = int.Parse(Console.ReadLine());

int[,] mat = new int[r, c];
Random numb = new Random();

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < r; j++)
    {
        mat[i, j] = numb.Next(0, 25);
    }
}

Console.WriteLine();

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write($"{mat[i, j].ToString("D2")} ");
    }
    Console.WriteLine();
}

Console.Write("\nInforme um valor contido na matriz: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 0; i < r; i++)
{

    for (int j = 0; j < c; j++)
    {
        if (mat[i, j] == x)
        {
            if (i != 0)
            {
                Console.WriteLine($"   {mat[i - 1, j].ToString("D2")}");
            }
            if (j != 0)
            {
                Console.Write(mat[i, j - 1].ToString("D2"));
            }
            if ((j + 1) < mat.GetLength(1))
            {
                Console.Write($"    {mat[i, j + 1].ToString("D2")}");
            }
            if ((i + 1) < mat.GetLength(0))
            {
                Console.WriteLine($"\n   {mat[i + 1, j].ToString("D2")}");
            }

        }
    }

}
