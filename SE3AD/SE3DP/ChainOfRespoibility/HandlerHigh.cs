using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.ChainOfRespoibility
{
    class HandlerHigh : Handler
    {
        public HandlerHigh()
        {
        }

        public HandlerHigh(Handler sucessor) : base(sucessor)
        {
        }

        public override void Handle(int weight)
        {
            if (weight < 1000)
            {
                Console.WriteLine(weight + " Handled by High");
            }
            else
            {
                Console.WriteLine(weight + " Too Heavy for High");
                base.Handle(weight);
            }
        }
    }
}
