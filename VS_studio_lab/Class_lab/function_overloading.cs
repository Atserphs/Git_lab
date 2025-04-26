using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lab
{
    class function_overloading
    {
        public int add_func(int a, int b)
        {
            return a + b;
        }

        public double add_func(double a, double b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

    }
}
