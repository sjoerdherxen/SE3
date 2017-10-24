using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Command
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Command:");
            var remote = new Remote(new Fan());
            remote.ButtonPress();
            remote.ButtonPress();
            remote.ButtonPress();
            remote.SetCommand(new Light());
            remote.ButtonPress();
            remote.ButtonPress();
            remote.ButtonPress();
            Console.WriteLine("End Command");
        }
    }
}
