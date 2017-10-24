using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Factory:");
            var a = new Client(new ConcreteFactoryDark());
            a.Draw();
            a.SetFactory(new ConcreteFactoryLight());
            a.Draw();
            Console.WriteLine("End Factory");
        }
    }
}
