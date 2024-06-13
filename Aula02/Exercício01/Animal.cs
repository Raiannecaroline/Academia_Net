using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_Net
{
    public abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string color { get; set; }
        public double weight { get; set; }

        public Animal(string name, int age, string color, double weight)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.weight = weight;
        }

        public abstract void Sound();

        public virtual void Eat()
        {
            Console.WriteLine($"{name} está comendo...");
        }

        public virtual void Walk()
        {
            Console.WriteLine($"{name} está andando...");

        }
    }
}
