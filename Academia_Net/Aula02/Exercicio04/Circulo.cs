using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Aula02.Exercicio04
{
    public class Circulo : FormaGeometrica
    {
        public double Raio {  get; set; }

        public Circulo(double raio) : base(0, 0) 
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
