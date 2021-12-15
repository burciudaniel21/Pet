using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    public class CreatePet
    {
        public List<IPet> listOfPets = new List<IPet>();
        bool inMenu = true;
        public string userInput = "";
        public CreatePet() { }
        public void CreateUserPet() //selects the type of pet to be created and assign a name to the pet
        {
            Console.WriteLine("Select pet type:\n 1-Fish\n 2-Reptile\n 3-Display existing pets.");
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.Clear();
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                inMenu = false;
            }
            switch (keyPressed.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You have selected \"Fish\". Input pet name:");
                    userInput = Console.ReadLine();
                    Fish fish = new Fish(userInput);
                    listOfPets.Add(fish);

                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You have selected \"Reptile\". Input pet name:");
                    userInput = Console.ReadLine();
                    Console.Clear();
                    Reptile reptile = new Reptile(userInput);
                    listOfPets.Add(reptile);
                    break;
                case ConsoleKey.D3:
                    Console.Write($"You currently have {listOfPets.Count} pets.");
                    Console.Clear();
                    DisplayListOfPets();
                    break;
            }
        }

        public List<IPet> GetList()
        {
            return listOfPets;
        }

        public IPet SelectPet()
        {
            DisplayListOfPets();
            Console.WriteLine("Select pet:");
            if (listOfPets.Count > 0)
            {
                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    return listOfPets[userInput - 1];
                }
                else
                {
                    RedText("Invalid option", true);
                    Thread.Sleep(1500);
                    return null;
                }
            }
            else
            {
                RedText("Invalid option.", true);
                return null;
            }

        }
        public string RedText(string text, bool newLine) //turns the text red
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
            if (newLine == true)
            {
                Console.WriteLine();
            }
            if (newLine == false)
            {

            }

            return text;

        }
        public void DisplayListOfPets()
        {
            Console.Clear();
            if(listOfPets.Count > 0)
            {
                int i = 0;
                foreach (IPet pet in listOfPets)
                {
                    i++;
                    Console.WriteLine($"{i} - {pet.GetName()}\n");
                }
            }
            else
            {
                RedText("List is empty. Please create a pet.", true);
                CreateUserPet();
            }

        }

    }

}
