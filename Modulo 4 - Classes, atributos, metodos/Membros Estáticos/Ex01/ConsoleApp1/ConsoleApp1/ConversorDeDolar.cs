using System;

namespace ConsoleApp1
{
    internal class ConversorDeDolar
    {
        public static double IOF = 6.00;


        public static double Conversor(double cotacao, double quant)
        {
            double soma = cotacao * quant;

            soma += soma * IOF / 100.00;

            return soma;
        }
    }
}
