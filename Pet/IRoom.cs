using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    public interface IRoom //This class follows the Interface Segregation Principle as it is an interface which does not force using methods it doesn't use. All the methods in this interface are core methods required for a room.
    {
        public abstract int GetTemperature();
        public void CoolRoom();
        public void HeatRoom();
    }
}
