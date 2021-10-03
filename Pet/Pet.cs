using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    class Pet
    {
        private string petStatus;
        private double petMood = 100;
        private int petHp = 100;
        private int petHunger = 0;
        public Pet()
        {

        }

        public double PetMood()
        {
            return petMood;
        }

        public string PetStatus()
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

        public int PetHp()
        {
            return petHp;
        }

        public void Heal()
        {
            petHp += 30;
        }

        public void Play()
        {
            petMood += 15;
        }

        public void MoodChange()
        {
            petMood -= 0.005;
        }
    }
}
