using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Observer
{
    class ObserverImplentation : IObserver
    {
        private SubjectImplentation subject;
        private string name;
        public ObserverImplentation(SubjectImplentation s, string name)
        {
            subject = s;
            subject.Attach(this);
            this.name = name;
        }

        public void Update()
        {
            Console.WriteLine(name + " called, Data = " + subject.Data);
        }
    }
}
