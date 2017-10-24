using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Command
{
    class Remote
    {
        public ICommand Command;

        public Remote(ICommand command)
        {
            Command = command;
        }

        public void SetCommand(ICommand command)
        {
            Command = command;
        }

        public void ButtonPress()
        {
            Command.Excecute();
        }
    }
}
