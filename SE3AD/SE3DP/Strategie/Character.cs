using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Strategie
{
    abstract class Character
    {
        protected IJumpStrategie jumpStrategie;

        public void Jump()
        {
            jumpStrategie.Jump();
        }
    }
}
