using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.ChainOfRespoibility
{
    abstract class Handler
    {
        public Handler Sucessor;
        public Handler()
        {

        }

        public Handler(Handler sucessor)
        {
            Sucessor = sucessor;
        }

        public virtual void Handle(int weight)
        {
            if(Sucessor != null)
            {
                Sucessor.Handle(weight);
            }
            else
            {
                Console.WriteLine("No one can handle the weight");
            }
        }
    }
}
