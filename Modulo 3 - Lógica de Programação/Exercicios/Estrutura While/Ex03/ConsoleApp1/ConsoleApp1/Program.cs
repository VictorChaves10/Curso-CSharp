using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int alcool1 = 0;
            int gasolina2 = 0;
            int diesel3 = 0;
           
            Console.WriteLine("1 - Alcool\n2 - Gasolina\n3 - Diesel\n4 - Encerrar\n");
            Console.Write("De acordo com a tabela acima, informe qual tipo de combustivel foi abastecido: ");
            int option = int.Parse(Console.ReadLine());

            while (option != 4)
            {
                if(option == 1)
                {
                    alcool1++;
                }
                else if(option == 2)
                {
                    gasolina2++;
                }
                else if (option == 3)
                {
                    diesel3++;
                }
                else
                {
                    Console.WriteLine("\nFavor informar um número válido!\n");
                }

                Console.WriteLine("\n1 - Alcool\n2 - Gasolina\n3 - Diesel\n4 - Encerrar\n");
                Console.Write("De acordo com a tabela acima, informe qual tipo de combustivel foi abastecido: ");

                option = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: "+alcool1);
            Console.WriteLine("Gasolina: "+gasolina2);
            Console.WriteLine("Diesel: "+ diesel3);


        }
    }
}
