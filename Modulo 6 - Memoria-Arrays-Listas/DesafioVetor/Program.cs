


using DesafioVetor;

Pensionato[] Quartos = new Pensionato[10];


Console.Write("Qual a quantidade de clientes gostaria de registrar(1 a 10)?   ");
int n = int.Parse(Console.ReadLine());
while (n <= 0 || n > 10)
{
    Console.Write("Favor informar a quantidade de 1 até 10: ");
    n = int.Parse(Console.ReadLine());
}


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\n\nCliente {i + 1}:\n");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Número do quarto desejado: ");
    int numQuarto = int.Parse(Console.ReadLine()) - 1;

    while (Quartos[numQuarto] != null)
    {
        Console.Clear();
        Console.WriteLine("\nEsse quarto no momento está ocupado!\n");
        Console.Write($"Quartos disponíveis N°: ");
        for (int j = 0; j < 10; j++)
        {
            
           if (Quartos[j] == null)
            {
                Console.Write($"{j+1}, ");
            }
        }

        Console.Write("\n\nInforme outro quarto: ");

        numQuarto = int.Parse(Console.ReadLine()) - 1;

    }

    Quartos[numQuarto] = new Pensionato(nome, email,numQuarto);


}

Console.WriteLine("\n* Relátorio de Ocupção do Pensionato *");
Console.WriteLine("-----------------------------------------------\n");
Console.WriteLine("\n  N° Quarto\tNome\t\tE-mail\n");

for (int i = 0; i < 10; i++)
{
    if (Quartos[i] == null)
    {
        Console.WriteLine($"  {i+1}\t\tVazio\t\tVazio\n");
    } 
    Console.WriteLine($"{Quartos[i]}");
}

