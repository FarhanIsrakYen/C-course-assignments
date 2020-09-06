using System;
using System.Collections.Generic;
using System.Text;

namespace problem27
{
    class Helper
    {
        public int Gcd(int a, int b)
        {
            while (a != b)
                if (a < b) b = b - a;
                else a = a - b;
            return (a);
        }
        public int Division(int a, int b)
        {
            int remainder = a, quotient = 0;
            while (remainder >= b)
            {
                remainder = remainder - b;
                quotient++;
            }
            return (quotient);
        }
    }
}
