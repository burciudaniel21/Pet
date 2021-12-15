using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Pet
{
    class Menu
    {
        private bool inMenu = true;
        private CreatePet createPet = new CreatePet();
        private readonly Room room = new Room();
        private CoinsHandler coins = new CoinsHandler();
        private Shop shop = new Shop();
        IPet pet;

        Thread threadOne;
        Thread roomTemperature;
        Thread petHp;
        Thread updateCoins;
        Thread updateHunger;
        Thread temperature;

        public void Create() //creates a new pet for the users
        {
            createPet.CreateUserPet();
            pet = createPet.SelectPet();

        }

        public void Run() //puts together all the methods required to run the program, including displaying methods, input taking methods and starting the required threads at the right time.
        {
            Create();
            threadOne = new Thread(pet.UpdateMood);
            roomTemperature = new Thread(room.CoolRoom);
            petHp = new Thread(pet.UpdateHP);
            updateCoins = new Thread(coins.UpdateCoins);
            updateHunger = new Thread(pet.UpdateHunger);
            temperature = new Thread(pet.UpdateByRoomTemperature);

            threadOne.Start();
            roomTemperature.Start();
            petHp.Start();
            updateCoins.Start();
            updateHunger.Start();
            temperature.Start();

            while (inMenu)
            {
                if (inMenu)
                {
                    DisplayMenu();
                    MenuOptions();
                    Thread.Sleep(400);
                    Console.Clear();
                }
                if (!inMenu)
                {
                    shop.ShopMenu(pet.GetType());
                    inMenu = true;
                }                
            }

        }

        public void MenuOptions() //takes the input for the user's selection of the menu's options
        {
            if (inMenu)
            {
                if (Console.KeyAvailable)
                {
                   ConsoleKeyInfo userChoice = Console.ReadKey(true);
                    switch (userChoice.Key)
                    {
                        case ConsoleKey.D1:
                            pet.FeedPet(shop.SelectFood());
                            break;
                        case ConsoleKey.D2:
                            pet.Play(shop.SelectToy());
                            break;
                        case ConsoleKey.D3:
                            pet.Heal(shop.SelectMedicine());
                            break;
                        case ConsoleKey.D4:
                            room.HeatRoom();
                            break;
                        case ConsoleKey.D5:
                            room.DecreaseTemperature();
                            break;
                        case ConsoleKey.D6:
                            inMenu = false;
                            //shop.ShopMenu(pet.GetType());
                            break;
                        case ConsoleKey.D7:
                            bool checkingInvetory = true;
                            while (checkingInvetory)
                            {
                                ConsoleKeyInfo userKeyChoice;
                                do
                                {
                                    shop.DisplayItemsStock();
                                    Console.WriteLine("\nPress ESC to return to the menu.");
                                    userKeyChoice = Console.ReadKey();
                                } while (userKeyChoice.Key != ConsoleKey.Escape);
                                checkingInvetory = false;
                            }
                            break;
                        case ConsoleKey.D8:
                            Console.Clear();
                            createPet.CreateUserPet();
                            Console.WriteLine("New pet created. Select the new pet ussing the appropriate option.");
                            Thread.Sleep(1000);
                            break;
                        case ConsoleKey.D9:
                            pet = createPet.SelectPet();
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }
                
            }
               
        }

        public void DisplayMenu() //displays the menu and the pet, including its stats to the user
        {
            if (inMenu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string('█', pet.HpBar()));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Pet hp is {pet.GetPetHp()}");
                Console.WriteLine(pet.GetName());
                //Console.WriteLine(pet.TempHunger());
                Console.WriteLine($"Pet preffered temperature is: {pet.PetPreferredTemp()} Your pet will be afected if the temperature goes 5 degrees higher or lower than {pet.PetPreferredTemp()}.");
                Console.WriteLine($"Current coins balance is: {coins.ShowCoins()}");
                Console.WriteLine($"Your pet's mood level is: {pet.PetMood()}");
                Console.WriteLine($"Your pet's is: {pet.GetHunger()}");
                Console.WriteLine($"Your pet is {pet.UpdatePetStatus()}");
                Console.WriteLine($"Room temperature is {room.GetTemperature()}\n");
                Console.WriteLine("Press |1| to feed pet.");
                Console.WriteLine("Press |2| to play with the pet.");
                Console.WriteLine("Press |3| to give medicine to the pet.");
                Console.WriteLine("Press |4| to heat the room.");
                Console.WriteLine("Press |5| to cool the room.");
                Console.WriteLine("Press |6| to open the Shop.");
                Console.WriteLine("Press |7| to check inventory.");
                Console.WriteLine("Press |8| to create a new pet");
                Console.WriteLine("Press |9| to select a pet from the list.\n\n\n");


                pet.DisplayPet();
            }
            
        }

    }
}

