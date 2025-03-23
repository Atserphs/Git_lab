using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class sum_n_number
    {
        public int sum_n_number_func(int n)
        {
            int sum = 0;
            for (int i = 1; i<=n; i++)
            {
                sum = sum + i;    
            }
            return sum;
        }
    }
}
