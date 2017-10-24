using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    class ConcreteFactoryLight : AbstractFactory
    {
        public override AbstractButton GetButton()
        {
            return new ButtonLight();
        }

        public override AbstractText GetText()
        {
            return new TextLight();
        }
    }
}
