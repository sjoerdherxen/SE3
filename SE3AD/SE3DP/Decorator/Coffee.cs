using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Decorator
{
    class Coffee : CoffeePart
    {
        public override string Make()
        {
            return "Coffee\n";
        }
    }
}
