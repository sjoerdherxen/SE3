using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Observer
{
    abstract class Subject
    {
        protected List<IObserver> Observers;

        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }

    }
}
