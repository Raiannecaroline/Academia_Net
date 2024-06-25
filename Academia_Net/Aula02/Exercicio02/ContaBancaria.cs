using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercicio02
{
    public class ContaBancaria
    {

        public string Titular { get; set; }
        public decimal Saldo {  get; set; }

        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria(decimal saldo, string titular)
        {
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O seu Depósito é de R${valor} reais. Aqui o seu novo saldo R${Saldo} reais");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"O seu saque foi de R${valor} reais. Aqui o seu novo saldo é de R${Saldo} reais");

            }
            else
            {
                Console.WriteLine("O seu saldo é insuficiente para sacar!");
            }

        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Sr(a) {Titular} o seu saldo é de R${Saldo} reais");
        }
    }
}
