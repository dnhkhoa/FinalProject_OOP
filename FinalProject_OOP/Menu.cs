using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject_OOP
{
    public static class Menu
    {
        public static List<Coffee> Coffees = new List<Coffee>
        {
        new Coffee("Espresso", 2.5),
        new Coffee("Latte", 3.5),
        new Coffee("Cappuccino", 4.5),
        new Coffee("Americano", 2.0)
        };
    }
}