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
        new Coffee("Espresso", 30000),
        new Coffee("Latte", 35000),
        new Coffee("Cappuccino", 45000),
        new Coffee("Americano", 25000)
        };
    }
}