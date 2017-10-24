using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.ChainOfRespoibility
{
    class HandlerMed : Handler
    {
        public HandlerMed()
        {
        }

        public HandlerMed(Handler sucessor) : base(sucessor)
        {
        }

        public override void Handle(int weight)
        {
            if (weight < 100)
            {
                Console.WriteLine(weight + " Handled by Med");
            }
            else
            {
                Console.WriteLine(weight + " Too Heavy for Med");
                base.Handle(weight);
            }
        }
    }
}
