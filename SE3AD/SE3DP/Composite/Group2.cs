using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Composite
{
    class Group2 : BaseGroup
    {
        public Group2()
        {
        }

        public Group2(IBaseComponent comp) : base(comp)
        {
        }

        public Group2(List<IBaseComponent> comps) : base(comps)
        {
        }

        public override void DoAction(int tabs)
        {
            for (var i = 0; i < tabs; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine("Group2");
            foreach (var comp in Components)
            {
                comp.DoAction(tabs + 1);
            }
        }
    }
}
