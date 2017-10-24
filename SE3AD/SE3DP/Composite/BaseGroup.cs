using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Composite
{
    abstract class BaseGroup : IBaseComponent
    {
        public List<IBaseComponent> Components;

        public abstract void DoAction(int tabs);

        public BaseGroup()
        {
            Components = new List<IBaseComponent>();
        }

        public BaseGroup(IBaseComponent comp)
        {
            Components = new List<IBaseComponent>();
            Components.Add(comp);
        }

        public BaseGroup(List<IBaseComponent> comps)
        {
            Components = comps;
        }
    }
}
