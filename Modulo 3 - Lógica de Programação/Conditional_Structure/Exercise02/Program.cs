int resultado = 0;

Console.WriteLine("Digite a hora inicial do jogo e a hora final: ");

string[] periodo = Console.ReadLine().Split();

int inicio = int.Parse(periodo[0]);

int fim = int.Parse(periodo[1]);

if (inicio > fim)
{
    resultado = fim - (inicio - 24);
    Console.WriteLine($"O JOGO DUROU {resultado} HORA(S) ");
}
else if (inicio < fim)
{
    resultado = fim - inicio;
    Console.WriteLine($"O JOGO DUROU {resultado} HORA(S) ");

}
else
{
    Console.WriteLine($"O JOGO DUROU 24 HORA(S) ");
}
