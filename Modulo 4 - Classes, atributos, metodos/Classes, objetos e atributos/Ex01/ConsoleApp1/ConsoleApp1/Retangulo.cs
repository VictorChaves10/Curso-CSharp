using System;

namespace ConsoleApp1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura+Altura);
        }

        public double Diagonal()
        {
            double calc = (Largura * Largura) + (Altura * Altura);

            return Math.Sqrt(calc);
        }
    }
}
