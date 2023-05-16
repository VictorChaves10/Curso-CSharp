

namespace DesafioVetor
{
    internal class Pensionato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int IdCliente { get; set; }

        public Pensionato(string name, string email, int x) { 
        
            Nome = name;
            Email = email;
            IdCliente = x +1;
        }

        public override string ToString()
        {
            return $"  {IdCliente}\t\t{Nome}\t\t{Email}\n";
        }

    }
}
