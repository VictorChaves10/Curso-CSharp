﻿using System;
using System.Data;

int div = 0;

Console.Write("Digite um número inteiro: ");

int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
     if(n % i == 0)
    {
        Console.WriteLine(i);
    }
}
