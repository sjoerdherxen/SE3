using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Decorator
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Decorator:");
            var c = new Sugar(new Sugar(new Cream(new Coffee())));
            Console.WriteLine(c.Make());
            Console.WriteLine("End Decorator");
        }
    }
}
