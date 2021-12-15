using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    public class Room: IRoom //This class follows the Single Responsibility Principle as it has a small piece of responsibility. It only deals with anything related to the room and nothing more.
    {
        private int temperature = 20;
        public Room()
        {

        }

        public int GetTemperature()
        {
            return temperature;
        }

        public void CoolRoom() //decrease room temperature by one every 4500 milliseconds seconds
        {
            while (true)
            {
                if(temperature > -20)
                {
                    temperature -= 1;
                    Thread.Sleep(4500);
                }

            }
            
        }

        public void DecreaseTemperature() //decrease room temperature by one
        {
            if(temperature> -20)
            {
                temperature -= 1;
            }
        }

        public void HeatRoom() //increase room temperature by one
        {
            temperature += 1;
        }
    }
}
