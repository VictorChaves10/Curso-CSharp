using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime bd)
        {
            Name = name;
            Email = email;
            birthDate = bd;
        }

        public override string ToString()
        {
            return $"Client: {Name} ({birthDate.ToString("dd/MM/yyyy")} - {Email})";
        }
    }
}