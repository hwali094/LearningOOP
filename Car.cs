using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    public class Car
    {
        private string _make;
        private string model;
        private int year;

        public Car(string make, string model, int year)
        {
            _make = make;
            this.model = model;
            this.year = year;
        }

        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {_make}, Model: {model}, Year: {year}");
        }
    }
}
