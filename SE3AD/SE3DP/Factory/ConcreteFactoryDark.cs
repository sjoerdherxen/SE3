using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    class ConcreteFactoryDark : AbstractFactory
    {
        public override AbstractButton GetButton()
        {
            return new ButtonDark();
        }

        public override AbstractText GetText()
        {
            return new TextDark();
        }
    }
}
