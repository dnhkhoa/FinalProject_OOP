using System;
using System.Collections.Generic;

namespace FinalProject_OOP
{
    public static class MenuShop
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
