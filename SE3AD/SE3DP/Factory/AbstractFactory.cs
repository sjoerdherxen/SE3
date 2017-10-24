using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    abstract class AbstractFactory
    {
        public abstract AbstractButton GetButton();
        public abstract AbstractText GetText();
    }
}
