using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Decorator
{
    class Cream : CoffeeAddition
    {
        public Cream(CoffeePart parent) : base(parent)
        {
        }

        public override string Make()
        {
            return base.Make() + "\tCream\n";
        }
    }
}
