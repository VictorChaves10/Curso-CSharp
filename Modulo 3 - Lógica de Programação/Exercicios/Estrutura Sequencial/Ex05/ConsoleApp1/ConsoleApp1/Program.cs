



using System.Globalization;

Console.Write("Digite o código da peça 1, a quantidade e o valor unitário: ");

string[] peca1 = Console.ReadLine().Split(' ');

int codig = int.Parse(peca1[0]);

int quant = int.Parse(peca1[1]);

double preco = double.Parse(peca1[2], CultureInfo.InvariantCulture);

double sum = quant * preco;

Console.Write("Digite o código da peça 2, a quantidade e o valor unitário: ");

string[] peca2 = Console.ReadLine().Split(' ');

 codig = int.Parse(peca2[0]);

 quant = int.Parse(peca2[1]);

 preco = double.Parse(peca2[2],CultureInfo.InvariantCulture);

sum += quant * preco;

Console.WriteLine("VALOR A PAGAR: R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));




