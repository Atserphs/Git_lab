using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class array_index_sum
    {
        public int array_index_sum_func(int[] array)
        {
            int sum = 0;
            foreach (int arr in array)
            {
                sum += arr;
            }
            return sum;

        }
    }
}
