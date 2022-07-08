using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.FoodStuff
{
    internal class Food
    {

        // example of encapsulation
        protected string quality { get; set; }
        protected string name { get; set; }
        protected double price { get; set; }

        protected Food(string name, string quality, double price)
        {
            this.name = name;
            this.quality = quality;
            this.price = price;
        } 

    }
}
