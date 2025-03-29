using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace console1
{
    class number_swap
    {
        public void number_swap_func()
        {
            int a = 18;
            int b = 6;
            int c;

            Console.WriteLine("\nValues before swap:\n a = " + a + " b = " + b);
            c = b;
            b = a;
            a = c;
            Console.WriteLine("Values after swap:\n a = " + a + " b = " + b);
        }
    }
}
