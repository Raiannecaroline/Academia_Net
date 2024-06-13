using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercicio02
{
    public class ContaCorrente : ContaBancaria
    {

        public decimal limite { get; set; }

        public ContaCorrente(string titular, decimal saldo) : base(titular, saldo) 
        { 
            this.limite = limite;
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo + limite)
            {
                Saldo -= valor;
                Console.WriteLine($"Sr(a) {Titular} o valo de seu saque é de R${valor} reais. O seu novo saldo é de R${Saldo} reais ");
            }
            else
            {
                Console.WriteLine($"Sr(a) {Titular}, seu saldo é insuficiente para estar sacando, mesmo com limite");
            }
        }

    }
}
