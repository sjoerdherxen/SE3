using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Composite
{
    class Leaf2 : IBaseComponent
    {
        public void DoAction(int tabs)
        {
            for (var i = 0; i < tabs; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("Leaf2");
        }
    }
}
