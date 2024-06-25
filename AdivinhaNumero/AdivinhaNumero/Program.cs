using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinhaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 11);
            int tentativas = 3;

            Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!");
            Console.WriteLine("Eu escolhi um número entre 1 e 10. Você tem 3 tentativas para adivinhar qual é esse número.");

            for (int i = 0; i < tentativas; i++)
            {
                Console.Write("Qual é o seu palpite? ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você adivinhou o número.");
                    return;
                }
                else
                {
                    Console.WriteLine("Errado. Tente novamente.");
                }
            }

            Console.WriteLine($"Você não conseguiu adivinhar o número. O número era {numeroSecreto}.");
        }
    }
}
