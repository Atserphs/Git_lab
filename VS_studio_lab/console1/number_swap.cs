using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace console1
{
    class number_swap
    {
        public bool number_swap1()
        {
            int a = 18;
            int b = 6;
            int c;
            c = b;
            b = a;
            a = c;
            if (a == 6 && b == 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
