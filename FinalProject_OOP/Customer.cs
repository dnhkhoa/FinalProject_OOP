using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject_OOP
{
    public class Customer : Person
    {

        public string Order { get; set; }

        public Customer(string name, string contactInfo) : base(name, contactInfo) { }

        public void PlaceOrder(string coffeeName)
        {
            Order = coffeeName;
            Console.WriteLine($"{Name} ordered {coffeeName}.");
        }

        public void PayForOrder(decimal amount)
        {
            Console.WriteLine($"{Name} paid {amount:C} for the order.");
        }
    }
}