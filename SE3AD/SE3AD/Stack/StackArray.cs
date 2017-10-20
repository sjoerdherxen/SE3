using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD.Stack
{
    class StackArray
    {
        private string[] stack;
        private int tos;

        public StackArray()
        {
            stack = new string[2];
            tos = -1;
        }

        public void Push(string value)
        {
            tos++;
            if(stack.Length > tos)
            {
                var tmp = new string[tos*2];
                for(var i = 0; i < stack.Length; i++)
                {
                    tmp[i] = stack[i];
                }
                stack = tmp;
            }

            stack[tos] = value;
        }

        public string Pop()
        {
            if(tos == -1) { return null; }
            return stack[tos--];
        }

        public string Look()
        {
            if (tos == -1) { return null; }
            return stack[tos];
        }

    }
}
