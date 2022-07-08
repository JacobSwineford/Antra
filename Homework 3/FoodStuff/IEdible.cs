using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Marker Inteface for different types of foods, marking them as edible or not.
 * Note that foods marked by this interface are not necessarily edible based on
 * it's condition, and should be checked for it's condition before deeming
 * a food as completely edible.
 */

namespace Homework_3.FoodStuff
{
    internal interface IEdible {

        /*
         * Eat the food marked by this interface, and gain some amount of energy based on the food.
         * Example of abstraction.
         */
        public double eat();
    
    }
}
