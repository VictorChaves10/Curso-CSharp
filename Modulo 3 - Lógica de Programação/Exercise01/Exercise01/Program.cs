﻿




Console.WriteLine("Digite um valor inteiro: ");
int numbX = int.Parse(Console.ReadLine());

for (int i = 1; numbX >= i; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}