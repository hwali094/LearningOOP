using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    // Abstraction: defining an abstract class with abstract method
    abstract class Animal
    {
        public abstract void Sound();
    }

    // Encapsulation: creating a class that encapsulates data and behavior
    class Dog : Animal
    {
        private string name;

        public Dog(string name)
        {
            this.name = name;
        }

        public override void Sound()
        {
            Console.WriteLine($"{name} says 'Woof!'");
        }
    }
}
