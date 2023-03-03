using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                for (int i = n-1; i != 0; i--)
                {
                    n = n * i;

                }

                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine('1');
            }


        }

    }
}

