using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; private set; }


        public ContaBancaria(int numConta, string nome)
        {
            NumeroConta = numConta;
            NomeTitular = nome;
        }
        public ContaBancaria(int numConta, string nome, double deposito) : this(numConta, nome)
        {
            SaldoConta = deposito;
        }

        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }

        public  void Saque(double valor)
        {
            SaldoConta -= valor + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo $ {SaldoConta.ToString("F2")}"; 
        }


    }
}
