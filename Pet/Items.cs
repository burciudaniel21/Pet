using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    public class Items //This class follows the Open Closed Principle as it is open for extension but closed for modification. If the user wants to create a different type of item, the class is easy to extend but there is no need to modify its core functionalities.

    {
        private string name;
        private double price;
        public Items(string itemName, double itemPrice) 
        {
            name = itemName;
            price = itemPrice;
        }

        public string GetItemName()
        {
            return name;
        }

        public double GetItemPrice()
        {
            return price;
        }

    }
}
