using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Qual a temperatura registrada hoje? \n");
            int temperaturaConvertida = Convert.ToInt32( Console.ReadLine() );


            Console.WriteLine("Deseja ver a temperatura em °C (Opção 1) ou °F (Opção 2): \n");
            int opcaoEscolhida = Convert.ToInt32( Console.ReadLine());

            switch ( opcaoEscolhida )
            {
                case 1:
                    int temperaturaCelcius = (temperaturaConvertida - 32) * 5 / 9;
                    Console.WriteLine($"A temperatura em Celsius é de {temperaturaCelcius}°C\n");
                    break;
                case 2:
                    int temperaturaFahrenheit = (temperaturaConvertida * 9 / 5) + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é de {temperaturaFahrenheit}°F");
                    break;

                default:
                    Console.WriteLine("Nenhuma opção escolhida");
                    break;
            }
        }
    }
}
