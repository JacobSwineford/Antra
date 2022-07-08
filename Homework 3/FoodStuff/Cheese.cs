﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.FoodStuff
{
    internal class Cheese : Food, IEdible
    {

        public Cheese(string name, string quality, double price) : base(name, quality, price) {}

        double IEdible.eat()
        {
            return 60;
        }
    }
}
