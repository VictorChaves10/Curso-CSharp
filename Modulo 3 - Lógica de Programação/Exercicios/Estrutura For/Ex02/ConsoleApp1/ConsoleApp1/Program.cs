using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            Console.Write("Digite a quantidade de números que serão inseridos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; n >= i; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro+" in");
            Console.WriteLine(fora+" out");
        }
    }
}
