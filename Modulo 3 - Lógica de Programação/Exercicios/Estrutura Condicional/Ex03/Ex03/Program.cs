using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números que deseja saber se são multíplos: ");
            string[] numbers = Console.ReadLine().Split();

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Seus números são multíplos");
            }
            else
            {
                Console.WriteLine("Seus números não são multiplos");
            }
        }
    }
}
