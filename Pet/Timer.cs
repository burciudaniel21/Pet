using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pet
{
    class Timer
    {
        private int timer;
        private int timerSeconds;

        public Timer()
        {
        }

        public int IncreaseTimer()
        {
            //return Interlocked.Increment(ref timer);
            Thread.Sleep(100);
            timer += 100;
            return timer;
        }

        public int GetTimer()
        {
            return timer;
        }

        public int CountSeconds()
        {
            timer = 0;
            timerSeconds += 1;
            if (timerSeconds == 60)
            {
                timerSeconds = 0;
            }
            return timerSeconds;
        }

        public int GetSeconds()
        {
            return timerSeconds;
        }
    }
}
