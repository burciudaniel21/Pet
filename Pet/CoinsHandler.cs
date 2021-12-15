using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    public class CoinsHandler
    {
        private static double coins=50;
        public CoinsHandler() { }

        public void UpdateCoins() //increase amount of coins over time
        {
            while (true)
            {
                coins++;
                Thread.Sleep(1500);
            }
        }

        public double ShowCoins() //display available amount of coins
        {
            return coins;
        }

        public void DeductCoins(double amount) //deducts from coins
        {
            coins -= amount;
        }
    }
}
