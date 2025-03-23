using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class check_leap_year
    {
        //Method 1
        public string check_leap_year_func1(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return "Leap_year (from func 1)";
            }
            return "Not a Leap year (from func 1)";
        }
        

         //Method 2
        public string check_leap_year_func2(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0) 
                { 
                    if(year % 400 == 0)
                    {
                        return "Leap year (from func 2)";
                    }
                    return "Not a leap year (from func 2)";
                }
                return "Leap year (from func 2)";
            }
            return "Not a leap year (from func 2)";
        }

        //Method 3
        public string check_leap_year_func3(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) ? "Leap year (from func 3)" : "Not a leap year (from func 3)";
        }

    }
}
