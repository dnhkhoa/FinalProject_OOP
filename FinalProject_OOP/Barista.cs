using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject_OOP
{
    public class Barista : Person
    {
        public string ShiftDetails { get; set; }

        public Barista(string name, string contactInfo, string shiftDetails)
            : base(name, contactInfo)
        {
            ShiftDetails = shiftDetails;
        }

        public void PrepareCoffee(string coffeeName)
        {
            Console.WriteLine($"{Name} is preparing {coffeeName}.");
        }

        public void ServeCoffee(string coffeeName)
        {
            Console.WriteLine($"{Name} served {coffeeName}.");
        }
    }
}