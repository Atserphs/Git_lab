using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class check_greatest
    {
        public int check_greatest_number(int a, int b, int c)
        {
            if (a > b & a > c)
            {
                return a;
            }
            else if (b > a & b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
