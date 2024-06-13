using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Aula02.Exercicio04
{
    public abstract class FormaGeometrica
    {
        public double Largura {  get; set; }
        public double Altura { get; set; }

        public FormaGeometrica(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public abstract double CalcularArea();
        
    }
}
