using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Strategie
{
    class Enemy : Character
    {
        public Enemy()
        {
            jumpStrategie = new NormalJump();
        }

    }
}
