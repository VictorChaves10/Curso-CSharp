using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();

            Console.WriteLine("\nEntre com os dados do produto: ");
            Console.Write("\nNome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("\nDados do produto: "+x);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(add);

            Console.WriteLine("\nDados atualizados: " + x);

            Console.Write("\nDigite o números de produtos a ser removido do estoque: ");
            int remov = int.Parse(Console.ReadLine());
            x.RemoverProdutos(remov);

            Console.WriteLine("\nDados atualizados: "+x);







        }
    }
}
