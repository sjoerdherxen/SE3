using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.Observer
{
    class SubjectImplentation : Subject
    {
        private string _data;
        public string Data { get { return _data; } set { _data = value; Notify(); } }
    }
}
