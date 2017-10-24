using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    class TextLight : AbstractText
    {
        public override void Draw()
        {
            Console.WriteLine("Light text");
        }
    }
}
