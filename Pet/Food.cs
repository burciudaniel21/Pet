using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    class Food : Items //This class follows the Dependency Inversion Principle as the high level class, Items is not dependant on the low-level class, Food.
    {
        private string name;
        private double price;
        private int effectiveness;
        public Food(string foodName, double foodPrice, int foodEffectiveness) : base(foodName, foodPrice)
        {
            this.name = foodName;
            this.price = foodPrice;
            this.effectiveness = foodEffectiveness;
        }

        public int GetEffectivness()
        {
            return effectiveness;
        }
    }
}
