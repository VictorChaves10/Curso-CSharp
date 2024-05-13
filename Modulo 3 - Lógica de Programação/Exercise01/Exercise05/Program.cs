
Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

if (n != 0)
{
    for (int i = n - 1; i != 0; i--)
    {
        n *=  i;

    }

    Console.WriteLine(n);
}
else
{
    Console.WriteLine('1');
}
