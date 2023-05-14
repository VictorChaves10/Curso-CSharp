Console.Write("Informe a quantidade de produtos a ser inserido: ");

int n = int.Parse(Console.ReadLine());

string[] name = new string[n];
double[] price = new double[n];

for (int i = 0;i < n; i++)
{
    Console.WriteLine($"\nProduto {i + 1}:");
    Console.Write("\nInforme o nome do produto: ");
    name[i] = Console.ReadLine();
    Console.Write("Informe o valor desse produto: R$ ");
    price[i] = double.Parse(Console.ReadLine());

    

}
Console.WriteLine("\nListas dos produtos:\n");
double priceMed = 0.0;

for(int i = 0;i < n; i++)
{
    Console.WriteLine($"- {name[i]}  R${price[i].ToString("F2")}");
    priceMed+= price[i];
}

Console.WriteLine($"\nPreço médio dos produtos: {(priceMed / n).ToString("F2")}");

