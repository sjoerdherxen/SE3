using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Factory
{
    class Client
    {
        private AbstractFactory factory;

        public Client(AbstractFactory f)
        {
            factory = f;
        }

        public void SetFactory(AbstractFactory f)
        {
            factory = f;
        }

        public void Draw()
        {
            factory.GetButton().Draw();
            factory.GetText().Draw();
        }
    }
}
