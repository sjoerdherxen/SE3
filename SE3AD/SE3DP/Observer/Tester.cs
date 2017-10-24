using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Observer
{
    class Tester
    {
        public static void Test()
        {
            Console.WriteLine("Observer:");
            var subject = new SubjectImplentation();
            var observer1 = new ObserverImplentation(subject, "obs1");
            var observer2 = new ObserverImplentation(subject, "obs2");
            subject.Data = "new data";
            Console.WriteLine("End Oberver");
        }
    }
}
