using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Command
{
    class Light : ICommand
    {
        public bool LightIsOn;

        public void Excecute()
        {
            LightIsOn = !LightIsOn;
            Console.WriteLine("Light is on = " + LightIsOn);
        }
    }
}
