using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    class Toy:Items //This class follows the Dependency Inversion Principle as the high level class, Items is not dependant on the low-level class, Toy.
    {
        private string name;
        private double price;
        private int effectiveness;

        public Toy(string toyName, double toyPrice, int toyEffectivness) : base (toyName, toyPrice)
        {
            this.name = toyName;
            this.price = toyPrice;
            this.effectiveness = toyEffectivness;
        }

        public int GetEffectivness()
        {
            return effectiveness;
        }
    }
}
