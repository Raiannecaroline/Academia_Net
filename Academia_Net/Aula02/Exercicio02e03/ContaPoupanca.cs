using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercicio02
{
    public class ContaPoupanca : ContaBancaria
    {

        public decimal TaxaRendimento { get; set; }

        public ContaPoupanca(string titular, decimal saldo) : base(titular, saldo) 
        { 
            this.TaxaRendimento = TaxaRendimento;
        }


        public void AplicacaoInvestimento()
        {
            decimal rendimento = Saldo * TaxaRendimento / 100;
            Saldo += rendimento;
            Console.WriteLine($"Sr(a) {Titular} o seu rendimento aplicado foi de R${rendimento} reais. O seu novo rendimento passa a ser R${Saldo}");
        }

    }
}
