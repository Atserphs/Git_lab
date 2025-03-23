using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class odd_even
    {
        public string check_odd_even(int a)
        {
            if (a % 2 == 0)
            {
                return ("even");
            }
            else
            {
                return ("odd");
            }
        }
    }
}
