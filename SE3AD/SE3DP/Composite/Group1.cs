using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Composite
{
    class Group1 : BaseGroup
    {
        public Group1()
        {
        }

        public Group1(IBaseComponent comp) : base(comp)
        {
        }

        public Group1(List<IBaseComponent> comps) : base(comps)
        {
        }

        public override void DoAction(int tabs)
        {
            for(var i =0; i < tabs; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("Group1");
            foreach(var comp in Components)
            {
                comp.DoAction(tabs + 1);
            }
        }
    }
}
