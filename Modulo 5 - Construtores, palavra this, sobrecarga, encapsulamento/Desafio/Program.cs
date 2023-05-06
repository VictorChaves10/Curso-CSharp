using System.Globalization;
using System;
using Desafio;

Console.Write("Entre o número da conta: ");
int numConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char depositoInicial = Char.Parse(Console.ReadLine().ToUpper());

ContaBancaria user1 = new ContaBancaria(numConta, nome);

while(depositoInicial != 'S' && depositoInicial != 'N')
{
    Console.Write("Favor informar uma opção válida : ");
    depositoInicial = Char.Parse(Console.ReadLine().ToUpper());
}


if(depositoInicial == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    user1.Deposito(double.Parse(Console.ReadLine()));
}

Console.WriteLine("\n\nDados da conta:");
Console.WriteLine(user1);

Console.Write("\n\nEntre um valor para depósito: ");
user1.Deposito(double.Parse(Console.ReadLine()));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(user1);

Console.Write("\n\nEntre um valor para saque: ");
user1.Saque(double.Parse(Console.ReadLine()));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(user1);