using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercicio02
{
    public class Banco
    {
        static void Main(string[] args)
        {
            // Referência de Objeto da Conta Corrente
            ContaCorrente contaCorrente = new ContaCorrente("Raiane Caroline", 5000m);
            contaCorrente.Depositar(1000m);
            contaCorrente.Sacar(1000m);
            contaCorrente.ConsultarSaldo();

            Console.WriteLine();

            // Referência de Objeto da Conta Poupança
            ContaPoupanca contaPoupanca = new ContaPoupanca("Raiane Caroline", 10000m);
            contaPoupanca.Depositar(10000m);
            contaPoupanca.AplicacaoInvestimento();
            contaPoupanca.Sacar(5000m);
            contaPoupanca.ConsultarSaldo();

            Console.WriteLine();

            // Referência de Objeto da Conta de Investimento
            ContaInvestimento contaInvestimento = new ContaInvestimento("Raiane Caroline", 5000m);
            contaInvestimento.Depositar(2000m);
            contaInvestimento.AplicacaoInvestimento();
            contaInvestimento.Sacar(1000m);
            contaInvestimento.ConsultarSaldo();

        }
    }
}
