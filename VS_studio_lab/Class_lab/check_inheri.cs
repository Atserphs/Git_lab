using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_lab
{
 
    interface Iadd
    {
        double add(double a, double b);
    }
    interface Isubtract
    {
        double subtract(double a, double b);
    }

    interface Imultiplication
    {
        double multiplication(double a, double b);
    }
    interface Idivision
    {
      double division(double a, double b);
    }

    class check_inheri: Iadd, Isubtract, Imultiplication, Idivision
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiplication(double a, double b)
        {
            return a * b;
        }

        public double division(double a, double b)
        {
            return a / b;
        }

    }
}
