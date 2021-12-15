using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    class Reptile:IPet //This class follows Liskov substitution principle as it is perfectly substitutable for the IPet class.
    {
        private string name;
        private string petStatus;
        private double petMood = 100;
        private int petHp = 100;
        private int hunger;
        private int preferredTemperature = 29;
        private string type = "lizard";

        public Reptile(string petName)
        {
            this.name = petName;
        }

        public override string GetType()
        {
            return type;
        }
        public override string GetName()
        {
            return name;
        }

        public override int HpBar() //updates the value needed to create the HP bar of the pet
        {
            int barLength = petHp / 10;
            return barLength;

        }

        public override string UpdatePetVisual() //updates the expression on the pet based on mood
        {
            string face ="";
            if (petMood > 55)
            {
                 face = "`-.__.-'";
            }
            else if (petMood > 20)
            {
                 face = "--.__.--";
            }
            else if (petMood <= 20)
            {
                 face = ",------,";

            }
                return face;
        }

        public override void DisplayPet() //displays the pet or a tombstone if the hp reaches 0
        {
            if (petHp > 0)
            {
                Console.WriteLine(
$@"              ____...---...___
___.....---'''        .       ''--..____
     .                  .            
 .             _.--._       /|
        .    .'()..()`.    / /
            ( {UpdatePetVisual()} )  ( (    
   .         \        /    \ \
       .      \      /      ) )       
            .' -.__.- `.-.-/_/
 .        .'  /-____-\  `.-'       
          \  /-.____.-\  /-.
           \ \`-.__.-'/ /\|\|           
          .'  `.    .'  `.
          |/\/\|    |/\/\|");
                //https://www.asciiart.eu/animals/reptiles/lizards
            }
            if (petHp == 0)
            {
                Console.WriteLine(@"

        _.---,._,'
       /' _.--.<
         /'     `'
       /' _.---._____
       \.'   ___, .-'`
           /'    \\             .
         /'       `-.          -|-
        |                       |
        |                   .-'~~~`-.
        |                 .'         `.
        |                 |  R  I  P  |
        |                 |           |
        |                 |           |
         \              \\|           |//
   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                //https://ascii.co.uk/art/rip
            }

        }
        public override void UpdateMood() //updates  the mood of the pet every second
        {
            while (true)
            {
                if(petMood > 0)
                {
                    petMood--;
                    Thread.Sleep(1000);
                }

            }
        }

        public override double PetMood()
        {
            return petMood;
        }

        public override string UpdatePetStatus() //update the mood of the pet as a text value to be displayed to the user
        {
            if (petMood >= 70)
            {
                  petStatus = "Happy";
            }
            else if (petMood >= 55)
            {
              petStatus = "Playful";
            }
            else if (petMood >= 20)
            {
                petStatus = "Gloomy";
            }
            else if (petMood >= 0)
            {
                petStatus = "Sad";
            }

            return petStatus;
        }

        public override void UpdateHP() //decrease pet hp every 2500 milliseconds
        {
            while (petHp > -1)
            {               
                Thread.Sleep(2500);
                if(petHp == 0)
                {
                    petHp = 0;
                }
                else
                {
                 petHp--;
                }
                
            }

        }

        public override int GetPetHp()
        {
            return petHp;
        }

        public override void Heal(int amount) //heals the pet and increase hunger depdending on the medicine.
        {
            if (petHp + amount > 100)
            {
                petHp = 100;  
            }
            else
            {
                petHp += amount;
            }
            hunger += amount / 2;
        }

        public override void Play(int amount) //increase the pet mood
        {
            if (petMood + amount > 100)
            {
                petMood = 100;
            }
            else
            {
                petMood += amount;
            }
        }

        //public override void HP0()
        //{
        //    petHp = 0;
        //}
        public override void UpdateHunger() //increase hunger every 1500 milliseconds
        {
            while (petHp > 0)
            {
                hunger++;
                if(hunger > 50)
                {
                    petHp--;
                }
                Thread.Sleep(1500);
            }
        }

        public override string GetHunger() //updates the hunger value as text
        {
            string hungerStatus = "";
            if (hunger > 50)
            {
                hungerStatus = "hungry";
            }
            if (hunger < 50)
            {
                hungerStatus = "stuffed";
            }
            return hungerStatus;

        }
        public override void FeedPet(int amount) //decrease the hunger of the pet based on the value given (which will be taken from the food type). The value decreased from the hunger is affected by the mood and hunger of the pet as well.
        {
            int amountEaten;
            amountEaten = (int)(amount*(petMood * (hunger)) / 2500);
            if (hunger - amountEaten >= 0)
            {
                hunger -= amountEaten;
            }
            else
            {
                hunger = 0;
            }

        }
        //public override int TempHunger()
        //{
        //    return hunger;
        //}

        public override int PetPreferredTemp()
        {
            return preferredTemperature;
        }
        public override void UpdateByRoomTemperature() //if room temperature is too high or too low, pet HP is affected
        {
            while (GetTemperature() > preferredTemperature + 5 || GetTemperature() < preferredTemperature - 5 && petHp > 0)
            {
                petHp--;
                Thread.Sleep(1500);
            }
        }
    }
}
