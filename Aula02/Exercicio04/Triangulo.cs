using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Aula02.Exercicio04
{
    public class Triangulo : FormaGeometrica
    {

        public Triangulo(double largura, double altura) : base(largura, altura) { }

        public override double CalcularArea()
        {
            return (Largura * Altura) / 2;
        }
    }
}
