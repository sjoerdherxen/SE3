using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Command
{
    // i am a big metal fan
    class Fan : ICommand
    {
        public bool FanIsOn;
        public void Excecute()
        {
            FanIsOn = !FanIsOn;
            Console.WriteLine("Fan is on = " + FanIsOn);
        }
    }
}
