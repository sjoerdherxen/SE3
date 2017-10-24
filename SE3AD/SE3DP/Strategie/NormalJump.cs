using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Strategie
{
    class NormalJump : IJumpStrategie
    {
        public void Jump()
        {
            Console.WriteLine("Normal jump");
        }
    }
}
