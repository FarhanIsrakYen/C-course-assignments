using System;

namespace problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int q, dn = 0, m, l;
            int tmp;
            int s;
            int decn = Convert.ToInt32(Console.ReadLine());
            q = decn;
            for (l = q; l > 0; l /= 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp += 48;
                else
                    tmp += 55;
                dn = dn * 100 + tmp;
            }
            for (m = dn; m > 0; m /= 100)
            {
                s = m % 100;
                Console.Write((char)s);
            }
        }
    }
}
