using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercicio02
{
    public class ContaInvestimento : ContaBancaria
    {

        public decimal TaxaJuros { get; set; }


        public ContaInvestimento(string titular, decimal saldo) : base(titular, saldo)
        {
            TaxaJuros = TaxaJuros;
        }

        public void AplicacaoInvestimento()
        {
            decimal rendimento = Saldo * TaxaJuros / 100;
            Saldo += rendimento;
            Console.WriteLine($"Sr(a) {Titular} o seu rendimento aplicado foi de R${rendimento} reais. O seu novo rendimento passa a ser R${Saldo}");
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                base.Sacar(valor);
            } else
            {
                Console.WriteLine($"Sr(a) {Titular}, seu saldo paa realiza o saque do rendimento ainda é insuficiente");
            }
        }
    }
}
