using System;

namespace SE3DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategie.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            Observer.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            Decorator.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            Command.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            ChainOfRespoibility.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            SingleTon.Tester.Test();
            Console.WriteLine("---------------------------------------------");
            Composite.Tester.Test();
            Console.WriteLine("---------------------------------------------");
        }
    }
}