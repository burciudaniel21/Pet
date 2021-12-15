using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    public abstract class IPet : Room
    {
        public abstract string GetName();
        public abstract double PetMood();
        public abstract string UpdatePetStatus();
        public abstract int GetPetHp();
        public abstract void Heal(int amount);
        public abstract void Play(int amount);
        public abstract void UpdateMood();
        public abstract void UpdateHP();
        public abstract void DisplayPet();
        public abstract string UpdatePetVisual();
        public abstract int HpBar();
        //public abstract void HP0();
        public abstract void UpdateHunger();
        public abstract string GetHunger();
        public abstract void FeedPet(int amount);
        //public abstract int TempHunger();
        public abstract int PetPreferredTemp();
        public abstract void UpdateByRoomTemperature();
        public abstract string GetType();
    }
}
