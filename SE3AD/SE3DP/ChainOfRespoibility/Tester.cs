using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.ChainOfRespoibility
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("ChainOfResposibility:");
            var handler = new HandlerLow(new HandlerMed(new HandlerHigh()));
            handler.Handle(5);
            Console.WriteLine();
            handler.Handle(15);
            Console.WriteLine();
            handler.Handle(105);
            Console.WriteLine();
            handler.Handle(1005);
            Console.WriteLine();
            Console.WriteLine("End ChainOfResposibility");
        }
    }
}
