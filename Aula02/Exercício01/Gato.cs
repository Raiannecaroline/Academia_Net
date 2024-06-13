using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Academia_Net
{
    public class Gato : Animal
    {
        public Gato(string name, int age, string color, double weight) : base(name, age, color, weight) { }

        public override void Sound()
        {
            Console.WriteLine($"{name} faz: meowww meowww");
        }

        public void Rononar()
        {
            Console.WriteLine($"{name} gostou de você e está ronronando....");
        }

        public void Brincar()
        {
            Console.WriteLine($"{name} está brincando com você...");
            Rononar();
        }
    }
}
