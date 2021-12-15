using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    class Shop : CoinsHandler
    {
        private List<Items> items = new List<Items>();

        private int reptoBoostStock, reptoMedicineStock, aquaBoostStock, pimafixFishStock, generalMedicineStock, aquarianStock, jellyStock, cricketsStock, fruitsStock, foodStock, ballStock, mirrorStock, fishRingStock;
        private string userItemChoice;

        bool buyingItems = true;
        Toy ball = new Toy("Ball", 13, 20);
        Toy mirror = new Toy("Mirror", 10, 25);
        Toy fishRing = new Toy("Fish Ring", 3, 20);
        Food aquarian = new Food("Aquarian", 6, 30);
        Food jelly = new Food("Jelly", 3.69, 25);
        Food crickets = new Food("Crickets", 4.99, 40);
        Food fruits = new Food("Fruits", 9.09, 70);
        Food food = new Food("Food", 10, 50);
        Medicine reptoBoost = new Medicine("Repto Boost", 19.48, 100);
        Medicine reptoMedicine = new Medicine("Repto Medicine", 7.33, 50);
        Medicine aquaBoost = new Medicine("Aqua Boost", 6.44, 40);
        Medicine pimafixFish = new Medicine("Pimafix", 16.05, 100);
        Medicine medicine = new Medicine("General Use Medicine", 15.00, 60);

        public void ShopMenu(string petCategory) //displays the shop menu available to the user depending on the type of pet selected and takes the item selection input from the user
        {
            buyingItems = true;
            while (buyingItems)
            {
                Console.Clear();
                Console.WriteLine($"You have {ShowCoins()} coins.");
                Console.WriteLine("Press |1| to buy toys for your pet.");
                Console.WriteLine("Press |2| to buy food for your pet.");
                Console.WriteLine("Press |3| to buy medicine for your pet.");

                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                Console.Clear();
                switch (userChoice.Key)
                {
                    case ConsoleKey.D1:
                        if(petCategory == "lizard")
                        {
                            Console.WriteLine($"Press 1 to buy a {ball.GetItemName()}. Price - {ball.GetItemPrice()}\nPress 2 to buy a {mirror.GetItemName()}. Price - {mirror.GetItemPrice()}");
                            userItemChoice = Console.ReadLine();
                            if(userItemChoice == "1")
                            {
                                BuyItem(ball);
                            }
                            else if (userItemChoice == "2")
                            {
                                BuyItem(mirror);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        else if(petCategory == "fish")
                        {
                            Console.WriteLine($"Press 1 to buy a {mirror.GetItemName()}. Price - {mirror.GetItemPrice()}\nPress 2 to buy a {fishRing.GetItemName()}. Price - {fishRing.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(mirror);
                            }

                            else if(userItemChoice == "2")
                            {
                                BuyItem(fishRing);
                            }

                            else
                            {
                                Invalid();
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Press 1 to buy a {ball.GetItemName()}. Price - {ball.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(ball);
                            }

                            else
                            {
                                Invalid();
                            }
                        }
                        BuyMore();
                        break;
                    case ConsoleKey.D2:
                        if (petCategory == "lizard")
                        {
                            Console.WriteLine($"Press 1 to buy a {jelly.GetItemName()}. Price - {jelly.GetItemPrice()}\nPress 2 to buy {crickets.GetItemName()}. Price - {crickets.GetItemPrice()}\nPress 3 to buy {fruits.GetItemName()} {fruits.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(jelly);
                            }
                            else if (userItemChoice == "2")
                            {
                                BuyItem(crickets);
                            }
                            else if (userItemChoice == "3")
                            {
                                BuyItem(fruits);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        else if(petCategory == "fish")
                        {
                            Console.WriteLine($"Press 1 to buy {aquarian.GetItemName()}. Price - {aquarian.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(aquarian);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Press 1 to buy {food.GetItemName()}. Price - {food.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(food);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        BuyMore();
                        break;
                    case ConsoleKey.D3:
                        if (petCategory == "lizard")
                        {
                            Console.WriteLine($"Press 1 to buy {reptoBoost.GetItemName()}. Price - {reptoBoost.GetItemPrice()}\nPress 2 to buy a {reptoMedicine.GetItemName()}. Price - {reptoMedicine.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(reptoBoost);
                            }
                            else if (userItemChoice == "2")
                            {
                                BuyItem(reptoMedicine);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        else if(petCategory == "fish")
                        {
                            Console.WriteLine($"Press 1 to buy a {aquaBoost.GetItemName()} Price - {aquaBoost.GetItemPrice()}\nPress 2 to buy a {pimafixFish.GetItemName()}. Price - {pimafixFish.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(aquaBoost);
                            }
                            else if (userItemChoice == "2")
                            {
                                BuyItem(pimafixFish);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Press 1 to buy {medicine.GetItemName()}. Price - {medicine.GetItemPrice()}");
                            string userItemChoice = Console.ReadLine();
                            if (userItemChoice == "1")
                            {
                                BuyItem(medicine);
                            }
                            else
                            {
                                Invalid();
                            }
                        }
                        BuyMore();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Thread.Sleep(1500);
                        break;
                }
            }
            
        } 

        private bool BuyMore() //allows the user to continue buying or to leave the shop
        {
            Console.Clear();
            Console.WriteLine("Would you like to continue shopping?\n1 - Yes\n2 - No");
            string userChoice =Console.ReadLine();
            if(userChoice == "1")
            {
                buyingItems = true;
            }
            if (userChoice == "2")
            {
                buyingItems = false;
                UpdateItemsStock();
            }
            return buyingItems;
        }

        private void Buy(Items item) //deducts the coins required for the transaction and add the item to the inventory
        {
            DeductCoins(item.GetItemPrice());
            items.Add(item);
        }

        private void BuyItem(Items item) //checks if the balance available is enough to proceed with the transaction
        {
            Console.Clear();
            if ( ShowCoins() >= item.GetItemPrice())
            {
                Buy(item);
                Console.WriteLine("Successful purchase.");
                Thread.Sleep(1000);
            }
            else if (ShowCoins() < item.GetItemPrice())
            {
                Console.WriteLine("Not enough coins.");
                Thread.Sleep(1000);
            }
        }

        private void Invalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid option.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
        }

        public void UpdateItemsStock() //updates the number of each items available in the inventory of the user
        {
            int reptoBoostStock = 0, reptoMedicineStock = 0, aquaBoostStock = 0, pimafixFishStock = 0, generalMedicineStock = 0, aquarianStock = 0, jellyStock = 0, cricketsStock = 0, fruitsStock = 0, foodStock = 0, ballStock = 0, mirrorStock = 0, fishRingStock = 0;

            foreach (Items medicine in items)
            {

                if (medicine.GetItemName() == "Repto Boost")
                {
                    reptoBoostStock++;
                }
                if (medicine.GetItemName() == "Repto Medicine")
                {
                    reptoMedicineStock++;
                }
                if (medicine.GetItemName() == "Aqua Boost")
                {
                    aquaBoostStock++;
                }
                if (medicine.GetItemName() == "Pimafix")
                {
                    pimafixFishStock++;
                }
                if (medicine.GetItemName() == "General Use Medicine")
                {
                    generalMedicineStock++;
                }
            }
            foreach (Items food in items)
            {
                if (food.GetItemName() == "Aquarian")
                {
                    aquarianStock++;
                }
                if (food.GetItemName() == "Crickets")
                {
                    cricketsStock++;
                }
                if (food.GetItemName() == "Fruits")
                {
                    fruitsStock++;
                }
                if (food.GetItemName() == "Food")
                {
                    foodStock++;
                }
                if (food.GetItemName() == "Jelly")
                {
                    jellyStock++;
                }
            }
            foreach (Items toy in items)
            {
                if (toy.GetItemName() == "Ball")
                {
                    ballStock ++;
                }
                if (toy.GetItemName() == "Mirror")
                {
                    mirrorStock++;
                }
                if (toy.GetItemName() == "Fish Ring")
                {
                    fishRingStock++;
                }
            }
            this.reptoBoostStock = reptoBoostStock;
            this.reptoMedicineStock = reptoMedicineStock;
            this.aquaBoostStock = aquaBoostStock;
            this.pimafixFishStock = pimafixFishStock;
            this.generalMedicineStock = generalMedicineStock;
            this.aquarianStock = aquarianStock;
            this.jellyStock = jellyStock;
            this.cricketsStock = cricketsStock;
            this.fruitsStock = fruitsStock;
            this.foodStock = foodStock;
            this.ballStock = ballStock;
            this.mirrorStock = mirrorStock;
            this.fishRingStock = fishRingStock;
        }

        public void DisplayItemsStock() //displays what is available in the user's inventory
        {

                Console.Clear();
                Console.WriteLine("You currently have the following items:");
                DisplayFoodStock();
                DisplayToyStock();
                DisplayMedicineStock();
                Thread.Sleep(1000);       

            //private int  aquarianStock, jellyStock, cricketsStock, fruitsStock, foodStock

        }

        public void DisplayMedicineStock() //displays the medicine type of items
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMedicine:\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (reptoBoostStock > 0)
            {
                Console.WriteLine($"{reptoBoost.GetItemName()} - {reptoBoostStock}");
            }

            if (reptoMedicineStock > 0)
            {
                Console.WriteLine($"{reptoMedicine.GetItemName()} - {reptoMedicineStock}");
            }

            if (aquaBoostStock > 0)
            {
                Console.WriteLine($"{aquaBoost.GetItemName()} - {aquaBoostStock}");
            }

            if (pimafixFishStock > 0)
            {
                Console.WriteLine($"{pimafixFish.GetItemName()} - {pimafixFishStock}");
            }

            if (generalMedicineStock > 0)
            {
                Console.WriteLine($"{medicine.GetItemName()} - {generalMedicineStock}");
            }
        }
        public void DisplayToyStock() //displays the toy type of items
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nToys:\n");
            Console.ForegroundColor = ConsoleColor.White;
            if (ballStock > 0)
            {
                Console.WriteLine($"{ball.GetItemName()} - {ballStock}");
            }

            if (mirrorStock > 0)
            {
                Console.WriteLine($"{mirror.GetItemName()} - {mirrorStock}");
            }

            if (fishRingStock > 0)
            {
                Console.WriteLine($"{fishRing.GetItemName()} - {fishRingStock}");
            }
        }
        public void DisplayFoodStock() //displays the food type of items
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFood:\n"); 
            Console.ForegroundColor = ConsoleColor.White;
            if (aquarianStock > 0)
            {
                Console.WriteLine($"{aquarian.GetItemName()} - {aquarianStock}");
            }

            if (jellyStock > 0)
            {
                Console.WriteLine($"{jelly.GetItemName()} - {jellyStock}");
            }

            if (cricketsStock > 0)
            {
                Console.WriteLine($"{crickets.GetItemName()} - {cricketsStock}");
            }

            if (fruitsStock > 0)
            {
                Console.WriteLine($"{fruits.GetItemName()} - {fruitsStock}");
            }

            if (foodStock > 0)
            {
                Console.WriteLine($"{food.GetItemName()} - {foodStock}");
            }
        }

        public void RemoveFromInventory(Items item)
        {
            items.Remove(item);
            UpdateItemsStock();
        }

        public int SelectFood() //allows the user to select the food available in its inventory and returns its effectivness value to be used by the pet.
        {
            int selectionA = 0;
            int selectionB = 0;
            int selectionC = 0;
            int selectionD = 0;
            int selectionE = 0;

            int i = 0;

            Console.Clear();
            UpdateItemsStock();
            DisplayFoodStock();
            Console.WriteLine();
            if (aquarianStock > 0)
            {
                i++;
                selectionA = i;
                Console.WriteLine($"Press {selectionA} to feed the pet {aquarian.GetItemName()}.");
            }

            if (jellyStock > 0)
            {
                i++;
                selectionB = i;
                Console.WriteLine($"Press {selectionB} to feed the pet {jelly.GetItemName()}.");
            }

            if (cricketsStock > 0)
            {
                i++;
                selectionC = i;
                Console.WriteLine($"Press {selectionC} to feed the pet {crickets.GetItemName()}.");
            }

            if (fruitsStock > 0)
            {
                i++;
                selectionD = i;
                Console.WriteLine($"Press {selectionD} to feed the pet  {fruits.GetItemName()}.");
            }

            if (foodStock > 0)
            {
                i++;
                selectionE = i;
                Console.WriteLine($"Press {selectionE} to feed the pet  {food.GetItemName()}.");
            }

            int intUserChoice;
            int.TryParse(Console.ReadLine() , out intUserChoice);

            Food selectedItem = null;

            if(intUserChoice == selectionA && selectionA != 0 && aquarianStock > 0)
            {
                selectedItem = aquarian;
                RemoveFromInventory(aquarian);
            }

            else if (intUserChoice == selectionB && selectionB != 0 && jellyStock > 0)
            {
                selectedItem = jelly;
                RemoveFromInventory(jelly);
            }

            else if (intUserChoice == selectionC && selectionC != 0 && cricketsStock > 0)
            {
                selectedItem = crickets;
                RemoveFromInventory(crickets);
            }

            else if (intUserChoice == selectionD && selectionD != 0 && fruitsStock > 0)
            {
                selectedItem = fruits;
                RemoveFromInventory(fruits);
            }

            else if (intUserChoice == selectionE && selectionE != 0 && foodStock > 0)
            {
                selectedItem = food;
                RemoveFromInventory(food);
            }
            else
            {
                Invalid();            
            }

            UpdateItemsStock();

            int toFeedPet = 0;

            if (selectedItem != null)
            {
                toFeedPet = selectedItem.GetEffectivness();
            }

            return toFeedPet;
        }

        public int SelectToy()//allows the user to select the toy available in its inventory and returns its effectivness value to be used by the pet.
        {
            int selectionA = 0;
            int selectionB = 0;
            int selectionC = 0;


            int i = 0;

            Console.Clear();
            UpdateItemsStock();
            DisplayToyStock();
            Console.WriteLine();
            if (ballStock > 0)
            {
                i++;
                selectionA = i;
                Console.WriteLine($"Press {selectionA} to use {ball.GetItemName()}.");
            }

            if (mirrorStock > 0)
            {
                i++;
                selectionB = i;
                Console.WriteLine($"Press {selectionB} to use {mirror.GetItemName()}.");
            }

            if (fishRingStock > 0)
            {
                i++;
                selectionC = i;
                Console.WriteLine($"Press {selectionC} to use {fishRing.GetItemName()}.");
            }

            int intUserChoice;
            int.TryParse(Console.ReadLine(), out intUserChoice);

            Toy selectedItem = null;

            if (intUserChoice == selectionA && selectionA != 0 && ballStock > 0)
            {
                selectedItem = ball;
                RemoveFromInventory(ball);
            }

            else if (intUserChoice == selectionB && selectionB != 0 && mirrorStock > 0)
            {
                selectedItem = mirror;
                RemoveFromInventory(mirror);
            }

            else if (intUserChoice == selectionC && selectionC != 0 && fishRingStock > 0)
            {
                selectedItem = fishRing;
                RemoveFromInventory(fishRing);
            }

            else
            {
                Invalid();
            }

            UpdateItemsStock();

            int toIncrease = 0;

            if (selectedItem != null)
            {
                toIncrease = selectedItem.GetEffectivness();
            }

            return toIncrease;
        }
        public int SelectMedicine() //allows the user to select the medicine available in its inventory and returns its effectivness value to be used by the pet.
        {
            int selectionA = 0;
            int selectionB = 0;
            int selectionC = 0;
            int selectionD = 0;
            int selectionE = 0;

            int i = 0;

            Console.Clear();
            UpdateItemsStock();
            DisplayMedicineStock();
            Console.WriteLine();
            if (reptoBoostStock > 0)
            {
                i++;
                selectionA = i;
                Console.WriteLine($"Press {selectionA} to feed the pet {reptoBoost.GetItemName()}.");
            }

            if (reptoMedicineStock > 0)
            {
                i++;
                selectionB = i;
                Console.WriteLine($"Press {selectionB} to feed the pet {reptoMedicine.GetItemName()}.");
            }

            if (aquaBoostStock > 0)
            {
                i++;
                selectionC = i;
                Console.WriteLine($"Press {selectionC} to feed the pet {aquaBoost.GetItemName()}.");
            }

            if (pimafixFishStock > 0)
            {
                i++;
                selectionD = i;
                Console.WriteLine($"Press {selectionD} to feed the pet  {pimafixFish.GetItemName()}.");
            }

            if (generalMedicineStock > 0)
            {
                i++;
                selectionE = i;
                Console.WriteLine($"Press {selectionE} to feed the pet  {medicine.GetItemName()}.");
            }

            int intUserChoice;
            int.TryParse(Console.ReadLine(), out intUserChoice);

            Medicine selectedItem = null;

            if (intUserChoice == selectionA && selectionA != 0 && reptoBoostStock > 0)
            {
                selectedItem = reptoBoost;
                RemoveFromInventory(reptoBoost);
            }

            else if (intUserChoice == selectionB && selectionB != 0 && reptoMedicineStock > 0)
            {
                selectedItem = reptoMedicine;
                RemoveFromInventory(reptoMedicine);
            }

            else if (intUserChoice == selectionC && selectionC != 0 && aquaBoostStock > 0)
            {
                selectedItem = aquaBoost;
                RemoveFromInventory(aquaBoost);
            }

            else if (intUserChoice == selectionD && selectionD != 0 && pimafixFishStock > 0)
            {
                selectedItem = pimafixFish;
                RemoveFromInventory(pimafixFish);
            }

            else if (intUserChoice == selectionE && selectionE != 0 && generalMedicineStock > 0)
            {
                selectedItem = medicine;
                RemoveFromInventory(medicine);
            }
            else
            {
                Invalid();
            }

            UpdateItemsStock();

            int toHeal = 0;

            if (selectedItem != null)
            {
                toHeal = selectedItem.GetEffectivness();
            }

            return toHeal;
        }
    }
}
