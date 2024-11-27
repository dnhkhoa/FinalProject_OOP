using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject_OOP
{
    public class Manager : Person
    {
        public List<string> Inventory { get; set; } = new List<string>();

        public Manager(string name, string contactInfo) : base(name, contactInfo) { }

        public void ManageInventory(string item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{Name} added {item} to inventory.");
        }
    }
}