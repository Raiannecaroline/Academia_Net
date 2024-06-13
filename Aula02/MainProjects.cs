using Academia_Net.Exercício01;
using Academia_Net.Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net
{
    public class MainProjects
    {
        static void Main(string[] args)
        {

            //Exercício 01 abaixo:

            /*Animal gato = new Gato("Luke", 4, "Preto", 4.5);
            Animal cachorro = new Cachorro("Laios", 5, "Malhado", 12);

            gato.Sound();
            cachorro.Sound();

            gato.Walk();
            cachorro.Walk();

            gato.Eat();
            cachorro.Eat();

            ((Cachorro) cachorro).AbanarRabo();
            ((Gato)gato).Rononar();*/

            /*Exercício 02 abaixo:*/

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
