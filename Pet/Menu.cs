using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Pet
{
    class Menu
    {
        private bool inMenu;
        readonly Timer petTimer = new Timer();
        private readonly Room room = new Room();
        private readonly Pet pet = new Pet();

        public void InGameTimer()
        {
            petTimer.IncreaseTimer();
            if (petTimer.GetTimer() == 1000)
            {
                petTimer.CountSeconds();
            }

            
            
        }

        public void Display()
        { 
            while (true)
            {

                Console.WriteLine($"Your pet's HP is: {pet.PetMood()}");
                Console.WriteLine($"Your pet is {pet.PetStatus()}");
                Console.WriteLine($"Room temperature is {room.GetTemperature()}\n");
                Console.WriteLine("Press |1| to feed pet.");
                Console.WriteLine("Press |2| to play with the pet.");
                Console.WriteLine("Press |3| to give medicine to the pet.");
                Console.WriteLine("Press |4| to heat the room.");
                Console.WriteLine("Press |5| to cool the room.\n");
                Console.WriteLine(pet.PetMood());
                Console.WriteLine(petTimer.CountSeconds());

                if (petTimer.GetSeconds() >= 0)
                {
                    pet.MoodChange();
                }

                InGameTimer();

                ConsoleKeyInfo userChoice = Console.ReadKey(true);
                switch (userChoice.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        pet.Play();
                        break;
                    case ConsoleKey.D3:
                        pet.Heal();
                        break;
                    case ConsoleKey.D4:
                        room.HeatRoom();
                        break;
                    case ConsoleKey.D5:
                        room.CoolRoom();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                Console.Clear();
            }

        }

    }
}
