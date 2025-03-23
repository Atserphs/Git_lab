using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class factorial_of_number
    {
        public int factorial_of_number_func(int factorial_number)
        {
            int factorial = 1;
            do
            {
                factorial = factorial * factorial_number;
                factorial_number--;
            } while (factorial_number >= 1);
            return factorial;
        }
    }
}
