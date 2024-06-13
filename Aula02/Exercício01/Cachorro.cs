using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net.Exercício01
{
    public class Cachorro : Animal
    {
        public Cachorro(string name, int age, string color, double weight) : base(name, age, color, weight) { }

        public override void Sound()
        {
            Console.WriteLine($"{name} faz: au au auuuu au");
        }

        public void AbanarRabo()
        {
            Console.WriteLine($"{name} gostou de você e está abanando o rabo...");
        }

        public void Brincar()
        {
            Console.WriteLine($"{name} está brincando com você...");
            AbanarRabo();
        }
    }
}
