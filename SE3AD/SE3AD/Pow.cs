using System;
using System.Collections.Generic;
using System.Text;

namespace SE3AD
{
    // dit is een extra opdracht
    class Pow
    {
        public static double Power(double x, int y)
        {
            var doneit = new double[100];

            var tmp = x;
            var i = 1;
            var count = 0;
            for(; i <= y; i *= 2)
            {
                doneit[count] = tmp;
                tmp *= tmp;
                count++;
            }

            var output = x;

            while(y > 1)
            {
                if(i <= y)
                {
                    y -= i; 
                    output *= doneit[count];
                }
                count--;
                i /= 2;
            }

            return output;
        }

        public static double PowerR(double x, uint y)
        {
            // Power of 0 is always 1.
            if (y == 0)
            {
                return 1;
            }

            // If an even number.
            if (y % 2 == 0)
            {
                // Integer division the two numbers.
                double temp = PowerR(x, y / 2);
                return temp * temp;
            }

            // If uneven, try again with an even number. And multiply by the recursive answer.
            return x * PowerR(x, y - 1);
        }

        public static double PowerBad(double x, int y)
        {
            var output = x;
            for(int i = 1; i < y; i++)
            {
                //Console.Write("-");
                output *= x;
            }
            return output;
        }
    }
}
