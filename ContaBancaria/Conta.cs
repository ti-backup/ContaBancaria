using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        string nome;
        double saldo;

        public Conta(string nome, double saldo)
        {
            this.nome = nome;
            this.saldo = saldo;
        }

        public string getNome() { return this.nome; }
        public double getSaldo() { return this.saldo; }

        public void Debito(double valor)
        {
            if (valor > this.saldo || valor < 0)
                return;
            this.saldo -= valor;
        }

        public void Credito(double valor)
        {
            if (valor < 0)
                return;
            this.saldo += valor;
        }
    }
}
