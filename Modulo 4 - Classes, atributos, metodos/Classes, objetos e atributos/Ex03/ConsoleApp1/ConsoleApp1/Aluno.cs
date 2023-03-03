using System.Globalization;


namespace ConsoleApp1
{
    internal class Aluno
    {
        public string Name;

        public double Grade1;
        public double Grade2;
        public double Grade3;


        public double NotaFinal()
        {
            return Grade1 + Grade2 + Grade3;
        }

    }
}
