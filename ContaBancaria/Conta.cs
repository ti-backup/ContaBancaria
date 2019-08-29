using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        public const string ValorDebitoMaiorQueSaldo = 
            "Não é possível debitar um valor maior que o saldo";
        public const string ValorDebitoMenorQueZero =
            "Não é possível debitar um valor negativo";
        public const string ValorDebitoIgualZero =
            "Não é possível debitar o valor zero";

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
            if (valor > this.saldo)
                throw new ArgumentOutOfRangeException("valor", valor, ValorDebitoMaiorQueSaldo);
            if (valor < 0)
                throw new ArgumentOutOfRangeException("valor", valor, ValorDebitoMenorQueZero);
            if (valor == 0)
                throw new ArgumentOutOfRangeException("valor", valor, ValorDebitoIgualZero);

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
