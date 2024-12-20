﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FinalProject_OOP
{
    public class Coffee
    {   
        public string CoffeeName { get; set; }

        public double Price { get; set; }
        public Coffee(string coffeeName, double price)
        {
            this.CoffeeName = coffeeName;
            this.Price = price;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Coffee: {CoffeeName}, Price: {Price:C}");
        }
        public double PriceBySize(string size)
        {
            double rate=1 ; // Rate mặc định cho size S
            if (size=="Small")
            {
                rate = 1;
            }
            else if (size=="Medium")
            {
                rate = 1.2;
            }
            else if (size=="Large")
            {
                rate = 1.4;
            }


            // Tính giá 
            return Price * rate;
        }
    }
}