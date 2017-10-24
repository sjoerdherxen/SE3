using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.ChainOfRespoibility
{
    class HandlerLow : Handler
    {
        public HandlerLow()
        {
        }

        public HandlerLow(Handler sucessor) : base(sucessor)
        {
        }

        public override void Handle(int weight)
        {
            if (weight < 10)
            {
                Console.WriteLine(weight + " Handled by Low");
            }
            else
            {
                Console.WriteLine(weight + " Too Heavy for Low");
                base.Handle(weight);
            }
        }
    }
}
