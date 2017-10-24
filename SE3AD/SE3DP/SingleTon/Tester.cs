using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.SingleTon
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("SingleTon:");
            var s = SingleTon.GetInstance();
            s.Data = "data";
            Console.WriteLine(s.Data);

            var p = SingleTon.GetInstance();
            Console.WriteLine(p.Data);
            SingleTon.ResetInstance();

            var q = SingleTon.GetInstance();
            Console.WriteLine(q.Data);
            Console.WriteLine("End SingleTon");
        }
    }
}
