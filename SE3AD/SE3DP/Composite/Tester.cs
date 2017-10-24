using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Composite
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Compositie:");
            var a = new Group2(new List<IBaseComponent> {
                new Group1(new List<IBaseComponent> { new Leaf1(), new Leaf2() }),
                new Group2(new Leaf1())
            });
            a.DoAction(0);
            Console.WriteLine("End Compositie");
        }
    }
}
