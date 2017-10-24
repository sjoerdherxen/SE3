using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Strategie
{
    class Player : Character
    {
        private bool _powerUp;
        public bool PowerUp
        {
            get
            {
                return _powerUp;
            }
            set
            {
                _powerUp = value;
                if (value)
                    jumpStrategie = new HighJump();
                else
                    jumpStrategie = new NormalJump();
            }
        }

        public Player()
        {
            PowerUp = false;
        }   
    }
}
