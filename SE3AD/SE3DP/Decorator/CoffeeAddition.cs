using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Decorator
{
    abstract class CoffeeAddition : CoffeePart
    {
        public CoffeePart Parent;
        public CoffeeAddition(CoffeePart parent)
        {
            Parent = parent;
        }

        public override string Make()
        {
            return Parent.Make();
        }
        
    }
}
