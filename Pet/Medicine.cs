using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    public class Medicine: Items //This class follows the Dependency Inversion Principle as the high level class, Items is not dependant on the low-level class, Medicine.
    {
        private string name;
        private double price;
        private int effectiveness;
         public Medicine(string medicineName, double medicinePrice, int medicineEffectiveness) : base(medicineName, medicinePrice)
         {
            this.name = medicineName;
            this.price = medicinePrice;
            this.effectiveness = medicineEffectiveness;
         }

        public int GetEffectivness()
        {
            return effectiveness;
        }
    }
}
