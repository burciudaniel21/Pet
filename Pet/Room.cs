using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    class Room
    {
        private int temperature = 20;
        public Room()
        {

        }

        public int GetTemperature()
        {
            return temperature;
        }

        public void CoolRoom()
        {
            temperature -= 1;
        }

        public void HeatRoom()
        {
            temperature += 1;
        }
    }
}
