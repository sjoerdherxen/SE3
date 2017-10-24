using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Decorator
{
    class Sugar : CoffeeAddition
    {
        public Sugar(CoffeePart parent) : base(parent)
        {
        }

        public override string Make()
        {
            return base.Make() + "\tSugar\n";
        }
    }
}
