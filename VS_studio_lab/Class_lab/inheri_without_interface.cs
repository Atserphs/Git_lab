using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lab
{
    class inheri_without_interface
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double mul(double a, double b)
        {
            return a * b;
        }

    }
    class inheri_without_interface_child
    {
        public double add(double a, double b)
        {
            return a + b + 1;
        }
    }
}
