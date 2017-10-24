using System;
using System.Collections.Generic;
using System.Text;

namespace SE3DP.SingleTon
{
    class SingleTon 
    {
        public string Data;
        private static SingleTon instance;

        private SingleTon()
        {
            Data = "Unkown";
        }

        public static SingleTon GetInstance()
        {
            if(instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }

        public static void ResetInstance()
        {
            instance = null;
        }
    }
}
